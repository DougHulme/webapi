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
    public class Organization : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string registrationNumber;
        private string taxId;
        private string phone;
        private string email;
        private string website;
        private string street1;
        private string street2;
        private string city;
        private double countryId;
        private double? stateId;
        private double currencyId;
        private string zipCode;
        private bool? selected;

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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("registrationNumber")]
        public string RegistrationNumber 
        { 
            get 
            {
                return this.registrationNumber; 
            } 
            set 
            {
                this.registrationNumber = value;
                onPropertyChanged("RegistrationNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("taxId")]
        public string TaxId 
        { 
            get 
            {
                return this.taxId; 
            } 
            set 
            {
                this.taxId = value;
                onPropertyChanged("TaxId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("phone")]
        public string Phone 
        { 
            get 
            {
                return this.phone; 
            } 
            set 
            {
                this.phone = value;
                onPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// Used as the "From attribute" for all the messages sent to clients under this organization
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("website")]
        public string Website 
        { 
            get 
            {
                return this.website; 
            } 
            set 
            {
                this.website = value;
                onPropertyChanged("Website");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("street1")]
        public string Street1 
        { 
            get 
            {
                return this.street1; 
            } 
            set 
            {
                this.street1 = value;
                onPropertyChanged("Street1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("street2")]
        public string Street2 
        { 
            get 
            {
                return this.street2; 
            } 
            set 
            {
                this.street2 = value;
                onPropertyChanged("Street2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("city")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// See [Retrieve Countries](#reference/general/countries/get)
        /// </summary>
        [JsonProperty("countryId")]
        public double CountryId 
        { 
            get 
            {
                return this.countryId; 
            } 
            set 
            {
                this.countryId = value;
                onPropertyChanged("CountryId");
            }
        }

        /// <summary>
        /// Applicable in case of **United States** and **Canada** only. If not specified, taken from default organization
        /// See [Retrieve States](#reference/general/countriesidstates/get)
        /// </summary>
        [JsonProperty("stateId")]
        public double? StateId 
        { 
            get 
            {
                return this.stateId; 
            } 
            set 
            {
                this.stateId = value;
                onPropertyChanged("StateId");
            }
        }

        /// <summary>
        /// See [Retrieve Currencies](#reference/general/currencies/get)
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
        [JsonProperty("zipCode")]
        public string ZipCode 
        { 
            get 
            {
                return this.zipCode; 
            } 
            set 
            {
                this.zipCode = value;
                onPropertyChanged("ZipCode");
            }
        }

        /// <summary>
        /// Is preselected while adding new client
        /// </summary>
        [JsonProperty("selected")]
        public bool? Selected 
        { 
            get 
            {
                return this.selected; 
            } 
            set 
            {
                this.selected = value;
                onPropertyChanged("Selected");
            }
        }
    }
} 