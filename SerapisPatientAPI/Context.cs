using MongoDB.Driver;
using SerapisPatientAPI.Model;
using SerapisPatientAPI.Model.PatientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI
{
    public class Context
    {
        private readonly IMongoDatabase _database;

        //string connectVar = "mongodb://Bonga:Langelihle1!@cluster0-shard-00-00-bkjo1.mongodb.net:27017,cluster0-shard-00-01-bkjo1.mongodb.net:27017,cluster0-shard-00-02-bkjo1.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true";

        public string ConnectionString = "mongodb+srv://KhanyiTheGreat:Langelihle1!@cluster0-i3gjx.azure.mongodb.net/test?retryWrites=true";

        public Context()
        {
            var client = new MongoClient(ConnectionString);
            if (client != null)
                _database = client.GetDatabase("SerapisMedical");

        }

        public IMongoCollection<Doctor> DoctorModel
        {
            get
            {
                return _database.GetCollection<Doctor>("MedicalProfessionals");
                
            }
        }

        public IMongoCollection<PatientBooking> BookingsCollection => _database.GetCollection<PatientBooking>("PatientBookings");
        

        public IMongoCollection<Practice> PracticeCollection
        {
            get
            {
                return _database.GetCollection<Practice>("MedicalPractices");
            }
        }
        public IMongoCollection<PatientUser> PatientCollection
        {
            get
            {
                return _database.GetCollection<PatientUser>("Patients");
            }
        }
    }
}
