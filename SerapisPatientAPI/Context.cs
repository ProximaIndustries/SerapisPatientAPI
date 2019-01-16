using MongoDB.Bson;
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
        //public string ConnectionString = "mongodb+srv://Bonga:Langelihle1!@cluster0-bkjo1.mongodb.net/test?retryWrites=true";

        public string ConnectionString = "mongodb+srv://KhanyiTheGreat:Langelihle1!@cluster0-i3gjx.azure.mongodb.net/test?retryWrites=true";
        //serapis
        public Context()
        {
            var client = new MongoClient(ConnectionString);
            if (client != null)
                _database = client.GetDatabase("SerapisMedical");
            bool isMongoLive = _database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

            if (isMongoLive)
            {
                Exception exception = new Exception();
                //throw exception;
            }
            else
            {
                // couldn't connect
                Exception _exception = new Exception();
                //throw _exception;
            }

        }

        public IMongoCollection<Doctor> DoctorCollection
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
