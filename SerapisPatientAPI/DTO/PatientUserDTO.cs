using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.DTO
{
    public partial class PatientUserDTO
    {
    //    DTO(Data Transfer objects) is a data container for moving data between layers.
    //      They are also termed as transfer objects.
    //        DTO is only used to pass data and does not contain any business logic.
    //        They only have simple setters and getters.
       [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailDTO { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PasswordDTO { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [BsonElement("password")]
        public string ConfirmPasswordDTO { get; set; }

        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }
        [BsonElement("profilePicture")]
        public string ProfilePicture { get; set; }

        [BsonElement("surname")]
        public string Surname { get; set; }
        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("cellphone")]
        public double Cellphone { get; set; }

        [BsonElement("bloodType")]
        public string BloodType { get; set; }

        [BsonElement("medicalAid")]
        public string MedicalAid { get; set; }

        [BsonElement("hasDependencies")]
        public bool HasDependencies { get; set; }

        [BsonElement("numOfDependencies")]
        public int NumOfDependencies { get; set; }

        [BsonElement("dependenciesDetails")]
        public List<object> DependenciesDetails { get; set; }

        [BsonElement("allergies")]
        public List<string> Allergies { get; set; }

        [BsonElement("chronicDisease")]
        public List<string> ChronicDisease { get; set; }

        [BsonElement("medicationTaken")]
        public List<string> MedicationTaken { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; }

        [BsonElement("homeAddress")]
        public HomeAddress HomeAddress { get; set; }

        [BsonElement("medicalFiles")]
        public List<object> MedicalFiles { get; set; }

        [BsonElement("bloodPressure")]
        public bool BloodPressure { get; set; }

        [BsonElement("doctorsSeen")]
        public List<string> DoctorsSeen { get; set; }

        [BsonElement("appointments")]
        public List<object> Appointments { get; set; }

        [BsonElement("appointmentHistory")]
        public List<AppointmentHistoryDTO> AppointmentHistory { get; set; }

        [BsonElement("selfPrescriptionHistory")]
        public List<SelfPrescriptionHistoryDTO> SelfPrescriptionHistory { get; set; }

        [BsonElement("prescribedMedicationHistory")]
        public List<PrescribedMedicationHistoryDTO> PrescribedMedicationHistory { get; set; }

        [BsonElement("precribedMedication")]
        public List<object> PrecribedMedication { get; set; }

        [BsonElement("nextOfKins")]
        public List<object> NextOfKins { get; set; }
    }

   

    public partial class AppointmentHistoryDTO
    {
        [BsonElement("date")]
        public string Date { get; set; }

        [BsonElement("time")]
        public string Time { get; set; }

        [BsonElement("doctor")]
        public string Doctor { get; set; }

        [BsonElement("specilization")]
        public string Specilization { get; set; }

        [BsonElement("practice")]
        public string Practice { get; set; }
    }

    public partial class HomeAddressDto
    {
        [BsonElement("addressLine1")]
        public string AddressLine1 { get; set; }

        [BsonElement("addressLine2")]
        public string AddressLine2 { get; set; }

        [BsonElement("townOrCity")]
        public string TownOrCity { get; set; }

        [BsonElement("postalCode")]

        public long PostalCode { get; set; }

        [BsonElement("country")]
        public string Country { get; set; }
    }


    public partial class PrescribedMedicationHistoryDTO
    {
        [BsonElement("medication")]
        public string Medication { get; set; }

        [BsonElement("instructions")]
        public string Instructions { get; set; }

        [BsonElement("dosage")]
        public string Dosage { get; set; }

        [BsonElement("datePrescribed")]
        public string DatePrescribed { get; set; }
    }

    public partial class SelfPrescriptionHistoryDTO
    {
        [BsonElement("prescriptionMedicine")]
        public string PrescriptionMedicine { get; set; }

        [BsonElement("dosageAmountSelfPres")]
        public string DosageAmountSelfPres { get; set; }

        [BsonElement("orderDate")]
        public string OrderDate { get; set; }

        [BsonElement("recoveredTime")]
        public string RecoveredTime { get; set; }
    }
}
