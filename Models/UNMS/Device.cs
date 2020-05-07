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
    public class Device : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private double siteId;
        private double vendorId;
        private string modelName;
        private List<double> parentIds;
        private string notes;
        private string loginUsername;
        private string loginPassword;
        private double? sshPort;
        private string snmpCommunity;
        private string osVersion;
        private bool? isGateway;
        private bool? isSuspendEnabled;
        private bool? sendPingNotifications;
        private double? pingNotificationUserId;
        private bool? createSignalStatistics;

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
        /// See [Retrieve Sites](#reference/sites/sites/get)
        /// </summary>
        [JsonProperty("siteId")]
        public double SiteId 
        { 
            get 
            {
                return this.siteId; 
            } 
            set 
            {
                this.siteId = value;
                onPropertyChanged("SiteId");
            }
        }

        /// <summary>
        /// See [Retrieve Vendors](#reference/vendors/vendors/get)
        /// </summary>
        [JsonProperty("vendorId")]
        public double VendorId 
        { 
            get 
            {
                return this.vendorId; 
            } 
            set 
            {
                this.vendorId = value;
                onPropertyChanged("VendorId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("modelName")]
        public string ModelName 
        { 
            get 
            {
                return this.modelName; 
            } 
            set 
            {
                this.modelName = value;
                onPropertyChanged("ModelName");
            }
        }

        /// <summary>
        /// Parent devices within your network topology which is used for monitoring of outages
        /// </summary>
        [JsonProperty("parentIds")]
        public List<double> ParentIds 
        { 
            get 
            {
                return this.parentIds; 
            } 
            set 
            {
                this.parentIds = value;
                onPropertyChanged("ParentIds");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("notes")]
        public string Notes 
        { 
            get 
            {
                return this.notes; 
            } 
            set 
            {
                this.notes = value;
                onPropertyChanged("Notes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("loginUsername")]
        public string LoginUsername 
        { 
            get 
            {
                return this.loginUsername; 
            } 
            set 
            {
                this.loginUsername = value;
                onPropertyChanged("LoginUsername");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("loginPassword")]
        public string LoginPassword 
        { 
            get 
            {
                return this.loginPassword; 
            } 
            set 
            {
                this.loginPassword = value;
                onPropertyChanged("LoginPassword");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sshPort")]
        public double? SshPort 
        { 
            get 
            {
                return this.sshPort; 
            } 
            set 
            {
                this.sshPort = value;
                onPropertyChanged("SshPort");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("snmpCommunity")]
        public string SnmpCommunity 
        { 
            get 
            {
                return this.snmpCommunity; 
            } 
            set 
            {
                this.snmpCommunity = value;
                onPropertyChanged("SnmpCommunity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("osVersion")]
        public string OsVersion 
        { 
            get 
            {
                return this.osVersion; 
            } 
            set 
            {
                this.osVersion = value;
                onPropertyChanged("OsVersion");
            }
        }

        /// <summary>
        /// Mark device as the gateway router of your network. This may ease the setup of QoS feature
        /// </summary>
        [JsonProperty("isGateway")]
        public bool? IsGateway 
        { 
            get 
            {
                return this.isGateway; 
            } 
            set 
            {
                this.isGateway = value;
                onPropertyChanged("IsGateway");
            }
        }

        /// <summary>
        /// Synchronize list of blocked users
        /// </summary>
        [JsonProperty("isSuspendEnabled")]
        public bool? IsSuspendEnabled 
        { 
            get 
            {
                return this.isSuspendEnabled; 
            } 
            set 
            {
                this.isSuspendEnabled = value;
                onPropertyChanged("IsSuspendEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sendPingNotifications")]
        public bool? SendPingNotifications 
        { 
            get 
            {
                return this.sendPingNotifications; 
            } 
            set 
            {
                this.sendPingNotifications = value;
                onPropertyChanged("SendPingNotifications");
            }
        }

        /// <summary>
        /// If not specified, default notification user will be used
        /// See [Retrieve Admins](#reference/users/usersadmins/get)
        /// </summary>
        [JsonProperty("pingNotificationUserId")]
        public double? PingNotificationUserId 
        { 
            get 
            {
                return this.pingNotificationUserId; 
            } 
            set 
            {
                this.pingNotificationUserId = value;
                onPropertyChanged("PingNotificationUserId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("createSignalStatistics")]
        public bool? CreateSignalStatistics 
        { 
            get 
            {
                return this.createSignalStatistics; 
            } 
            set 
            {
                this.createSignalStatistics = value;
                onPropertyChanged("CreateSignalStatistics");
            }
        }
    }
} 