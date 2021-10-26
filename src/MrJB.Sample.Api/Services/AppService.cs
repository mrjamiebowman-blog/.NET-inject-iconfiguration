using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MrJB.Sample.Api.Configuration;

namespace MrJB.Sample.Api
{
    public class AppService : IAppService
    {
        private IConfiguration _configuration;
        private ApplicationConfiguration _appConfig;

        public AppService(IConfiguration configuration)
        {
            _configuration = configuration;
            
            // bind configuration
            var appConfig = new ApplicationConfiguration();
            _configuration.GetSection(ApplicationConfiguration.Position).Bind(appConfig);
            _appConfig = appConfig;
        }

        /// <summary>
        /// Sample method to return Value #2 from the 'ApplicationConfiguration' class.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetValue2Async()
        {
            return await Task.FromResult(_appConfig.Value2);
        }
    }
}