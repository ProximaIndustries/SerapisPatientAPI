using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Interfaces
{
    public interface IPracticeRepository
    {
        Task<IEnumerable<Practice>> GetPractices();
    }
}
