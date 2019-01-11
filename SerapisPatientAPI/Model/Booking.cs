using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Model
{
    public class Booking
    {
        object _id { get; set; }
        DateTime DateBooked { get; set; }
        DateTime TimeBooked { get; set; }
        Doctor DoctorBooked { get; set; }
        Practice PracticeBookedAt { get; set; }
    }
}
