using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class XeroWebhookEvents
    {
        public List<Xerowebhookevent> events {get; set;}
        public int lastEventSequence { get; set; }
        public int firstEventSequence { get; set; }
        public string entropy { get; set; }
    }
    public class Xerowebhookevent
    {
        public string resourceURL { get; set; }
        public string resourceId { get; set; }
        public string eventDateUTC { get; set; }
        public string eventType { get; set; }
        public string eventCategory { get; set; }
        public string tenantId { get; set; }
        public string tenantType { get; set; }

    }
}