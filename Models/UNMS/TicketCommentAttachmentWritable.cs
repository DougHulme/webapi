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
    public class TicketCommentAttachmentWritable : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string file;
        private string filename;

        /// <summary>
        /// File encoded in base64.
        /// </summary>
        [JsonProperty("file")]
        public string File 
        { 
            get 
            {
                return this.file; 
            } 
            set 
            {
                this.file = value;
                onPropertyChanged("File");
            }
        }

        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty("filename")]
        public string Filename 
        { 
            get 
            {
                return this.filename; 
            } 
            set 
            {
                this.filename = value;
                onPropertyChanged("Filename");
            }
        }
    }
} 