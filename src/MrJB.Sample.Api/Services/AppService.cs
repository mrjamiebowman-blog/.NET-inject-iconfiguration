using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MrJB.Sample.Api
{
    public class AppService : IAppService
    {
        private IConfiguration _configuration;

        public AppService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GetValue2Async()
        {
            // TODO: implement value from configuration
            return await Task.FromResult("TODO");
        }
    }
}