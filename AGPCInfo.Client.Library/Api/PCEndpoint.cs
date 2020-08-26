using AGPCInfo.Client.Library.Helpers;
using AGPCInfo.Client.Library.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AGPCInfo.Client.Library.Api
{
    public class PCEndpoint
    {
        private IAPIHelper _apiHelper;
        public PCEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task CreatePCConfigurationAsync(ThisPCClientModel pc)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("api/pc", pc))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
