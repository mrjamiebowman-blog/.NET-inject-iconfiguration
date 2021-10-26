using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MrJB.Sample.Api;
using MrJB.Sample.Api.Configuration;
using Xunit;

namespace MRJB.Sample.Tests
{
    public class ServiceTests
    {
        [Fact]
        public void AppServiceGetValueTests()
        {
            try
            {
                // arrange
                var appConfig = new ApplicationConfiguration();
                appConfig.Value1 = "VALUE#1";
                appConfig.Value2 = "VALUE#2";

                // convert to dictionary (key-value pair)
                var dictionary = new Dictionary<string, string>();
                
                // create IConfiguration object using the In-Memory Collection
                IConfiguration configuration = new ConfigurationBuilder()
                    .AddInMemoryCollection(dictionary)
                    .Build();

                var appService = new AppService(configuration);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
