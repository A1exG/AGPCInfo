using AGPCInfo.Client.Library.Model;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AGPCInfo.Client.Library.Helpers
{
    public class APIHelper : IAPIHelper
    {
        private HttpClient _apiClient;
        public APIHelper()
        {
            InitializeClient();
        }

        public HttpClient ApiClient
        {
            get
            {
                return _apiClient;
            }
        }
        private void InitializeClient()
        {

            string api = ConfigurationManager.AppSettings["Uri"];

            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
