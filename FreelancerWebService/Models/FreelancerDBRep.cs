using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FreelancerWebService.Models {
    public class FreelancerDBRep : FreelancerDBEntities
    {
        public List<FreelancerDatas2> GetAllFreelancerRecord() {
            return FreelancerData.ToList();
        }
        public FreelancerDatas2 GetFreelancerRecord(int ID) {
            FreelancerDatas2 fdResult = null;
            List<FreelancerDatas2> lstFreelancer = FreelancerData.Where(t => t.Id== ID)
                .ToList();
            fdResult = lstFreelancer.FirstOrDefault();
            return fdResult;
        }

        public int CreateNewRecord(FreelancerDatas2 fdData) 
        {
            try {
                FreelancerData.Add(fdData);
                SaveChanges();
            } catch (Exception) {
                // Handle the exception appropriately (you may log it or take other actions).
                return 1; // or throw;
            }

            return 0;
        }
        public int UpdateRecord(FreelancerDatas2 fdData) {
            try {
                // Find the existing record in the database based on its ID.
                var existingRecord = FreelancerData.Find(fdData.Id);

                if (existingRecord == null) {
                    // If the record is not found, return an error code or throw an exception.
                    return 1; // or throw new Exception("Record not found");
                }

                // Update the properties of the existing record with the new values.
                existingRecord.Username = fdData.Username;
                existingRecord.Email = fdData.Email;
                existingRecord.PhoneNumber = fdData.PhoneNumber;
                existingRecord.Skillsets = fdData.Skillsets;
                existingRecord.Hobby = fdData.Hobby;

                // Save the changes to the database.
                SaveChanges();
            } catch (Exception) {
                // Handle the exception appropriately (you may log it or take other actions).
                return 1; // or throw;
            }

            return 0;
        }

        public int RemoveRecord(int id) {
            try {
                // Find the existing record in the database based on its ID.
                var existingRecord = FreelancerData.Find(id);

                if (existingRecord == null) {
                    // If the record is not found, return an error code or throw an exception.
                    return 1; // or throw new Exception("Record not found");
                }

                // Remove the selected record from the database.
                FreelancerData.Remove(existingRecord);

                // Save the changes to the database.
                SaveChanges();
            } catch (Exception) {
                // Handle the exception appropriately (you may log it or take other actions).
                return 1; // or throw;
            }

            return 0;
        }

    }
}