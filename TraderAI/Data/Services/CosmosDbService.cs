namespace Data.Services
{
    using Microsoft.Azure.Cosmos;
    using Models;
    using System.Threading.Tasks;

    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddOhlcDailyRecordAsync(OhlcDailyRecord record){
            await this._container.CreateItemAsync<OhlcDailyRecord>(record, new PartitionKey(record.Ticker));
        }

        public async Task<OhlcDailyRecord> GetOhlcDailyRecordAsync(string id, string ticker)
        {
            try
            {
                ItemResponse<OhlcDailyRecord> response = await this._container.ReadItemAsync<OhlcDailyRecord>(id, new PartitionKey(ticker)); //
                return response.Resource;
            }
            catch(CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }
    }

}