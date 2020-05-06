using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using DataMiningFunctions.Core.Services;

[assembly: FunctionsStartup(typeof(DataMiningFunctions.Startup))]

namespace DataMiningFunctions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();

            builder.Services.AddSingleton((s) => { return new AlphaVantageService(); });


        }
    }
}
