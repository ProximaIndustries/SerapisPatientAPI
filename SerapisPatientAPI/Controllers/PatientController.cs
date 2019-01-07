using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using SerapisPatientAPI.DTO;
using SerapisPatientAPI.Interfaces;
using SerapisPatientAPI.Model;

namespace SerapisPatientAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Patient")]
    public class PatientController : Controller
    {

        private readonly IPatientRepository _patientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        //GET: api/Account
        [HttpGet]
        public async Task<IEnumerable<PatientUser>> Get()
        {
            return await _patientRepository.GetAllPatients();
        }

        // GET: api/Account/5
        [HttpGet("{id}", Name = "GetAccount")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Account
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PatientUser patient)
        {
            //should pass through the DTO befoere going to the model(business logic)
            await _patientRepository.AddPatient(patient);
            return new OkObjectResult(patient);
        }

        // PUT: api/Account
        public void Update(PatientUser patient)
        {
            
        }
       
    }
}