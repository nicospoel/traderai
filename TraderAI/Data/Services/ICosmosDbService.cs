using System;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Services
{
    public interface ICosmosDbService
    {
        Task<OhlcDailyRecord> GetOhlcDailyRecordAsync(string id, string ticker);
        Task AddOhlcDailyRecordAsync(OhlcDailyRecord record);
    }
}
