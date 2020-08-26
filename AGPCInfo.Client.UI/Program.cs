using AGPCInfo.Client.Library.Helpers;
using AGPCInfo.Client.Library.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AGPCInfo.Client.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConfigHelper config = new ConfigHelper();
            PCInfoHelper infoHelper = new PCInfoHelper(config);
            PCConfiguration pcConfiguration = new PCConfiguration(infoHelper);

            var pc = pcConfiguration.GetConfiguration();

            APIHelper apiHelper = new APIHelper();

            Task task = apiHelper.CreatePCConfigurationAsync(pc);
        }
    }
}
