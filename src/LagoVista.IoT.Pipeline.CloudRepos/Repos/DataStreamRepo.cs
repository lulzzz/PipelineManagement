﻿using LagoVista.CloudStorage.DocumentDB;
using LagoVista.IoT.Logging.Loggers;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using LagoVista.IoT.Pipeline.Admin.Models;
using LagoVista.IoT.Pipeline.Admin.Repos;

namespace LagoVista.IoT.Pipeline.CloudRepos.Repos
{
    public class DataStreamRepo : DocumentDBRepoBase<DataStream>, IDataStreamRepo
    {
        private bool _shouldConsolidateCollections;

        public DataStreamRepo(IPipelineAdminRepoSettings repoSettings, IAdminLogger logger) : 
            base(repoSettings.PipelineAdminDocDbStorage.Uri, repoSettings.PipelineAdminDocDbStorage.AccessKey, repoSettings.PipelineAdminDocDbStorage.ResourceName, logger)
        {
            _shouldConsolidateCollections = repoSettings.ShouldConsolidateCollections;
        }

        protected override bool ShouldConsolidateCollections => _shouldConsolidateCollections;


        public Task AddDataStreamAsync(DataStream dataStream)
        {
            return CreateDocumentAsync(dataStream);
        }

        public Task DeleteDataStreamAsync(string dataStreamId)
        {
            return DeleteDocumentAsync(dataStreamId);
        }

        public Task<DataStream> GetDataStreamAsync(string id)
        {
            return GetDocumentAsync(id);
        }

        public async Task<IEnumerable<DataStreamSummary>> GetDataStreamsForOrgAsync(string orgId)
        {
            var items = await base.QueryAsync(qry => qry.OwnerOrganization.Id == orgId);

            return from item in items
                   select item.CreateSummary();
        }

        public async Task<bool> QueryKeyInUseAsync(string key, string orgId)
        {
            var items = await base.QueryAsync(attr => (attr.OwnerOrganization.Id == orgId || attr.IsPublic == true) && attr.Key == key);
            return items.Any();
        }

        public Task UpdateDataStreamAsync(DataStream dataStream)
        {
            return UpsertDocumentAsync(dataStream);
        }
    }
}
