using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class Jobs
    {
    }
    public class JobDetail
    {
        public string dateentered { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string assignedUserId { get; set; }
        public string clientId { get; set; }
        public string userIdent { get; set; }
        public bool? isLead { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string note { get; set; }
        public double? addressGpsLat { get; set; }
        public double? addressGpsLon { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }



    }
}