using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.ReferenciaDBService;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class DBController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            ReferenciaDBService.Service1Client c = new Service1Client();
            c.GetMariaData(1, "persona", "aallanrddb");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
