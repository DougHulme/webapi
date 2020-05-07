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
    public class PaymentPlan : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string provider = "ippay";
        private string providerPlanId;
        private string providerSubscriptionId;
        private double clientId;
        private double currencyId;
        private double amount;
        private Models.PeriodEnum period;
        private string startDate;

        /// <summary>
        /// For now only subscriptions for IPPay can be added with API.
        /// </summary>
        [JsonProperty("provider")]
        public string Provider 
        { 
            get 
            {
                return this.provider; 
            } 
            set 
            {
                this.provider = value;
                onPropertyChanged("Provider");
            }
        }

        /// <summary>
        /// PaymentPlan ID, specific for every provider.
        /// </summary>
        [JsonProperty("providerPlanId")]
        public string ProviderPlanId 
        { 
            get 
            {
                return this.providerPlanId; 
            } 
            set 
            {
                this.providerPlanId = value;
                onPropertyChanged("ProviderPlanId");
            }
        }

        /// <summary>
        /// Subscription ID, specific for every provider. For IPPay it's the token used to authorize the payments.
        /// </summary>
        [JsonProperty("providerSubscriptionId")]
        public string ProviderSubscriptionId 
        { 
            get 
            {
                return this.providerSubscriptionId; 
            } 
            set 
            {
                this.providerSubscriptionId = value;
                onPropertyChanged("ProviderSubscriptionId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientId")]
        public double ClientId 
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
        [JsonProperty("currencyId")]
        public double CurrencyId 
        { 
            get 
            {
                return this.currencyId; 
            } 
            set 
            {
                this.currencyId = value;
                onPropertyChanged("CurrencyId");
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
        /// Period in months.
        /// </summary>
        [JsonProperty("period")]
        public Models.PeriodEnum Period 
        { 
            get 
            {
                return this.period; 
            } 
            set 
            {
                this.period = value;
                onPropertyChanged("Period");
            }
        }

        /// <summary>
        /// Date string in ISO 8601 format.
        /// </summary>
        [JsonProperty("startDate")]
        public string StartDate 
        { 
            get 
            {
                return this.startDate; 
            } 
            set 
            {
                this.startDate = value;
                onPropertyChanged("StartDate");
            }
        }
    }
} 