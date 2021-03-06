﻿using LagoVista.Core.Validation;
using LagoVista.IoT.Pipeline.Admin;
using LagoVista.IoT.Pipeline.Admin.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LagoVista.Core;
using System.Data.SqlClient;
using System.Data;

namespace LagoVista.IoT.DataStreamConnectors
{
    public class SQLServerConnector : IDataStreamConnector
    {
        DataStream _stream;
        Logging.Loggers.IInstanceLogger _instanceLogger;
        string _connectionString;

        public class SQLFieldMetaData
        {
            public string ColumnName { get; set; }
            public Boolean IsRequired { get; set; }
            public string DataType { get; set; }
            public Boolean IsIdentity { get; set; }
            public string DefaultValue { get; set; }
        }

        public SQLServerConnector(Logging.Loggers.IInstanceLogger instanceLogger)
        {
            _instanceLogger = instanceLogger;
        }

        public async Task<ValidationResult> ValidationConnection(DataStream stream)
        {
            var result = new ValidationResult();

            /* be careful when updating the SQL below, the rdr uses field indexes,
             * if this wasn't so small and self contained, I probably wouldn't be so lazy,
             * buf for one field...well...moving on.*/
            var sql = $@"
select
	b.name as ColumnName,
	type_name(b.xusertype) ColumnType,
	b.IsNullable,
	columnproperty(a.id, b.name, 'isIdentity') IsIdentity,
	sm.text AS DefaultValue
from sysobjects a 
   inner join syscolumns b on a.id = b.id
   LEFT JOIN sys.syscomments sm ON sm.id = b.cdefault
    WHERE a.xtype = 'U' and a.name = @tableName";

            var fields = new List<SQLFieldMetaData>();

            using (var cn = new System.Data.SqlClient.SqlConnection(_connectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@tableName", stream.DBTableName);
                try
                {
                    await cn.OpenAsync();
                    using (var rdr = await cmd.ExecuteReaderAsync())
                    {
                        while (await rdr.ReadAsync())
                        {
                            fields.Add(new SQLFieldMetaData()
                            {
                                ColumnName = rdr["ColumnName"].ToString(),
                                IsRequired = !Convert.ToBoolean(rdr["IsNullable"]),
                                DataType = rdr["ColumnType"].ToString(),
                                IsIdentity = Convert.ToBoolean(rdr["IsIdentity"]),
                                DefaultValue = Convert.ToString(rdr["DefaultValue"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.AddUserError($"Could not access SQL Server: {ex.Message}.");
                    return result;
                }
            }

            if (fields.Count == 0)
            {
                result.AddUserError($"Table [{stream.DBTableName}] name not found on SQL Server database [{stream.DBName}] on server [{stream.DBURL}.");
            }
            else
            {
                result.Concat(stream.ValidateSQLSeverMetaData(fields));
            }

            return result;
        }

        public async Task<InvokeResult> InitAsync(DataStream stream)
        {
            _stream = stream;

            var builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder.Add("Data Source", stream.DBURL);
            builder.Add("Initial Catalog", stream.DBName);
            builder.Add("User Id", stream.DBUserName);
            builder.Add("Password", stream.DBPassword);
            _connectionString = builder.ConnectionString;

            if (stream.DBValidateSchema)
            {
                var result = await ValidationConnection(stream);
                if (!result.Successful)
                {
                    _instanceLogger.AddError("SQLServerConnecction", "Could not validate SQL Connection", result.Errors.First().Message.ToKVP("firstError"));
                    return result.ToInvokeResult();
                }
            }

            return InvokeResult.Success;
        }

        public Task<InvokeResult> AddItemAsync(DataStreamRecord item, LagoVista.Core.Models.EntityHeader org, LagoVista.Core.Models.EntityHeader user)
        {
            item.Data.Add("orgId", org.Id);
            item.Data.Add("orgName", org.Text);

            item.Data.Add("userId", user.Id);
            item.Data.Add("userName", user.Text);

            return AddItemAsync(item);
        }

        public async Task<InvokeResult> AddItemAsync(DataStreamRecord item)
        {

            var fields = String.Empty;
            var values = String.Empty;
            foreach (var fld in _stream.Fields)
            {
                /* validation should happen long before this point, however if someone manipulated the value, it could be very, very bad
                 * with a SQL injection attack, so error on the side of caution and never let it get through.
                 */
                if (!Validator.Validate(fld).Successful) throw new Exception($"Invalid field name {fld.FieldName}");

                fields += String.IsNullOrEmpty(fields) ? $"{fld.FieldName}" : $",{fld.FieldName}";
                values += String.IsNullOrEmpty(values) ? $"@{fld.FieldName}" : $",@{fld.FieldName}";
            }

            fields += $",{_stream.DeviceIdFieldName},{_stream.TimeStampFieldName}";
            values += $",@{_stream.DeviceIdFieldName},@{_stream.TimeStampFieldName}";

            var sql = $"insert into [{_stream.DBTableName}] ({fields}) values ({values})";

            using (var cn = new System.Data.SqlClient.SqlConnection(_connectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(sql, cn))
            {
                cmd.CommandType = System.Data.CommandType.Text;

                foreach (var field in _stream.Fields)
                {
                    object value = System.DBNull.Value;

                    if (item.Data.ContainsKey(field.FieldName))
                    {
                        value = item.Data[field.FieldName];
                        if (value == null)
                        {
                            value = System.DBNull.Value;
                        }
                    }

                    if (value != System.DBNull.Value && field.FieldType.Value == DeviceAdmin.Models.ParameterTypes.GeoLocation)
                    {
                        var geoParts = value.ToString().Split(',');
                        if (geoParts.Count() != 2)
                        {
                            return InvokeResult.FromError($"Attmept to insert invalid geo code {value}");
                        }

                        // Note geo codes ares stored HH.MMMMMM,HH.MMMMMM where lat comes first, SQL expects those to come lon then lat
                        var parameter = new SqlParameter($"@{field.FieldName}", $"POINT({geoParts[1]} {geoParts[0]})")
                        {
                            Direction = ParameterDirection.Input,
                        };

                        cmd.Parameters.Add(parameter);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue($"@{field.FieldName}", value);
                    }
                }

                if (String.IsNullOrEmpty(item.Timestamp))
                {
                    item.Timestamp = DateTime.UtcNow.ToJSONString();
                }

                cmd.Parameters.AddWithValue($"@{_stream.TimeStampFieldName}", item.Timestamp.ToDateTime());
                cmd.Parameters.AddWithValue($"@{_stream.DeviceIdFieldName}", item.DeviceId);

                await cn.OpenAsync();
                var insertResult = await cmd.ExecuteNonQueryAsync();
            }

            return InvokeResult.Success;
        }

        public async Task<LagoVista.Core.Models.UIMetaData.ListResponse<DataStreamResult>> GetItemsAsync(string deviceId, LagoVista.Core.Models.UIMetaData.ListRequest request)
        {

            var sql = new StringBuilder("select ");
            if (request.PageSize == 0) request.PageSize = 50;

            sql.Append($"[{_stream.TimeStampFieldName}]");
            foreach (var fld in _stream.Fields)
            {
                sql.Append($", [{fld.FieldName}]");
            }

            sql.AppendLine();
            sql.AppendLine($"  from  [{_stream.DBTableName}]");
            sql.AppendLine($"  where [{_stream.DeviceIdFieldName}] = @deviceId");

            if (!String.IsNullOrEmpty(request.NextRowKey))
            {
                sql.AppendLine($"  and {_stream.TimeStampFieldName} < @lastDateStamp");
            }

            if (!String.IsNullOrEmpty(request.StartDate)) sql.AppendLine($"  and {_stream.TimeStampFieldName} >= @startDateStamp");
            if (!String.IsNullOrEmpty(request.EndDate)) sql.AppendLine($"  and {_stream.TimeStampFieldName} <= @endDateStamp");

            sql.AppendLine($"  order by [{_stream.TimeStampFieldName}] desc");
            sql.AppendLine("   OFFSET @PageSize * @PageIndex ROWS");
            sql.AppendLine("   FETCH NEXT @PageSize ROWS ONLY ");

            Console.WriteLine(sql.ToString());

            var responseItems = new List<DataStreamResult>();

            using (var cn = new System.Data.SqlClient.SqlConnection(_connectionString))
            using (var cmd = new System.Data.SqlClient.SqlCommand(sql.ToString(), cn))
            {
                cmd.Parameters.AddWithValue("@deviceId", deviceId);
                cmd.Parameters.AddWithValue("@PageSize", request.PageSize);
                cmd.Parameters.AddWithValue("@PageIndex", request.PageIndex);

                if (!String.IsNullOrEmpty(request.NextRowKey)) cmd.Parameters.AddWithValue($"@lastDateStamp", request.NextRowKey.ToDateTime());
                if (!String.IsNullOrEmpty(request.StartDate)) cmd.Parameters.AddWithValue($"@startDateStamp", request.StartDate.ToDateTime());
                if (!String.IsNullOrEmpty(request.EndDate)) cmd.Parameters.AddWithValue($"@endDateStamp", request.EndDate.ToDateTime());

                cmd.CommandType = System.Data.CommandType.Text;

                await cmd.Connection.OpenAsync();
                using (var rdr = await cmd.ExecuteReaderAsync())
                {
                    while (rdr.Read())
                    {
                        var resultItem = new DataStreamResult();
                        resultItem.Timestamp = Convert.ToDateTime(rdr[_stream.TimeStampFieldName]).ToJSONString();

                        foreach(var fld in _stream.Fields)
                        {
                            resultItem.Fields.Add(fld.FieldName, rdr[fld.FieldName]);
                        }

                        responseItems.Add(resultItem);
                    }
                }
            }

            var response = new Core.Models.UIMetaData.ListResponse<DataStreamResult>();
            response.Model = responseItems;
            response.PageSize = responseItems.Count;
            response.PageIndex = request.PageIndex;
            response.HasMoreRecords = responseItems.Count == request.PageSize;
            if (response.HasMoreRecords)
            {
                response.NextRowKey = responseItems.Last().Timestamp;
            }

            return response;
        }
    }
}

