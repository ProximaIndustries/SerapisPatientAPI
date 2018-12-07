using MongoDB.Driver;
using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI
{
    public class Context
    {
        private readonly IMongoDatabase _database;
        public string ConnectionString = "mongodb+srv://Bonga:langelihle@cluster0-bkjo1.mongodb.net/test?retryWrites=true";

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
        public IMongoCollection<Practice> PracticeCollection
        {
            get
            {
                return _database.GetCollection<Practice>("MedicalPractices");
            }
        }
    }
}
