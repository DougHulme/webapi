using Newtonsoft.Json;
using webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xero.Api.Core.Model;
using Xero.Api.Core;
using Xero.Api.Serialization;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Example.Applications.Private;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Net.Security;
using System.Net.Http.Headers;
using webapi.Data;

namespace webapi.Helpers
{
    class UNMSHelper
    {
        public static List<InvoiceReadOnly> getinvoices()
        {
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("invoices").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<InvoiceReadOnly>>(responseString);
            }
            else
            {
                return null;
            }
        }
        public static int getcustomattributeid(string lable)
        {
            int customattributeid = 0;
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("custom-attributes").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                List<CustomAttributeReadOnly> calist = JsonConvert.DeserializeObject<List<CustomAttributeReadOnly>>(responseString);

                foreach (CustomAttributeReadOnly ca in calist)
                {
                    if (ca.Name == "xeroIdinvoice") { customattributeid = Convert.ToInt32(ca.Id); }
                }

            }
            return customattributeid;
        }
        public static int getclientbyxeroid(string xeroid)
        {
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("clients?customAttributeKey=xeroIdclient&customAttributeValue=" + xeroid).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                List<ClientReadOnly> uclients = JsonConvert.DeserializeObject<List<ClientReadOnly>>(responseString);
                foreach (ClientReadOnly uclient in uclients)
                {
                    if ((uclient.Attributes.Count != 0) && (uclient.Attributes[0].value == xeroid)) { return Convert.ToInt32(uclient.Id); }
                }
            }
            return 0;
        }
        public static double getclientIdbyPhone(string PhoneNo)
        {
            string phonelookup = PhoneNo;

           if(phonelookup.Substring(0,2)=="44")
            {
                phonelookup = "0" + phonelookup.Substring(2);
            }
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("clients").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                List<ClientReadOnly> uclients = JsonConvert.DeserializeObject<List<ClientReadOnly>>(responseString);
                foreach (ClientReadOnly uclient in uclients)
                {
                    foreach(ClientContactReadOnly contactIn in uclient.Contacts)
                    {
                        if (contactIn.Phone == phonelookup){ return uclient.Id;}
                    }
                }
            }
            return 0;
        }
        public static ClientReadOnly getclientbyid(double ucrmid)
        {
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("clients/" + ucrmid).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<ClientReadOnly>(responseString);
               
            }
            else
            { 
            return null;
            }
        }
        public static int getinvoicebyxeroid(string xeroid, int clientid)
        {
            var client = HTTPHelper.gethttpclient();
            var response = client.GetAsync("invoices?clientId=" + clientid).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                // by calling .Result you are synchronously reading the result
                var responseString = responseContent.ReadAsStringAsync().Result;
                List<InvoiceReadOnly> uinvoices = JsonConvert.DeserializeObject<List<InvoiceReadOnly>>(responseString);
                foreach (InvoiceReadOnly uinvoice in uinvoices)
                {
                    if ((uinvoice.Attributes.Count != 0) && (uinvoice.Attributes[0].Value == xeroid)) { return Convert.ToInt32(uinvoice.Id); }
                }
            }
            return 0;
        }
        public static InvoiceReadOnly getinvoicebynumber(string ucrmid)
        {
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("invoices?number=" + ucrmid).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<InvoiceReadOnly>(responseString.Substring(1,responseString.Length-2));
            }
            else
            {
                return null;
            }
        }
        public static string getinvoicexeroidbyid(double ucrmid)
        {
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("invoices/"+ ucrmid).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                if (responseString.Substring(0, 1) == "[") { responseString = responseString.Substring(1, responseString.Length - 2); }
                var inv = JsonConvert.DeserializeObject<InvoiceReadOnly>(responseString);
                foreach (InvoiceAttributeReadOnly IA in inv.Attributes)
                {
                    if (IA.Name == "xeroIdinvoice") { return IA.Value; }
                }
                return null;
            }
            else 
            { return null; 
            }
           
        }
        public static string getinvoicenumberbyid(double ucrmid)
        {
            var client = HTTPHelper.gethttpclient();
            var response = client.GetAsync("invoices/" + ucrmid).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                if (responseString.Substring(0, 1) == "[") { responseString = responseString.Substring(1, responseString.Length - 2); }
                var inv = JsonConvert.DeserializeObject<InvoiceReadOnly>(responseString);
                return inv.Number;
            }
            else
            {
                return null;
            }
        }
        public static PaymentReadOnly getpaymentbyid(int ucrmid)
        {
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("payments/" + ucrmid).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                if (responseString.Substring(0, 1) == "[") { responseString = responseString.Substring(1, responseString.Length - 2); }
                return JsonConvert.DeserializeObject<PaymentReadOnly>(responseString);

            }
            else
            {
                return null;
            }
        }
        public static List<Models.User> getusers()
        {
            var client = HTTPHelper.gethttpclient();

            var response = client.GetAsync("users/admins").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;
                if (responseString.Substring(0, 1) == "[") { responseString = responseString.Substring(1, responseString.Length - 2); }
                return JsonConvert.DeserializeObject<List<Models.User>>(responseString);

            }
            else
            {
                return null;
            }
        }
        public static Boolean addorupdateClientFromXero(Contact xcontact)
        {
                // is the xero id already present
                int ucrmclientid = UNMSHelper.getclientbyxeroid(xcontact.Id.ToString());

                webapi.Models.ClientContactWritable newunmscontact;
                List<webapi.Models.ClientContactWritable> newlistcontacts = new List<webapi.Models.ClientContactWritable>();

                if ((xcontact.EmailAddress != "") || (xcontact.Phones.Any(_ => _.PhoneNumber != "")))
                {
                    newunmscontact = new webapi.Models.ClientContactWritable()
                    {
                        Phone = xcontact.Phones.First().PhoneAreaCode + xcontact.Phones.First().PhoneNumber,
                        Email = xcontact.EmailAddress,
                        IsBilling = true,
                        IsContact = true
                    };
                    newlistcontacts.Add(newunmscontact);
                }

                if (xcontact.Phones.Any(_ => _.PhoneNumber != ""))
                {
                    newunmscontact = new ClientContactWritable()
                    {
                        Phone = xcontact.Phones[3].PhoneAreaCode + xcontact.Phones[3].PhoneNumber
                    };
                    newlistcontacts.Add(newunmscontact);
                }

                var newUcrmAttribute = new ClientAttribute()
                {
                    CustomAttributeId = 1,
                    Value = xcontact.Id.ToString()
                };
                List<ClientAttribute> newlistattributes = new List<ClientAttribute>();
                newlistattributes.Add(newUcrmAttribute);

                string templastname;
                string tempfirstname;
                bool tempLead = false;
                if (xcontact.IsCustomer == false) { tempLead = true; }
                if ((xcontact.FirstName == null) && (xcontact.LastName == null))
                {
                    tempfirstname = null;
                    templastname = xcontact.Name;
                }
                else
                {
                    tempfirstname = xcontact.FirstName;
                    templastname = xcontact.LastName;
                }

                var newunmsclient = new ClientWritable()
                {
                    OrganizationId = 1,
                    IsLead = tempLead,
                    FirstName = tempfirstname,
                    LastName = templastname,
                    UserIdent = "",
                    Street1 = xcontact.Addresses[1].AddressLine1,
                    Street2 = xcontact.Addresses[1].AddressLine2,
                    City = xcontact.Addresses[1].City,
                    ZipCode = xcontact.Addresses[1].PostalCode,
                    Attributes = newlistattributes,
                    Contacts = newlistcontacts,
                    InvoiceAddressSameAsContact = true,
                    Username = xcontact.EmailAddress,
                    InvoiceMaturityDays = null,
                    RegistrationDate = "2019-09-01T00:00:00+0100"
                };

                if (ucrmclientid == 0)
                {
                    var uc = HTTPHelper.httpPost("clients", newunmsclient);
                }
                else
                {
                    var uc = HTTPHelper.httpPatch("clients/" + ucrmclientid, newunmsclient);
                }
               
               
            return true;
        }
        public static Boolean editTicketFromUNMS(TicketReadOnly Ticket)
        {
            double clientId = 0;
           if(Ticket.Subject== "You have a new voicemail message for 01884 221122")
            {
                foreach(TicketActivityReadOnly ta in Ticket.Activity)
                {
                    string phoneLU = ta.Comment.Body;
                    phoneLU = phoneLU.Substring(phoneLU.IndexOf("Caller: ")+9);
                    phoneLU = phoneLU.Substring(0, phoneLU.IndexOf("Time")-1);
                    clientId = getclientIdbyPhone(phoneLU);
                    if (clientId != 0)
                    {
                        unmsticketpatchclientid ticketpatch = new unmsticketpatchclientid();

                        ticketpatch.clientId = Convert.ToInt32(clientId);
                        ticketpatch.subject = "New voicemail";
                        var u = HTTPHelper.httpPatch("ticketing/tickets/" + Ticket.Id, ticketpatch);
                    }
                }
               
            }
           else
            { if (Ticket.Subject.Substring(0, 12) == "Message from") 
                {
                    clientId = getclientIdbyPhone(Ticket.Subject.Substring(13));
                    if (clientId != 0)
                    {
                        unmsticketpatchclientid ticketpatch = new unmsticketpatchclientid();
                        
                        ticketpatch.clientId = Convert.ToInt32(clientId);
                        ticketpatch.subject = "New SMS message";
                        var u=HTTPHelper.httpPatch("ticketing/tickets/"+Ticket.Id, ticketpatch);
                    }
                }
            }
           if(clientId!=0)
            {

            }
            return true;

        }
        public static Boolean removetickets()
        {
            
            string ssro = HTTPHelper.httpGet("ticketing/tickets");
            List<TicketReadOnly> sro = JsonConvert.DeserializeObject<List<TicketReadOnly>>(ssro);
            foreach (TicketReadOnly se in sro)
            {
                if (se.Id < 1325)
                {
                        HTTPHelper.httpDelete("ticketing/tickets/" + se.Id);
                }
            }
            return true;

        }
        public static Boolean addPaymentFromXero(Xero.Api.Core.Model.Invoice xinvoice)
        {
            if ((xinvoice.Type == Xero.Api.Core.Model.Types.InvoiceType.AccountsReceivable)&&(xinvoice.Reference!="from Unms"))
            {
                // check if invoice matches contact
                int ucrmclientid = UNMSHelper.getclientbyxeroid(xinvoice.Contact.Id.ToString());
                if(ucrmclientid!=0)
                {
                    // only move payments currently
                    if (xinvoice.Payments!=null)
                    {
                        foreach (Xero.Api.Core.Model.Payment Xpay in xinvoice.Payments )
                        {
                            if (Xpay.Reference == "from Unms")
                            {
                                Models.UnmsPaymentAdd Upay = new Models.UnmsPaymentAdd();
                                Upay.amount = Convert.ToDouble(Xpay.Amount);
                                Upay.clientId = ucrmclientid;
                                Upay.createdDate = string.Format("{0:s}", Xpay.Date) + "+0000";
                                Upay.note = "from Xero";
                                Upay.userId = 1924;
                                var uc = HTTPHelper.httpPost("payments", Upay);
                            }
                        }
                    }
                }
            }
                return true;
        }
        public static Boolean addorupdateInvoiceFromUNMS(InvoiceReadOnly uinvoice)
        {
           
            ClientReadOnly uclient = getclientbyid(Convert.ToDouble(uinvoice.ClientId));

            string clientxeroid = "";
            foreach (ClientAttributeReadOnly ca in uclient.Attributes)
            {
                if (ca.name == "xeroIdclient") { clientxeroid = ca.value; };
            }
            if (clientxeroid == "") { clientxeroid=XeroHelper.updateorcreatexerocontact(uclient,""); }

            string invoicexeroid = "";
            foreach (InvoiceAttributeReadOnly ca in uinvoice.Attributes)
            {
                if (ca.Name == "xeroIdinvoice") { invoicexeroid = ca.Value; };
            }
            if (invoicexeroid == "") { XeroHelper.updateorcreatexeroinvoice(uinvoice, clientxeroid ); }
            return true;
        }
        public static Boolean addorupdateClientFromUNMS(ClientReadOnly uclient)
        {
            // get latest client info
            uclient = getclientbyid(uclient.Id);
            string clientxeroid = "";
            foreach (ClientAttributeReadOnly ca in uclient.Attributes)
            {
                if (ca.name == "xeroIdclient") { clientxeroid = ca.value; };
            }
                  if (clientxeroid == "")
            { clientxeroid = XeroHelper.updateorcreatexerocontact(uclient,""); }
            else { clientxeroid = XeroHelper.updateorcreatexerocontact(uclient, clientxeroid); }
           
            return true;
        }
        public static Boolean addorupdatePaymentFromUNMS(PaymentReadOnly upayment)
        {

            ClientReadOnly uclient = getclientbyid(Convert.ToDouble(upayment.ClientId));

            string clientxeroid = "";
            foreach (ClientAttributeReadOnly ca in uclient.Attributes)
            {
                if (ca.name == "xeroIdclient") { clientxeroid = ca.value; };
            }
            if (clientxeroid == "") { return false; }

            string paymentxeroid = "";
            foreach (PaymentAttributeReadOnly ca in upayment.Attributes)
            {
                if (ca.Name == "xeroIdinvoice") { paymentxeroid = ca.Value; };
            }
            if (paymentxeroid == "") { XeroHelper.updateorcreatexeropayment(upayment, clientxeroid); }
            return true;
        }
        public static Boolean suspendServiceFromUNMS(ServiceReadOnly uservice)
        {
            
            ClientReadOnly uclient = getclientbyid(Convert.ToDouble(uservice.ClientId));
            string pppoeid = "";
            foreach (ClientAttributeReadOnly ca in uclient.Attributes)
            {
                if (ca.name == "PPPoE User") { pppoeid = ca.value; };
            }
            if(pppoeid!=""){

            }
            return true;
        }
    }
}
