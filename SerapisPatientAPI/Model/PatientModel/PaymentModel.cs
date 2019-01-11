using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Model.PatientModel
{
    public class PaymentModel
    {
        public string Token { get; set; }
        public decimal Amount { get; set; }
    }
}
