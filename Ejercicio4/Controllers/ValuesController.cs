using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ejercicio4.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [Route("values/create/{id}")]
        [HttpPost]
        public IHttpActionResult Create([FromBody] string objetoInsertar,int id)
        {
            var body = JsonConvert.SerializeObject(objetoInsertar);
            //llamada a metodo de insert en BD
            return Ok();
        }
    }
}
