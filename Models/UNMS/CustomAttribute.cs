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
    public class CustomAttribute : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private Models.AttributeTypeEnum? attributeType;

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
        [JsonProperty("attributeType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.AttributeTypeEnum? AttributeType 
        { 
            get 
            {
                return this.attributeType; 
            } 
            set 
            {
                this.attributeType = value;
                onPropertyChanged("AttributeType");
            }
        }
    }
} 