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
    public class Product : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string invoiceLabel;
        private double price;
        private string unit;
        private bool? taxable;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// If not specified, name will be used
        /// </summary>
        [JsonProperty("invoiceLabel")]
        public string InvoiceLabel 
        { 
            get 
            {
                return this.invoiceLabel; 
            } 
            set 
            {
                this.invoiceLabel = value;
                onPropertyChanged("InvoiceLabel");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("price")]
        public double Price 
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
        [JsonProperty("unit")]
        public string Unit 
        { 
            get 
            {
                return this.unit; 
            } 
            set 
            {
                this.unit = value;
                onPropertyChanged("Unit");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxable")]
        public bool? Taxable 
        { 
            get 
            {
                return this.taxable; 
            } 
            set 
            {
                this.taxable = value;
                onPropertyChanged("Taxable");
            }
        }
    }
} 