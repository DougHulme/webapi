using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class UnmsPayment
    {
        public List<Models.PaymentAttributeReadOnly> attributes { get; set; }
    }

    public class UnmsPaymentAdd
    {
        public int? clientId { get; set; }
     
        public string checkNumber { get; set; }
        public string createdDate { get; set; }
        public double amount { get; set; }
        public string currencyCode { get; set; }
        public string note { get; set; }
        public List<int> invoiceIds { get; set; }
        
        public int? userId { get; set; }
       


    }
    public class UnmsPaymentAttribute
    {
        public double? id { get; set; }
        public int paymentId { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string value { get; set; }
        public double? customAttributeId { get; set; }
    }

}