using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SerapisPatientAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Practice")]
    public class PracticeController : ControllerBase
    {
        // GET: api/Practice
        [HttpGet]
        public void Get()
        {
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Practice/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Practice
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Practice/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
