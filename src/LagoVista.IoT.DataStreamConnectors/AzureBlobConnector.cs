﻿using LagoVista.Core;
using LagoVista.Core.Validation;
using LagoVista.IoT.Logging.Loggers;
using LagoVista.IoT.Pipeline.Admin;
using LagoVista.IoT.Pipeline.Admin.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace LagoVista.IoT.DataStreamConnectors
{
    public class AzureBlobConnector : IDataStreamConnector
    {
        DataStream _stream;
        IInstanceLogger _instanceLogger;
        CloudBlobClient _cloudBlobClient;
        CloudBlobContainer _container;

        private CloudBlobClient CreateBlobClient(DataStream stream)
        {
            var baseuri = $"https://{stream.AzureAccountId}.blob.core.windows.net";

            var uri = new Uri(baseuri);
            return new CloudBlobClient(uri, new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials(stream.AzureAccountId, stream.AzureAccessKey));
        }

        public AzureBlobConnector(IInstanceLogger instanceLogger)
        {
            _instanceLogger = instanceLogger;
        }

        public Task<ValidationResult> ValidationConnection(DataStream stream)
        {
            var result = new ValidationResult();

            return Task.FromResult(result);
        }

        public async Task<InvokeResult> InitAsync(DataStream stream)
        {
            _stream = stream;

            _cloudBlobClient = CreateBlobClient(_stream);
            _container = _cloudBlobClient.GetContainerReference(_stream.AzureBlobStoragePath);
            try
            {
                Microsoft.WindowsAzure.Storage.NameValidator.ValidateContainerName(_stream.AzureBlobStoragePath);

                await _container.CreateIfNotExistsAsync();

                return InvokeResult.Success;
            }
            catch (ArgumentException ex)
            {
                _instanceLogger.AddException("AzureBlobConnector_InitAsync", ex);
                return InvokeResult.FromException("AzureBlobConnector_InitAsync", ex);
            }
            catch (StorageException ex)
            {
                _instanceLogger.AddException("AzureBlobConnector_InitAsync", ex);
                return InvokeResult.FromException("AzureBlobConnector_InitAsync", ex);
            }
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
            var recordId = DateTime.UtcNow.ToInverseTicksRowKey();

            item.Data.Add(_stream.TimeStampFieldName, item.GetTimeStampValue(_stream));
            item.Data.Add("sortOrder", item.GetTicks());
            item.Data.Add("deviceId", item.DeviceId);
            item.Data.Add("id", recordId);
            item.Data.Add("dataStreamId", _stream.Id);

            var fileName = $"{recordId}.json";
            var blob = _container.GetBlockBlobReference(fileName);
            blob.Properties.ContentType = "application/json";
            var json = JsonConvert.SerializeObject(item.Data);

            var numberRetries = 5;
            var retryCount = 0;
            var completed = false;
            while (retryCount++ < numberRetries && !completed)
            {
                try
                {


                    await blob.UploadTextAsync(json);
                }
                catch (Exception ex)
                {
                    if (retryCount == numberRetries)
                    {
                        _instanceLogger.AddException("AzureBlobConnector_AddItemAsync", ex);
                        return InvokeResult.FromException("AzureBlobConnector_AddItemAsync",ex);
                    }
                    else
                    {
                        _instanceLogger.AddCustomEvent(LagoVista.Core.PlatformSupport.LogLevel.Warning, "AzureBlobConnector_AddItemAsync", "", ex.Message.ToKVP("exceptionMessage"), ex.GetType().Name.ToKVP("exceptionType"), retryCount.ToString().ToKVP("retryCount"));
                    }
                    await Task.Delay(retryCount * 250);
                }
            }

            return InvokeResult.Success;
        }

        public Task<LagoVista.Core.Models.UIMetaData.ListResponse<DataStreamResult>> GetItemsAsync(string deviceId, LagoVista.Core.Models.UIMetaData.ListRequest request)
        {
            throw new NotSupportedException("Reading a list of items from azure blob storage is not supported.");
        }

    }
}
