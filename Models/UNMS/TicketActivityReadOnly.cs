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
    public class TicketActivityReadOnly : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool? mpublic;
        private double? id;
        private double? ticketId;
        private Models.TicketActivityCommentReadOnly comment;
        private Models.TicketActivityUserAssignment assignment;
        private Models.TicketActivityClientAssignment clientAssignment;
        private Models.TicketActivityStatusChange statusChange;
        private Models.TicketActivityJobAssignment jobAssignment;
        private Models.Type3Enum? type;
        private double? userId;
        private string createdAt;

        /// <summary>
        /// Is visible to client?
        /// </summary>
        [JsonProperty("public")]
        public bool? Public 
        { 
            get 
            {
                return this.mpublic; 
            } 
            set 
            {
                this.mpublic = value;
                onPropertyChanged("Public");
            }
        }

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
        /// See [Retrieve Ticket](#reference/tickets/ticket/get)
        /// </summary>
        [JsonProperty("ticketId")]
        public double? TicketId 
        { 
            get 
            {
                return this.ticketId; 
            } 
            set 
            {
                this.ticketId = value;
                onPropertyChanged("TicketId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("comment")]
        public Models.TicketActivityCommentReadOnly Comment 
        { 
            get 
            {
                return this.comment; 
            } 
            set 
            {
                this.comment = value;
                onPropertyChanged("Comment");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("assignment")]
        public Models.TicketActivityUserAssignment Assignment 
        { 
            get 
            {
                return this.assignment; 
            } 
            set 
            {
                this.assignment = value;
                onPropertyChanged("Assignment");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientAssignment")]
        public Models.TicketActivityClientAssignment ClientAssignment 
        { 
            get 
            {
                return this.clientAssignment; 
            } 
            set 
            {
                this.clientAssignment = value;
                onPropertyChanged("ClientAssignment");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusChange")]
        public Models.TicketActivityStatusChange StatusChange 
        { 
            get 
            {
                return this.statusChange; 
            } 
            set 
            {
                this.statusChange = value;
                onPropertyChanged("StatusChange");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("jobAssignment")]
        public Models.TicketActivityJobAssignment JobAssignment 
        { 
            get 
            {
                return this.jobAssignment; 
            } 
            set 
            {
                this.jobAssignment = value;
                onPropertyChanged("JobAssignment");
            }
        }

        /// <summary>
        /// Type of activity
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.Type3Enum? Type 
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

        /// <summary>
        /// ID of User or null if activity is created by client.
        /// See [Retrieve Users](#reference/users/users/get)
        /// </summary>
        [JsonProperty("userId")]
        public double? UserId 
        { 
            get 
            {
                return this.userId; 
            } 
            set 
            {
                this.userId = value;
                onPropertyChanged("UserId");
            }
        }

        /// <summary>
        /// Date string in ISO 8601 format. If not specified, current date will be used
        /// </summary>
        [JsonProperty("createdAt")]
        public string CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }
    }
} 