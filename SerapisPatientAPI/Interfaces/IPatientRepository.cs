using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Interfaces
{
    public interface IPatientRepository
    {
        Task<IEnumerable<PatientUser>> GetAllPatients();
        Task AddPatient(PatientUser user);
    }
}
