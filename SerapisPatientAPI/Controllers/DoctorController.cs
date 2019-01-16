using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using SerapisPatientAPI.Interfaces;
using SerapisPatientAPI.Model;

namespace SerapisPatientAPI.Controllers
{
    [Produces("application/json")]
    [Route ("api/doctor")]
    public class DoctorController : Controller
    {
        
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;    
        }

        // GET: api/Doctor
        [HttpGet]
        [Route ("api/Doctor")]
        public async Task<IEnumerable<Doctor>> Get()
        {
            return await _doctorRepository.GetAllDoctor(); 
        }

        // GET: api/Doctor/5
        [HttpGet("{id}", Name = "GetDoctor")]
        public string Get([FromBody]int id)
        {
            if (id != null)
            {
                return "value";
            }
            else
            {
                return null;
            }
        }
        
        // POST: api/Doctor
        [HttpPost]
        public void Post([FromBody]string value)
        {
            
        }
        
        // PUT: api/Doctor/{objectId}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(ObjectId id, [FromBody]Doctor doctor)
        {
            var doctorFromDb = await _doctorRepository.GetDoctor(id);

            if (doctorFromDb == null)
                return new NotFoundResult();

            doctor.Id = doctorFromDb.Id;

            await _doctorRepository.EditDoctor(doctor);

            return new OkObjectResult(doctor);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete([FromBody]int id)
        {
            if (id != null)
            {
                
            }
        }
    }
}
