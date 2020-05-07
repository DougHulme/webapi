using Newtonsoft.Json;
using webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.Data;
using webapi.Helpers;

namespace webapi.Controllers
{
    public class UnmsApiController : ApiController
    {
        //Constructor
        OrionAdminEntities db = new OrionAdminEntities();
        [HttpGet]
        public IHttpActionResult get()
        {
                var test =  db.WebHookLogs.Where(a=>a.Id==19935).Select(a=>a.body).FirstOrDefault();
                 WebhookEvent uwebhook = JsonConvert.DeserializeObject<WebhookEvent>(test);

                switch (uwebhook.entity)
               {
                     case "invoice":
                        WebhookEventInvoice webhookinvoice = JsonConvert.DeserializeObject<WebhookEventInvoice>(test);
                         UNMSHelper.addorupdateInvoiceFromUNMS(webhookinvoice.extraData.entity);
                         break;
                     case "payment":
                         WebhookEventPayment webhookpayment = JsonConvert.DeserializeObject<WebhookEventPayment>(test);
                    if (webhookpayment.extraData.entity.Note != "from Xero") { UNMSHelper.addorupdatePaymentFromUNMS(webhookpayment.extraData.entity); }
                         break;
                    case "client":
                        WebhookEventClient webhookclient = JsonConvert.DeserializeObject<WebhookEventClient>(test);
                        UNMSHelper.addorupdateClientFromUNMS(webhookclient.extraData.entity);
                    break;
                case "ticket":
                    WebhookEventTicket webhookticket = JsonConvert.DeserializeObject<WebhookEventTicket>(test);
                    UNMSHelper.editTicketFromUNMS(webhookticket.extraData.entity);
                    break;
            
                case "service":
                        WebhookEventService webhookservice = JsonConvert.DeserializeObject<WebhookEventService>(test);
                        UNMSHelper.suspendServiceFromUNMS(webhookservice.extraData.entity);
                break;
            }
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult post()
        {
            WebHookLog dbwl = new WebHookLog();
            var payload = Request.Content.ReadAsStringAsync().Result;
            dbwl.body = payload;
            dbwl.Date = DateTime.Now;
            db.WebHookLogs.Add(dbwl);
            db.SaveChanges();

            WebhookEvent uwebhook = JsonConvert.DeserializeObject<WebhookEvent>(payload);
            dbwl.body = uwebhook.entity.ToString();
            dbwl.Date = DateTime.Now;
            db.WebHookLogs.Add(dbwl);
            db.SaveChanges();

            

            switch (uwebhook.entity)
            {
                case "invoice":
                    WebhookEventInvoice webhookinvoice = JsonConvert.DeserializeObject<WebhookEventInvoice>(payload);
                    UNMSHelper.addorupdateInvoiceFromUNMS(webhookinvoice.extraData.entity);
                    break;
                case "payment":
                    WebhookEventPayment webhookpayment = JsonConvert.DeserializeObject<WebhookEventPayment>(payload);
                    // check if it came from xero originally
                    if (webhookpayment.extraData.entity.Note != "from Xero") { UNMSHelper.addorupdatePaymentFromUNMS(webhookpayment.extraData.entity); }
                    break;
                case "client":
                    WebhookEventClient webhookclient = JsonConvert.DeserializeObject<WebhookEventClient>(payload);
                    UNMSHelper.addorupdateClientFromUNMS(webhookclient.extraData.entity);
                    break;
                case "ticket":
                    WebhookEventTicket webhookticket = JsonConvert.DeserializeObject<WebhookEventTicket>(payload);
                    UNMSHelper.editTicketFromUNMS(webhookticket.extraData.entity);
                    break;
            }
          

           
            return Ok();

        }
    }
}
