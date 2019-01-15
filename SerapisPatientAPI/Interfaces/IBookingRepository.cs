﻿using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SerapisPatientAPI.Interfaces
{
    public interface IBookingRepository
    {
        //Create-- Make a booking for the patient
        Task<Booking> AddBooking(Booking appointmentBooking);

        //Get availiable bookings
        Task<IEnumerable<Booking>> GetAllAvaliableBookings(IPracticeRepository maxPracticeDistance);

        //Remove booking
        //This comes with fees, will add logic later on so leave for now
        Task CancelBooking(object _id);

        //Postpone booking, (leave for now, for version 3.5 or something)
        Task PostponeBooking(object _id);

        //Get a particular patients information
        Task<PatientUser> GetPatientFileAsync(int _id);

        //Get bookings for today
        Task <IEnumerable<Booking>> GetBookedPatientsAsync();

    }
}
