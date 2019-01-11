using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SerapisPatientAPI.Model;

namespace SerapisPatientAPI.Controllers
{
    
    [Produces("application/json")]
    [Route("api/booking")]
    public class BookingController : Controller
    {
        // GET: api/Booking
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Booking/5
        [HttpGet("{id}", Name = "Get")]
        public PatientUser GetBookedPatient(PatientUser id)
        {
            PatientUser userInformation=new PatientUser();

            if (id !=null)
            {
                userInformation = id;

                return userInformation;
            }
            else
            {
                return null;
            }
        }
        
        // POST: api/Booking
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Booking/5
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
