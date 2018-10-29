using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerapisPatientAPI.Model
{
    public class Practice
    {
        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("practiceName")]
        public string PracticeName { get; set; }

        [BsonElement("practicePicture")]
        public string PracticePicture { get; set; }

        [BsonElement("location")]
        public Location Location { get; set; }

        [BsonElement("DoctorAvaliable")]
        public List<Doc> DoctorAvaliable { get; set; }
    }
    public partial class Doc
    {
        [BsonRepresentation(BsonType.ObjectId)]
        //[BsonId]
        public ObjectId docid { get; set; }
    }
    public partial class Location
    {
        [BsonElement("latitude")]
        public string Latitude { get; set; }

        [BsonElement("longitude")]
        public string Longitude { get; set; }

        [BsonElement("workAddress")]
        public WorkAddress WorkAddress { get; set; }

    }

        //public partial class Id
        //{

        //    [BsonRepresentation(BsonType.ObjectId)]
        //    [BsonId]
        //    public string Doctorid { get; set; }

        //}

    public partial class WorkAddress
    {

        [BsonElement("addressLine1")]
        public string AddressLine1 { get; set; }

        [BsonElement("addressLine2")]
        public string AddressLine2 { get; set; }

        [BsonElement("townOrCity")]
        public string TownOrCity { get; set; }

        [BsonElement("postal")]
        public int Postal { get; set; } //might be a long type !=int

    }
    
}
