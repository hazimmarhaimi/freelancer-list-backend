using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreelancerWebService.Models {
    public class FreelancerDemoData {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Skillsets { get; set; }
        public string Hobby { get; set; }
    }
}