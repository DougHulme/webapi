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
    public class TariffPeriodReadOnly : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? id;
        private Models.Period2Enum? period;
        private double? price;
        private bool? enabled;

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
        /// Service plan period in months
        /// </summary>
        [JsonProperty("period")]
        public Models.Period2Enum? Period 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("price")]
        public double? Price 
        { 
            get 
            {
                return this.price; 
            } 
            set 
            {
                this.price = value;
                onPropertyChanged("Price");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled 
        { 
            get 
            {
                return this.enabled; 
            } 
            set 
            {
                this.enabled = value;
                onPropertyChanged("Enabled");
            }
        }
    }
} 