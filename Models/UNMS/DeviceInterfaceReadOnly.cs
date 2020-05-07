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
    public class DeviceInterfaceReadOnly : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? id;
        private double? deviceId;
        private List<string> ipRanges;
        private string name;
        private Models.Type1Enum? type;
        private string macAddress;
        private bool? allowClientConnection;
        private bool? enabled;
        private string notes;
        private string ssid;
        private double? frequency;
        private Models.PolarizationEnum? polarization;
        private Models.EncryptionTypeEnum? encryptionType;
        private string encryptionKeyWpa;
        private string encryptionKeyWpa2;

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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("deviceId")]
        public double? DeviceId 
        { 
            get 
            {
                return this.deviceId; 
            } 
            set 
            {
                this.deviceId = value;
                onPropertyChanged("DeviceId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ipRanges")]
        public List<string> IpRanges 
        { 
            get 
            {
                return this.ipRanges; 
            } 
            set 
            {
                this.ipRanges = value;
                onPropertyChanged("IpRanges");
            }
        }

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
        [JsonProperty("type")]
        public Models.Type1Enum? Type 
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
        /// Supported MAC formats are 00:AA:BB:00:11:22, 00‑AA‑BB‑00‑11‑22, 00AABB001122
        /// </summary>
        [JsonProperty("macAddress")]
        public string MacAddress 
        { 
            get 
            {
                return this.macAddress; 
            } 
            set 
            {
                this.macAddress = value;
                onPropertyChanged("MacAddress");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("allowClientConnection")]
        public bool? AllowClientConnection 
        { 
            get 
            {
                return this.allowClientConnection; 
            } 
            set 
            {
                this.allowClientConnection = value;
                onPropertyChanged("AllowClientConnection");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled 
        { 
            get 
            {
                return this.enabled; 
            } 
            set 
            {
                this.enabled = value;
                onPropertyChanged("Enabled");
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
        /// Applicable in case of type **Wireless** only
        /// </summary>
        [JsonProperty("ssid")]
        public string Ssid 
        { 
            get 
            {
                return this.ssid; 
            } 
            set 
            {
                this.ssid = value;
                onPropertyChanged("Ssid");
            }
        }

        /// <summary>
        /// Applicable in case of type **Wireless** only
        /// </summary>
        [JsonProperty("frequency")]
        public double? Frequency 
        { 
            get 
            {
                return this.frequency; 
            } 
            set 
            {
                this.frequency = value;
                onPropertyChanged("Frequency");
            }
        }

        /// <summary>
        /// Required in case of type **Wireless**
        /// </summary>
        [JsonProperty("polarization")]
        public Models.PolarizationEnum? Polarization 
        { 
            get 
            {
                return this.polarization; 
            } 
            set 
            {
                this.polarization = value;
                onPropertyChanged("Polarization");
            }
        }

        /// <summary>
        /// Required in case of type **Wireless**
        /// </summary>
        [JsonProperty("encryptionType")]
        public Models.EncryptionTypeEnum? EncryptionType 
        { 
            get 
            {
                return this.encryptionType; 
            } 
            set 
            {
                this.encryptionType = value;
                onPropertyChanged("EncryptionType");
            }
        }

        /// <summary>
        /// Applicable in case of type **Wireless** only
        /// </summary>
        [JsonProperty("encryptionKeyWpa")]
        public string EncryptionKeyWpa 
        { 
            get 
            {
                return this.encryptionKeyWpa; 
            } 
            set 
            {
                this.encryptionKeyWpa = value;
                onPropertyChanged("EncryptionKeyWpa");
            }
        }

        /// <summary>
        /// Applicable in case of type **Wireless** only
        /// </summary>
        [JsonProperty("encryptionKeyWpa2")]
        public string EncryptionKeyWpa2 
        { 
            get 
            {
                return this.encryptionKeyWpa2; 
            } 
            set 
            {
                this.encryptionKeyWpa2 = value;
                onPropertyChanged("EncryptionKeyWpa2");
            }
        }
    }
} 