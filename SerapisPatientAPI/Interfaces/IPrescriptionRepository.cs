﻿using SerapisPatientAPI.Model.DoctorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Interfaces
{
    public interface IPrescriptionRepository
    {
        //Get the prescription from mongodb --database doctor , patients and pharamcies use this method
        IEnumerable<DoctorPrescription> GetDocPrescription(int medId, int doctorId);

        //Post the prescription to mongoDb --Doctor app only 
        DoctorPrescription PrescribeMedication();

        //Put -only a doctor can edit the prescription (going to add this feature later on)
        DoctorPrescription EditPrescription(int doctorId);

        //Delete- only the same doctor can delete a prescription 
        DoctorPrescription RemovePrescription(int doctorId);
    }
}
