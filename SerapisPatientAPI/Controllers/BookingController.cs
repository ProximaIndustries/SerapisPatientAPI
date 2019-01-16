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
        private readonly IPatientRepository _patientRepository;
        public BookingController(IPatientRepository patientRepository, IBookingRepository bookingRepository)
        {
            _patientRepository = patientRepository;
            _bookingRepository = bookingRepository;
        }

        // GET: api/Booking
        [HttpGet]
        public IEnumerable<string> GetPatientsBookedForTheDay(DateTime date)
        {
            if (date.Date != DateTime.Today)
            {
                //They match todays date 
                return null;
            }
            else
            {
                return null;
            }
        }

        // GET: api/Booking/_id
        [HttpGet("{_id}", Name = "GetBooking")]
        public Task<PatientUser> GetBookedPatientFile(string _id)
        {
            if (_id != null)
            {
                try
                {
                    var file = _patientRepository.GetPatientDetails(_id);

                    return file;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
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
