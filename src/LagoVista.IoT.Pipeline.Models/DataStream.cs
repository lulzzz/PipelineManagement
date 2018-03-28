﻿using LagoVista.Core.Attributes;
using LagoVista.Core.Interfaces;
using LagoVista.Core.Models;
using LagoVista.Core.Validation;
using LagoVista.IoT.Pipeline.Models.Resources;
using System.Collections.Generic;
using System.Linq;

namespace LagoVista.IoT.Pipeline.Admin.Models
{
    public enum DataStreamTypes
    {
        [EnumLabel(DataStream.StreamType_AWS_ElasticSearch, PipelineAdminResources.Names.DataStream_StreamType_AWS_ElasticSearch, typeof(PipelineAdminResources))]
        AWSElasticSearch,
        [EnumLabel(DataStream.StreamType_AWS_S3, PipelineAdminResources.Names.DataStream_StreamType_AWS_S3, typeof(PipelineAdminResources))]
        AWSS3,
        [EnumLabel(DataStream.StreamType_AzureBlob, PipelineAdminResources.Names.DataStream_StreamType_AzureBlob, typeof(PipelineAdminResources))]
        AzureBlob,
        [EnumLabel(DataStream.StreamType_AzureBlob_Managed, PipelineAdminResources.Names.DataStream_StreamType_AzureBlob_Managed, typeof(PipelineAdminResources))]
        AzureBlob_Managed,
        [EnumLabel(DataStream.StreamType_AzureEventHub, PipelineAdminResources.Names.DataStream_StreamType_AzureEventHub, typeof(PipelineAdminResources))]
        AzureEventHub,
        [EnumLabel(DataStream.StreamType_AzureEventHub_Managed, PipelineAdminResources.Names.DataStream_StreamType_AzureEventHub_Managegd, typeof(PipelineAdminResources))]
        AzureEventHub_Managed,
        [EnumLabel(DataStream.StreamType_AzureTableStorage, PipelineAdminResources.Names.DataStream_StreamType_TableStorage, typeof(PipelineAdminResources))]
        AzureTableStorage,
        [EnumLabel(DataStream.StreamType_AzureTableStorage_Managed, PipelineAdminResources.Names.DataStream_StreamType_TableStorage_Managed, typeof(PipelineAdminResources))]
        AzureTableStorage_Managed,
        [EnumLabel(DataStream.StreamType_DataLake, PipelineAdminResources.Names.DataStream_StreamType_DataLake, typeof(PipelineAdminResources))]
        AzureDataLake,
        [EnumLabel(DataStream.StreamType_SQLServer, PipelineAdminResources.Names.DataStream_StreamType_SQLServer, typeof(PipelineAdminResources))]
        SQLServer
    }

    [EntityDescription(PipelineAdminDomain.PipelineAdmin, PipelineAdminResources.Names.DataStream_Title, PipelineAdminResources.Names.DataStream_Help, PipelineAdminResources.Names.DataStream_Description, EntityDescriptionAttribute.EntityTypes.Summary, typeof(PipelineAdminResources))]
    public class DataStream : PipelineModuleConfiguration, IOwnedEntity, IKeyedEntity, INoSQLEntity, IValidateable, IFormDescriptor
    {
        public const string StreamType_AWS_S3 = "awss3";
        public const string StreamType_AWS_ElasticSearch = "awselasticsearch";
        public const string StreamType_AzureBlob = "azureblob";
        public const string StreamType_AzureBlob_Managed = "azureblobmanaged";
        public const string StreamType_AzureTableStorage = "azuretablestorage";
        public const string StreamType_AzureTableStorage_Managed = "azuretablestoragemanaged";
        public const string StreamType_DataLake = "azuredatalake";
        public const string StreamType_AzureEventHub = "azureeventhub";
        public const string StreamType_AzureEventHub_Managed = "azureeventhubmanaged";
        public const string StreamType_SQLServer = "sqlserver";

        public DataStream()
        {
            Fields = new List<DataStreamField>();
        }

        [FormField(LabelResource: PipelineAdminResources.Names.DataStream_StreamType, EnumType: typeof(DataStreamTypes), FieldType: FieldTypes.Picker, RegExValidationMessageResource: PipelineAdminResources.Names.Common_Key_Validation, ResourceType: typeof(PipelineAdminResources), WaterMark: PipelineAdminResources.Names.DataStream_StreamType_Select, IsRequired: true)]
        public EntityHeader<DataStreamTypes> StreamType { get; set; }

        [FormField(LabelResource: PipelineAdminResources.Names.DataStream_ConnectionString, HelpResource: PipelineAdminResources.Names.DataStream_ConnectionString_Help, FieldType: FieldTypes.Text, ResourceType: typeof(PipelineAdminResources), IsRequired: false)]
        public string ConnectionString { get; set; }

        public string SecureConnectionStringId { get; set; }

        [FormField(LabelResource: PipelineAdminResources.Names.DataStream_Fields, FieldType: FieldTypes.ChildList, ResourceType: typeof(PipelineAdminResources))]
        public List<DataStreamField> Fields { get; set; }

        public override string ModuleType => PipelineModuleType_DataStream;

        public new DataStreamSummary CreateSummary()
        {
            return new DataStreamSummary()
            {
                Description = Description,
                Id = Id,
                Name = Name,
                IsPublic = IsPublic,
                Key = Key,
                StreamType = StreamType.Text,
                StreamTypeKey = StreamType.Id
            };
        }

        public List<string> GetFormFields()
        {
            return new List<string>()
            {
                nameof(DataStream.Name),
                nameof(DataStream.Key),
                nameof(DataStream.Description),
            };
        }

        [CustomValidator]
        public void Validate(ValidationResult result)
        {
            if (Fields.Select(fld => fld.Key).Distinct().Count() != Fields.Count) result.Errors.Add(new ErrorMessage("Keys on fields must be unique"));
            if (Fields.Select(fld => fld.FieldName).Distinct().Count() != Fields.Count) result.Errors.Add(new ErrorMessage("Field Names on fields must be unique"));
        }
    }

    public class DataStreamSummary : SummaryData
    {
        public string StreamType { get; set; }
        public string StreamTypeKey { get; set; }
    }
}
