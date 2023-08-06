using FreelancerWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FreelancerWebService.Controllers
{
    public class FreelancerDataController : ApiController
    {
        // GET: api/FreelancerData
        public List<FreelancerDatas2> Get()
        {
            FreelancerDBRep dbRep = new FreelancerDBRep();
            return dbRep.GetAllFreelancerRecord();
        }

        // GET: api/FreelancerData/5
        public IHttpActionResult Get(int id) {
            FreelancerDBRep dbRep = new FreelancerDBRep();

            var freelancerData = dbRep.GetFreelancerRecord(id);

            if (freelancerData == null) {
                // If the record is not found, return a response with a custom message.
                return Content(HttpStatusCode.NotFound, "Data not found for the specified ID.");
            }

            return Ok(freelancerData);
        }


        // POST: api/FreelancerData
        public IHttpActionResult Post([FromBody] FreelancerDatas2 value) {
            FreelancerDBRep dbRep = new FreelancerDBRep();
            int nRet = dbRep.CreateNewRecord(value);

            if (nRet == 0) {
                // If the record is successfully registered, return a response with a custom message.
                return Content(HttpStatusCode.Created, $"FreelancerID {value.Id} with Username {value.Username} has been registered.");
            } else {
                // If there was an error, return a response with an appropriate message.
                return Content(HttpStatusCode.InternalServerError, "Registration failed.");
            }
        }


        // PUT: api/FreelancerData/5
        public IHttpActionResult Put(int id, [FromBody] FreelancerDatas2 value) {
            FreelancerDBRep dbRep = new FreelancerDBRep();
            value.Id = id; // Ensure that the ID of the updated record is set correctly.
            int nRet = dbRep.UpdateRecord(value);

            if (nRet == 0) {
                // If the record is successfully updated, return a response with a custom message.
                return Content(HttpStatusCode.OK, $"FreelancerID {id} with Username {value.Username} has been updated.");
            } else {
                // If the record does not exist or there was an error, return a response with an appropriate message.
                return Content(HttpStatusCode.NotFound, "Record not found or update failed.");
            }
        }


        /// DELETE: api/FreelancerData/5
        public IHttpActionResult Delete(int id) {
            FreelancerDBRep dbRep = new FreelancerDBRep();

            int nRet = dbRep.RemoveRecord(id);

            if (nRet == 0) {
                // If the record is successfully deleted, return a response with a custom message.
                return Content(HttpStatusCode.OK, $"FreelancerID {id} has been deleted.");
            } else {
                // If the record does not exist or there was an error, return a response with an appropriate message.
                return Content(HttpStatusCode.NotFound, "Record not found or deletion failed.");
            }
        }

    }
}
