using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Interfaces
{
    public interface IPatientRepository
    {
        //Get all the patients booked for the day (used in the doctors application)
        Task<IEnumerable<PatientUser>> GetAllPatients();

        //Add a new patient to the platform (used for the patient applcation)
        Task AddPatient();

        //Remove the patient from the platfom (used in the patient application)
        Task RemovePatient(PatientUser _id);

        //Put-- Edit patient information (used both in the doctor app and patient)
        //The doctor uses it to add information and edit incorrect medical information
        //The patient can add more information about themeselves
        Task EditPatientUser(PatientUser _id);
    }
}
