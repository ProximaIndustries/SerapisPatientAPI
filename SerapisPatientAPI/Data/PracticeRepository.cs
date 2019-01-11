using SerapisPatientAPI.Interfaces;
using SerapisPatientAPI.Model;
using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Data
{
    public class PracticeRepository : IPracticeRepository
    {
        private readonly PracticeContext _context = null;

        public PracticeRepository()
        {
            _context = new PracticeContext();
        }

        public Task AddPractice(Practice practice)
        {
            throw new NotImplementedException();
        }

        public Task<Practice> EditPracticeInfo(object _id)
        {
            throw new NotImplementedException();
        }

        public Task<Practice> GetPracticeDetails(object _id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Practice>> GetPractices()
        {
            //var filter = Builders<Practice>.Filter.AnyEq("DoctorAvaliable", new ObjectId ( "5bc8f2c21c9d440000a98282" ));
            //var result = await _context.PracticeCollection
            //    .Find(filter)
            //    .ToListAsync();

            var result = await _context.PracticeCollection
                .Find(_ => true).ToListAsync();

            return result;
        }

        public Task<IEnumerable<Practice>> GetPractices(object _id, double maxDistance)
        {
            throw new NotImplementedException();
        }

        public Task<Practice> RemovePractice(object _id)
        {
            throw new NotImplementedException();
        }
    }
}
