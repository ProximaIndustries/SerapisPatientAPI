﻿using System;
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
    [Route("api/Practice")]
    public class PracticeController : ControllerBase
    {
        private readonly IPracticeRepository _practiceRepository;
        public PracticeController(IPracticeRepository practiceRepository)
        {
            _practiceRepository = practiceRepository;
        }

        // GET: api/Practice
        [HttpGet]
        [Route("api/Practice")]
        public async Task<IEnumerable<Practice>> Get()
        {
            return await _practiceRepository.GetPractices();
        }

        // GET: api/Practice/5
        [HttpGet("{id}", Name = "GetPractice")]
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
