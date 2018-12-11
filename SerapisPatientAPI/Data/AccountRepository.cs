using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SerapisPatientAPI.Interfaces;
using MongoDB.Driver;

namespace SerapisPatientAPI.Data
{
    public class AccountRepository : IAccountRepository 
    {
        private readonly Context _context = null;
        public AccountRepository()
        {
            _context = new Context();
        }

        public async Task<IEnumerable<PatientUser>> GetAllPatients()
        {
            try
            {
                var result = await  _context.PatientCollection
                    .Find(_ => true).ToListAsync();

                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddPatient(PatientUser patient )
        {
            await _context.PatientCollection.InsertOneAsync(patient);

        }
    }
}
