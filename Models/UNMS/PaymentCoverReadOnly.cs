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
    public class PaymentCoverReadOnly : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? id;
        private double paymentId;
        private double? invoiceId;
        private double? refundId;
        private double amount;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public double? Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Source payment of the cover.
        /// </summary>
        [JsonProperty("paymentId")]
        public double PaymentId 
        { 
            get 
            {
                return this.paymentId; 
            } 
            set 
            {
                this.paymentId = value;
                onPropertyChanged("PaymentId");
            }
        }

        /// <summary>
        /// Invoice assigned to this cover (can be `null`, but `refundId` will be filled in that case).
        /// </summary>
        [JsonProperty("invoiceId")]
        public double? InvoiceId 
        { 
            get 
            {
                return this.invoiceId; 
            } 
            set 
            {
                this.invoiceId = value;
                onPropertyChanged("InvoiceId");
            }
        }

        /// <summary>
        /// Refund assigned to this cover (can be `null`, but `invoiceId` will be filled in that case).
        /// </summary>
        [JsonProperty("refundId")]
        public double? RefundId 
        { 
            get 
            {
                return this.refundId; 
            } 
            set 
            {
                this.refundId = value;
                onPropertyChanged("RefundId");
            }
        }

        /// <summary>
        /// Amount this cover takes from source payment.
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
    }
} 