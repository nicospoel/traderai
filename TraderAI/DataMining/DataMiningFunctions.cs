using System;
using System.Net.Http;
using DataMiningFunctions.Core.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DataMiningFunctions
{
    public class DataMiningFunctions
    {
        private readonly IAlphaVantageService _alphaVantageService;
        private readonly HttpClient _client;

        public DataMiningFunctions(IAlphaVantageService alphaVantageService, HttpClient client)
        {
            _alphaVantageService = alphaVantageService(client);
        }

        [FunctionName("GetDailyOhlc")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
