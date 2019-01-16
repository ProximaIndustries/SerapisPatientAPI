using MongoDB.Driver;
using SerapisPatientAPI.Interfaces;
using SerapisPatientAPI.Model;
using SerapisPatientAPI.Model.PatientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Data
{
    public class BookingRepository : IBookingRepository
    {
        private readonly Context _context = null;

        public BookingRepository()
        {
            _context = new Context();   
        }

        public async Task MakeBooking(PatientBooking booking)
        {
            try
            {
                 await _context.BookingsCollection.InsertOneAsync(booking);
            }

            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }

        }

        public async Task<bool> UpdateBooking(PatientBooking booking)
        {
            ReplaceOneResult updateresult = await _context
                .BookingsCollection
                .ReplaceOneAsync(
                filter: b => b.BookingID == booking.BookingID,
                        replacement: booking);

            return updateresult.IsAcknowledged && updateresult.ModifiedCount > 0;
        }

        public async Task<bool> Delete(string name)
        {
            FilterDefinition<PatientBooking> filter = Builders<PatientBooking>.Filter.Eq(d => d.BookingID, name);
            DeleteResult deleteResult = await _context
                                                .BookingsCollection
                                                .DeleteOneAsync(filter);
            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }

        public Task<Booking> AddBooking(Booking appointmentBooking)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Booking>> GetAllAvaliableBookings(IPracticeRepository maxPracticeDistance)
        {
            throw new NotImplementedException();
        }

        public Task CancelBooking(object _id)
        {
            throw new NotImplementedException();
        }

        public Task PostponeBooking(object _id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<PatientBooking>> GetBookedPatientsAsync(
            DateTime _dateBooked, Practice _practice)
        {
            try
            {
                Practice practice = new Practice();

                var predicate = _dateBooked == DateTime.Today;

                var predicate1 = _practice.PracticeName == practice.PracticeName;

                if (predicate && predicate1)
                {
                    var filter = Builders<PatientBooking>
                        .Filter
                        .Eq("dateBooked", _dateBooked);

                    //var result = await _context.PracticeCollection.Find(filter);

                    //Temp code
                    return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        Task<IEnumerable<Booking>> IBookingRepository.GetBookedPatientsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
