﻿using SerapisPatientAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SerapisPatientAPI.Interfaces;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SerapisPatientAPI.Data
{
    public class PatientRepository : IPatientRepository 
    {
        private readonly Context _context = null;
        public PatientRepository()
        {
            _context = new Context();
        }

        private ObjectId GetInternalId(string id)
        {
            ObjectId internalId;
            if (!ObjectId.TryParse(id, out internalId))
                internalId = ObjectId.Empty;

            return internalId;
        }

        //Add patient to the platform
        public async Task AddPatient(PatientUser newPatientToPlatform)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Remove patient from the platform
        public async Task RemovePatient(PatientUser _id)
        {
            try
            {
                if (_id != null)
                {
                    var filter = Builders<PatientUser>
                        .Filter
                        .Eq("_id", _id);

                    var result = await _context.PatientCollection.DeleteOneAsync(filter);

                    if (result.IsAcknowledged)
                    {
                        //send email to tell the customer that we have removed their profile
                    }
                    else
                    {
                        //There was error
                    }
                }
                else
                {
                    //don't do anything
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Edit patients file/information
        public async Task EditPatientUser(PatientUser _id)
        {
            try
            {
                if (_id != null)
                {
                    //Specifiy the filter 
                    var filter = Builders<PatientUser>
                        .Filter
                        .Eq("_id", _id);

                    //Get the information in the Mongo database
                    //Need to add another parameter to the method up top
                    var result = await _context.PatientCollection.UpdateOneAsync(filter, "Changed info object here");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get a particular patient info
        public async Task<PatientUser> GetPatientDetails(string name)
        {
            //5c0ef23c1c9d440000eee9ae

            try
            {
                if (name != null)
                {
                    var filter = Builders<PatientUser>
                         .Filter
                         .Eq("firstName", name);

                    var result = await _context.PatientCollection.Find(filter).FirstOrDefaultAsync();

                    return result;

                }
                else
                {
                    return null;
                }
            }
            catch (TimeoutException timeOut)
            {
                throw timeOut;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
