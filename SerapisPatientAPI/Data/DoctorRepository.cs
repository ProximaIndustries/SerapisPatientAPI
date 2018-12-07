using SerapisPatientAPI.Model;
using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using SerapisPatientAPI.Interfaces;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Data
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly Context _context = null;

        public DoctorRepository()
        {
            _context = new Context();
        }

        //Just as an example: to get all the Doctors in DB, we make an async request
        public async Task<IEnumerable<Doctor>> GetAllDoctor()
        {
            var result = await _context.DoctorModel
                .Find(_ => true).ToListAsync();

            return result;
        }

        public async Task AddDoctor(Doctor doc)
        {
            await _context.DoctorModel.InsertOneAsync(doc);
        }
    }
}
