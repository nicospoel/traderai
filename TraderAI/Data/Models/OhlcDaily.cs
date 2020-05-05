using System;
namespace Data.Models
{
    using Newtonsoft.Json;

    public class DailyData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ticker")]
        public string Ticker {get;set;}

        
    }
}
