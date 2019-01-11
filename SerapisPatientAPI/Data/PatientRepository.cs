using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SerapisPatientAPI.Interfaces;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SerapisPatientAPI.Data
{
    public class PatientRepository : IPatientRepository 
    {
        private readonly Context _context = null;
        public PatientRepository()
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

        private ObjectId GetInternalId(string id)
        {
            ObjectId internalId;
            if (!ObjectId.TryParse(id, out internalId))
                internalId = ObjectId.Empty;

            return internalId;
        }

        public async Task AddPatient(PatientUser patient )
        {
            //var res = Query<Product>.EQ(p => p.Id, id);
            await _context.PatientCollection.InsertOneAsync(patient);
        }
       
        
    }
}
