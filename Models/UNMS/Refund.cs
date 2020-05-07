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
    public class Refund : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.RefundMethod1Enum method;
        private string createdDate;
        private double amount;
        private string note;
        private double? clientId;
        private string currencyCode;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("method")]
        public Models.RefundMethod1Enum Method 
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
        /// Date string in ISO 8601 format.
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientId")]
        public double? ClientId 
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
    }
} 