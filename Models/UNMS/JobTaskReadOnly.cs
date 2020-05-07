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
    public class JobTaskReadOnly : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? id;
        private double? jobId;
        private string label;
        private bool? closed;

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
        /// See [Retrieve Jobs](#reference/jobs/schedulingjobs/get)
        /// </summary>
        [JsonProperty("jobId")]
        public double? JobId 
        { 
            get 
            {
                return this.jobId; 
            } 
            set 
            {
                this.jobId = value;
                onPropertyChanged("JobId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("label")]
        public string Label 
        { 
            get 
            {
                return this.label; 
            } 
            set 
            {
                this.label = value;
                onPropertyChanged("Label");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("closed")]
        public bool? Closed 
        { 
            get 
            {
                return this.closed; 
            } 
            set 
            {
                this.closed = value;
                onPropertyChanged("Closed");
            }
        }
    }
} 