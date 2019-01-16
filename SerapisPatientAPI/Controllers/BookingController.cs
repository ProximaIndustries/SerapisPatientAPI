using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using SerapisPatientAPI.Data;
using SerapisPatientAPI.Interfaces;
using SerapisPatientAPI.Model;

namespace SerapisPatientAPI.Controllers
{
    
    [Produces("application/json")]
    [Route("api/booking")]
    public class BookingController : Controller
    {
        //Insatiate object
        private readonly IPatientRepository _patientRepository;
        public BookingController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
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

        // GET: api/Booking/objectId
        [HttpGet("{_id}", Name = "GetBooking")]
        public Task<PatientUser> GetBookedPatientFile(string _id)
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
