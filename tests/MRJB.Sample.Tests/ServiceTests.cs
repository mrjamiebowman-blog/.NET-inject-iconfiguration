using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MrJB.Sample.Api;
using MrJB.Sample.Api.Configuration;
using Xunit;

namespace MRJB.Sample.Tests
{
    public class ServiceTests
    {
        private readonly ApplicationConfiguration _appConfig = new ApplicationConfiguration()
        {
            Value1 = "VALUE#1",
            Value2 = "VALUE#2"
        };

        [Fact]
        public async Task AppServiceGetValueTests()
        {
            try
            {
                // arrange: convert to dictionary (key-value pair)
                var dictionary = new Dictionary<string, string>();
                
                // create IConfiguration object using the In-Memory Collection
                IConfiguration configuration = new ConfigurationBuilder()
                    .AddInMemoryCollection(dictionary)
                    .Build();

                var appService = new AppService(configuration);
                
                // act
                var value = await appService.GetValue2Async();

                // assert
                Assert.Equal(_appConfig.Value2, value);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
