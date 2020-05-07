/*
 * UCRMAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;




namespace webapi.Models
{
    public class Payment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? clientId;
        private int method;
        private string checkNumber;
        private string createdDate;
        private double amount;
        private string currencyCode;
        private string note;
        private List<int> invoiceIds;
        private string providerName;
        private string providerPaymentId;
        private string providerPaymentTime;
        private bool? applyToInvoicesAutomatically;
        private double? userId;
     

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientId")]
        public int? ClientId 
        { 
            get 
            {
                return this.clientId; 
            } 
            set 
            {
                this.clientId = value;
                onPropertyChanged("ClientId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("method")]
        public int Method 
        { 
            get 
            {
                return this.method; 
            } 
            set 
            {
                this.method = value;
                onPropertyChanged("Method");
            }
        }

        /// <summary>
        /// Applicable in case of **Check** method only.
        /// </summary>
        [JsonProperty("checkNumber")]
        public string CheckNumber 
        { 
            get 
            {
                return this.checkNumber; 
            } 
            set 
            {
                this.checkNumber = value;
                onPropertyChanged("CheckNumber");
            }
        }

        /// <summary>
        /// Date string in ISO 8601 format. If not specified, current date will be used.
        /// </summary>
        [JsonProperty("createdDate")]
        public string CreatedDate 
        { 
            get 
            {
                return this.createdDate; 
            } 
            set 
            {
                this.createdDate = value;
                onPropertyChanged("CreatedDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public double Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("note")]
        public string Note 
        { 
            get 
            {
                return this.note; 
            } 
            set 
            {
                this.note = value;
                onPropertyChanged("Note");
            }
        }

      

        /// <summary>
        /// Assign the payment to invoices. If the amount is greater than the invoices total, the overpayment will be added to the credit automatically.
        /// See [Retrieve Invoices](#reference/invoices/invoices/get)
        /// </summary>
        [JsonProperty("invoiceIds")]
        public List<int> InvoiceIds 
        { 
            get 
            {
                return this.invoiceIds; 
            } 
            set 
            {
                this.invoiceIds = value;
                onPropertyChanged("InvoiceIds");
            }
        }

        /// <summary>
        /// Required in case of **Custom** method.
        /// </summary>
        [JsonProperty("providerName")]
        public string ProviderName 
        { 
            get 
            {
                return this.providerName; 
            } 
            set 
            {
                this.providerName = value;
                onPropertyChanged("ProviderName");
            }
        }

        /// <summary>
        /// Required in case of **Custom** method.
        /// </summary>
        [JsonProperty("providerPaymentId")]
        public string ProviderPaymentId 
        { 
            get 
            {
                return this.providerPaymentId; 
            } 
            set 
            {
                this.providerPaymentId = value;
                onPropertyChanged("ProviderPaymentId");
            }
        }

        /// <summary>
        /// Date string in ISO 8601 format. If not specified, current date will be used. Required in case of **Custom** method.
        /// </summary>
        [JsonProperty("providerPaymentTime")]
        public string ProviderPaymentTime 
        { 
            get 
            {
                return this.providerPaymentTime; 
            } 
            set 
            {
                this.providerPaymentTime = value;
                onPropertyChanged("ProviderPaymentTime");
            }
        }

        /// <summary>
        /// Automatically applies payment to client's unpaid invoices. If true, invoiceId and invoiceIds fields must be empty or not set.
        /// </summary>
        [JsonProperty("applyToInvoicesAutomatically")]
        public bool? ApplyToInvoicesAutomatically 
        { 
            get 
            {
                return this.applyToInvoicesAutomatically; 
            } 
            set 
            {
                this.applyToInvoicesAutomatically = value;
                onPropertyChanged("ApplyToInvoicesAutomatically");
            }
        }

        /// <summary>
        /// Id of User who created payment.
        /// </summary>
        [JsonProperty("userId")]
        public double? UserId 
        { 
            get 
            {
                return this.userId; 
            } 
            set 
            {
                this.userId = value;
                onPropertyChanged("UserId");
            }
        }
       
    }
}
