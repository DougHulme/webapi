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
    public class TicketActivityJobAssignment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? assignedJobId;
        private Models.Type2Enum? type;

        /// <summary>
        /// See [Retrieve Jobs](#reference/scheduling/jobs/get)
        /// </summary>
        [JsonProperty("assignedJobId")]
        public double? AssignedJobId 
        { 
            get 
            {
                return this.assignedJobId; 
            } 
            set 
            {
                this.assignedJobId = value;
                onPropertyChanged("AssignedJobId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.Type2Enum? Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }
    }
} 