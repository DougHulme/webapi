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
    public class Version : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string version;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("version")]
        public string VersionProp 
        { 
            get 
            {
                return this.version; 
            } 
            set 
            {
                this.version = value;
                onPropertyChanged("VersionProp");
            }
        }
    }
} 