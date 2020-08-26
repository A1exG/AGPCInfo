using AGPCInfo.DataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AGPCInfo.DataManager.API.Controllers
{
    public class PCController : ApiController
    {
        // GET: api/PC
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PC/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PC
        public void Post([FromBody]PCApiModels pc)
        {
            var output = pc.PCName + pc.RAM + pc.OperativeSystem + pc.Drive + pc.CPU + pc.GPU;
        }

        // PUT: api/PC/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PC/5
        public void Delete(int id)
        {
        }
    }
}
