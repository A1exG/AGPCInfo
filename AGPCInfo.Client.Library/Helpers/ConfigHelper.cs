using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGPCInfo.Client.Library.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        public string GetKey(string name)
        {
            string key = ConfigurationManager.AppSettings[name];

            if (key == null)
            {
                throw new ConfigurationErrorsException("Нет такого запроса");
            }
            return key;
        }
    }
}
