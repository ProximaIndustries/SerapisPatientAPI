using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SerapisPatientAPI.Model.DoctorModel;

namespace SerapisPatientAPI.Controllers
{
    public class PrescriptionController : Controller
    {
      


        // GET: Prescription/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prescription/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prescription/Create
        [HttpPost]
        [Route ("api/prescription")]
        [ValidateAntiForgeryToken]
        public void Create(DoctorPrescription collection)
        {
            try
            {
                // TODO: Add insert logic here

            }
            catch
            {
                
            }
        }

        // GET: Prescription/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prescription/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

               
            }
            catch
            {
               
            }
        }

        // GET: Prescription/Delete/5
        public void Delete(int id)
        {
            
        }

        [HttpGet]
        [Route ("api/prescriptions")]
        public List<DoctorPrescription> GetDoctorPrescription()
        {
            List<DoctorPrescription> dummyPrescription = new List<DoctorPrescription>();

            dummyPrescription = new List<DoctorPrescription>()
            {
                new DoctorPrescription{ PrescriptionDosage="22mg/hl", PrescriptionInstructions="Once every meal"}
            };

            return dummyPrescription;
        }
        
        // POST: Prescription/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
            }
            catch
            {
               
            }
        }
    }
}