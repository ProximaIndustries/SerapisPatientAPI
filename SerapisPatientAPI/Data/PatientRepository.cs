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

        //For Doctor use only
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

        public async Task AddPatient()
        {
            //var res = Query<Product>.EQ(p => p.Id, id);
            //await _context.PatientCollection.InsertOneAsync(res);
        }

        public async Task RemovePatient(PatientUser _id)
        {
            if (_id != null)
            {
                //var somePredicate=Query<Patient>.Eq(p=>p.id, id)
                //await _context.PatientCollection.DeleteOneAsync(somePredicate);
            }
            else
            {
                //don't do anything
            }
        }

        public async Task EditPatientUser(PatientUser _id)
        {
            if (_id != null)
            {
                //var somePredicate=Query<Patient>.Eq(p=>p.id, id)
               // await _context.PatientCollection.UpdateOneAsync<PatientUser>(somePredicate);
            }
        }
    }
}
