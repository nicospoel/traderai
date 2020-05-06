using System;
namespace Data.Models
{
    using Newtonsoft.Json;

    public class OhlcDailyRecord
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ticker")] // partition key
        public string Ticker {get;set;}

        [JsonProperty("year")]
        public string Year { get; set; }

        
    }
}
