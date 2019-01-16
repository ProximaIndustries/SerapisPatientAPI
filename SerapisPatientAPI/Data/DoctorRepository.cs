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
            try
            {
                var result = await _context.DoctorCollection
                .Find(_ => true).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
           
        }

        public async Task AddDoctor(Doctor doc)
        {
            await _context
                .DoctorCollection
                .InsertOneAsync(doc);
        }

        public async Task<Doctor> GetDoctor(string var1)
        {
            try
            {
                return await _context.DoctorCollection
                    .Find(doctor => doctor.FirstName == var1)
                    .FirstOrDefaultAsync();

            }
            catch(Exception ex)
            {
                //log or manage the exception
                throw ex;
            }
        }

        public Task<Doctor> GetDoctor(ObjectId _id)
        {
            throw new NotImplementedException();
        }

        //the IsAcknowledged and ModifiedCount properties, this is how MongoDB keep track of changes.
        //When doing operations such as, 'ReplaceOneAsync()' and 'DeleteOneAsync()', an object is returned, 
        //with this object we can know the database is acknowledge and the amount of elements modified or deleted.
        //We can use this information to identify the success or fail of our operation.

        public async Task<bool> EditDoctor( Doctor doctor)
        {
            ReplaceOneResult replaceOne =
               await _context.DoctorCollection.ReplaceOneAsync(
                    filter: d => d.Id == doctor.Id,
                    replacement: doctor
                    );

            return replaceOne.IsAcknowledged && replaceOne.ModifiedCount > 0;
        }

        public Task<Doctor> RemoveDoctor(ObjectId _id)
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> EditDoctor(ObjectId _id)
        {
            throw new NotImplementedException();
        }
    }
}
