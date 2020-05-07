using webapi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using webapi.Data;
using Xero.Api.Core;
using Xero.Api.Core.Model;
using Xero.Api.Example.Applications.Private;
using Xero.Api.Serialization;
using Xero.Api.Infrastructure.OAuth;
using Invoice = webapi.Models.Invoice;

namespace webapi.Helpers
{
    public class XeroHelper
    {
        public static XeroCoreApi getxeroapp()
        {
            string _xeroConsumerKey = "SXLUSMLYQCOINMJAW5YHGVO3J4G3GV";
            string _xeroConsumerSecret = "2VS2IPJNWAUXUNYF8AAIXVJJBRXOLK";
            string _xeroPFXFileString = "C:/OrionAdmin/public_privatekey.pfx";
            return new XeroCoreApi("https://api.xero.com/api.xro/2.0/", new PrivateAuthenticator(_xeroPFXFileString, "L0gan2015"),
                         new Xero.Api.Infrastructure.OAuth.Consumer(_xeroConsumerKey, _xeroConsumerSecret), null, new DefaultMapper(), new DefaultMapper());
        }
        public static bool importxerocontact()
        {
            XeroCoreApi xeroapp = getxeroapp();
            int z = 0;
            while ((z <= 50))
            {
                List<Contact> contacts = xeroapp.Contacts.Page(z).Where("IsCustomer=true").Find().ToList();
                if (contacts.Count == 0)
                    break;
                foreach (Contact contact in contacts)

                {
                    UNMSHelper.addorupdateClientFromXero(contact);
                }
                z = z + 1;
            }
            return true;
        }
        public static bool deletexerocontact(string xeroId)
        {
            XeroCoreApi xeroapp = getxeroapp();
            var contact = xeroapp.Contacts.Find(xeroId);
            contact.ContactStatus = Xero.Api.Core.Model.Status.ContactStatus.Archived;
            xeroapp.Update(contact);
            return true;
        }
        public static string updateorcreatexerocontact(ClientReadOnly UClient, string clientxeroid)
        {
            XeroCoreApi xeroapp = getxeroapp();
            Contact contact = new Contact();
            if (clientxeroid!="")
            {
                contact = getXeroContact(clientxeroid);
            }
          
            if (UClient.CompanyName!="")
            {
                contact.Name = UClient.CompanyName;
                contact.FirstName = UClient.CompanyContactFirstName;
                contact.LastName = UClient.CompanyContactLastName;
            }
            else
            {
                contact.Name = UClient.FirstName + " " + UClient.LastName;
                contact.FirstName = UClient.FirstName;
                contact.LastName = UClient.LastName;
            }
           
           
            List<Phone> phonesl = new List<Phone>();
            if (UClient.Contacts.FirstOrDefault().Phone != null)
            {
                Phone phn1 = new Phone();
                phn1.PhoneType = Xero.Api.Core.Model.Types.PhoneType.Mobile;
                phn1.PhoneNumber = UClient.Contacts.FirstOrDefault().Phone;
                phonesl.Add(phn1);
            }

            contact.Phones = phonesl;
            List<Address> addl = new List<Address>();

            Address add = new Address();
            add.AddressType = Xero.Api.Core.Model.Types.AddressType.PostOfficeBox;
            add.AddressLine1 = UClient.Street1;
            add.AddressLine2 = UClient.Street2;
            add.City = UClient.City;
            add.PostalCode = UClient.ZipCode;

            addl.Add(add);
            contact.Addresses = addl;
            contact.EmailAddress = UClient.Contacts.FirstOrDefault().Email;
            Xero.Api.Core.Model.Contact contactreturned = xeroapp.Update(contact);
            // now update the crm with the xeroid
            if (clientxeroid == "")
            {
                UnmsClient UXClient = new UnmsClient();
                ClientAttribute newUcrmAttribute = new ClientAttribute()
                {
                    CustomAttributeId = 1,
                    Value = contactreturned.Id.ToString()
                };
                List<ClientAttribute> newlistattributes = new List<ClientAttribute>();
                newlistattributes.Add(newUcrmAttribute);
                UXClient.attributes = newlistattributes;

                HTTPHelper.httpPatch("clients" + "/" + UClient.Id, UXClient);
            }
            return contactreturned.Id.ToString();
        }
        public static string updateorcreatexeroinvoice(InvoiceReadOnly Uinvoice, string clientxeroid)
        {
            XeroCoreApi xeroapp = getxeroapp();
            Xero.Api.Core.Model.Invoice Xinvoice = new Xero.Api.Core.Model.Invoice();
            Xinvoice.Number = Uinvoice.Number;
            Xero.Api.Core.Model.Contact Xcontact = xeroapp.Contacts.Find(new Guid(clientxeroid));
            Xinvoice.Contact = Xcontact;
            Xinvoice.Date = Convert.ToDateTime(Uinvoice.CreatedDate);
            Xinvoice.Type = Xero.Api.Core.Model.Types.InvoiceType.AccountsReceivable;
            Xinvoice.LineAmountTypes = Xero.Api.Core.Model.Types.LineAmountType.Inclusive;
            Xinvoice.Status = Xero.Api.Core.Model.Status.InvoiceStatus.Authorised;
            Xinvoice.DueDate = Convert.ToDateTime(Uinvoice.DueDate);
            List<LineItem> Xiilist = new List<LineItem>();
            foreach (InvoiceItemReadOnly uii in Uinvoice.Items)
            {
                Xero.Api.Core.Model.LineItem xii = new Xero.Api.Core.Model.LineItem();
                xii.Quantity = Convert.ToDecimal(uii.Quantity);
                xii.Description = uii.Label;
                xii.UnitAmount = Convert.ToDecimal(uii.Price);
                xii.LineAmount = Convert.ToDecimal(uii.Total);
                xii.AccountCode = "200";
                Xiilist.Add(xii);
            }
            Xinvoice.LineItems = Xiilist;
            Xero.Api.Core.Model.Invoice Xinvoicereturned = xeroapp.Update(Xinvoice);

            UnmsInvoice UXinvoice = new UnmsInvoice();
            InvoiceAttribute newUcrmAttribute = new InvoiceAttribute()
            {
                CustomAttributeId = UNMSHelper.getcustomattributeid("xeroIdinvoice"),
                Value = Xinvoicereturned.Id.ToString()
            };
            List<InvoiceAttribute> newlistattributes = new List<InvoiceAttribute>();
            newlistattributes.Add(newUcrmAttribute);
            UXinvoice.attributes = newlistattributes;
            
            HTTPHelper.httpPatch("invoices" + "/" + Uinvoice.Id, UXinvoice);
            return Xinvoice.Id.ToString();
        }
        public static bool updateorcreatexeropayment(PaymentReadOnly Upayment, string clientxeroid)
        {
            XeroCoreApi xeroapp = getxeroapp();
            Xero.Api.Core.Model.Payment Xpayment = new Xero.Api.Core.Model.Payment();
            Xpayment.Amount = Convert.ToDecimal(Upayment.Amount);
            Xpayment.Date = Convert.ToDateTime(Upayment.CreatedDate);
            Xpayment.Status = Xero.Api.Core.Model.Status.PaymentStatus.Authorised;
            Xpayment.Type = Xero.Api.Core.Model.Types.PaymentType.AccountsReceivable;
            Xpayment.Account = xeroapp.Accounts.Where("Name==\"Stripe Payment Account\"").Find().First();
            Xpayment.Reference = "from Unms";
            foreach(PaymentCoverReadOnly pc in Upayment.PaymentCovers)
            {
                string invnumber = UNMSHelper.getinvoicenumberbyid(Convert.ToDouble(pc.InvoiceId));
                Xpayment.Invoice = xeroapp.Invoices.Where("InvoiceNumber=\"" + invnumber + "\"").Find().FirstOrDefault();
            }
            Xero.Api.Core.Model.Payment Xpaymentreturned = xeroapp.Update(Xpayment);
            return true;
        }
        public static Xero.Api.Core.Model.Invoice getXeroInvoice(string invoicexeroid)
        {

            XeroCoreApi xeroapp = getxeroapp();
            Xero.Api.Core.Model.Invoice Xinvoice = xeroapp.Invoices.Find(new Guid(invoicexeroid));
            return Xinvoice;
        }
        public static Xero.Api.Core.Model.Contact getXeroContact(string contactxeroid)
        {
            XeroCoreApi xeroapp = getxeroapp();
            Xero.Api.Core.Model.Contact Xcontact = xeroapp.Contacts.Find(new Guid(contactxeroid));
            return Xcontact;
        }
    }
}