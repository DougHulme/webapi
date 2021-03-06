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
    public class TicketCommentReadOnly : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? id;
        private double? ticketId;
        private string body;
        private List<Models.TicketCommentAttachmentReadOnly> attachments;
        private double? userId;
        private bool? mpublic;
        private string createdAt;
        private string emailFromAddress;
        private string emailFromName;

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
        [JsonProperty("body")]
        public string Body 
        { 
            get 
            {
                return this.body; 
            } 
            set 
            {
                this.body = value;
                onPropertyChanged("Body");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attachments")]
        public List<Models.TicketCommentAttachmentReadOnly> Attachments 
        { 
            get 
            {
                return this.attachments; 
            } 
            set 
            {
                this.attachments = value;
                onPropertyChanged("Attachments");
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

        /// <summary>
        /// Can be only set, if `userId` is null (comment is created by client).
        /// </summary>
        [JsonProperty("emailFromAddress")]
        public string EmailFromAddress 
        { 
            get 
            {
                return this.emailFromAddress; 
            } 
            set 
            {
                this.emailFromAddress = value;
                onPropertyChanged("EmailFromAddress");
            }
        }

        /// <summary>
        /// Can be only set, if `userId` is null (comment is created by client).
        /// </summary>
        [JsonProperty("emailFromName")]
        public string EmailFromName 
        { 
            get 
            {
                return this.emailFromName; 
            } 
            set 
            {
                this.emailFromName = value;
                onPropertyChanged("EmailFromName");
            }
        }
    }
} 