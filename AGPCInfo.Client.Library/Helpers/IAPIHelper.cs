using AGPCInfo.Client.Library.Model;
using System.Net.Http;
using System.Threading.Tasks;

namespace AGPCInfo.Client.Library.Helpers
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }

        Task CreatePCConfigurationAsync(ThisPCClientModel pc);
    }
}