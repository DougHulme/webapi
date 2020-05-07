using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using webapi.Models;
using webapi.Helpers;
using webapi.Data;
using System.Security.Cryptography;
using System.Text;
using System.IO;

using System.Web.Http;

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace webapi.Controllers
{
    public class XeroApiController : ApiController
    {
        //Constructor
        OrionAdminEntities db = new OrionAdminEntities();
        [HttpGet]
        public IHttpActionResult get()
        {

            string payload = db.WebHookLogs.Where(a => a.Id == 191300).Select(a => a.body).FirstOrDefault();
            var xevents = JsonConvert.DeserializeObject<XeroWebhookEvents>(payload);
            foreach (Xerowebhookevent xevent in xevents.events)
            {
                switch (xevent.eventCategory)
                {
                    case "INVOICE":
                        // just update payment at this time
                        var res1 = UNMSHelper.addPaymentFromXero(XeroHelper.getXeroInvoice(xevent.resourceURL.Substring(xevent.resourceURL.Length - 36)));
                        break;
                    case "CONTACT":
                        var res2 = UNMSHelper.addorupdateClientFromXero(XeroHelper.getXeroContact(xevent.resourceURL.Substring(xevent.resourceURL.Length - 36)));
                        break;

                }
           
            }
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult post()
        {
            WebHookLog dbwl = new WebHookLog();
            dbwl.body = "received xero web hook ";
            dbwl.Date = DateTime.Now;
            db.WebHookLogs.Add(dbwl);
            db.SaveChanges();

            // retrieve xero key
            var xerosignature = Request.Headers.GetValues("x-xero-signature").FirstOrDefault();
            var payload= Request.Content.ReadAsStringAsync().Result;
            dbwl.body = payload;
            dbwl.Date = DateTime.Now;
            db.WebHookLogs.Add(dbwl);
            db.SaveChanges();
           
            String app_key = "4q1NTvJRtUuiUCvpo3FKSd3NlAUom53uY+ODoyr4sskmxPa9JSZifVM7g8S8G8k7Ipwde6Hj3MFVXMnmyrD9pg==";
            string generatedsignature = "";
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(app_key)))
            {
                var messageBytes = Encoding.UTF8.GetBytes(payload);
                var hash = hmac.ComputeHash(messageBytes);
                generatedsignature= Convert.ToBase64String(hash);
            }
           
            var isValid = generatedsignature == xerosignature;
            if (!isValid)
            {
                dbwl.body = "Not Valid";
                dbwl.Date = DateTime.Now;
                db.WebHookLogs.Add(dbwl);
                db.SaveChanges();
                return Unauthorized();
            }
           
            var xevents = JsonConvert.DeserializeObject<XeroWebhookEvents>(payload);
            foreach (Xerowebhookevent xevent in xevents.events)
            {
                switch (xevent.eventCategory)
                {
                    case "INVOICE":
                        var res1 = UNMSHelper.addPaymentFromXero(XeroHelper.getXeroInvoice(xevent.resourceId));
                        break;
                    case "CONTACT":
                        // contact updates only come from UNMS
                   //     var res2 = UNMSHelper.addorupdateClientFromXero(XeroHelper.getXeroContact(xevent.resourceId));
                        break;
                   
                }
               
            }
            dbwl.body = "OK Valid";
            dbwl.Date = DateTime.Now;
            db.WebHookLogs.Add(dbwl);
            db.SaveChanges();
            return Ok();

        }
        
       
    }
}