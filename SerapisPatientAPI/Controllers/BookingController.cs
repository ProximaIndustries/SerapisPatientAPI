using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SerapisPatientAPI.Interfaces;
using SerapisPatientAPI.Model;
using SerapisPatientAPI.Model.PatientModel;

namespace SerapisPatientAPI.Controllers
{
    
    [Produces("application/json")]
    [Route("api/booking")]
    public class BookingController : Controller
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        // GET: api/Booking
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Booking/5
        [HttpGet("{id}", Name = "GetBooking")]
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
        public async Task<IActionResult> Post([FromBody]PatientBooking appointment)
        {
            await _bookingRepository.MakeBooking(appointment);

            return new OkObjectResult(appointment);
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
