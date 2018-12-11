using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SerapisPatientAPI.Interfaces;
using SerapisPatientAPI.Model;

namespace SerapisPatientAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Doctor")]
    public class DoctorController : Controller
    {
        
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;    
        }

        // GET: api/Doctor
        [HttpGet]
        public async Task<IEnumerable<Doctor>> Get()
        {
            return await _doctorRepository.GetAllDoctor(); 
        }

        // GET: api/Doctor/5
        [HttpGet("{id}", Name = "GetDoctor")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Doctor
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Doctor/5
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
