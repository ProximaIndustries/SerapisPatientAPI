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
    [Route("api/Patient")]
    public class PatientController : Controller
    {
        private readonly Context _context=null;


        // GET: api/Patient
       

        // GET: api/Patient/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<PatientUser> GetPatientMedicalInformation(ObjectId _id)
        {

            if (_id != null)
            {
                try
                {
                    //Try get the patients information
                    //var predicateFilter=filter
                    //var patientsFile=_context.PatientCollection.FindAsync(predicateFilter);
                    return null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                //Return some error message
                return null;
            }
        }
        
        // POST: api/Patient
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Patient/5
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
