using System.Threading.Tasks;

namespace MrJB.Sample.Api
{
    public interface IAppService
    {
        Task<string> GetValueAsync;
    }
}