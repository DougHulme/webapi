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
    public class ClientWritable : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.ClientContactWritable> contacts;
        private List<Models.ClientAttribute> attributes;
        private string password;
        private string userIdent;
        private string previousIsp;
        private bool? isLead;
        private Models.ClientTypeEnum? clientType = Models.ClientTypeEnum.ENUM_1;
        private string companyName;
        private string companyRegistrationNumber;
        private string companyTaxId;
        private string companyWebsite;
        private string companyContactFirstName;
        private string companyContactLastName;
        private string firstName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private double? countryId;
        private double? stateId;
        private string zipCode;
        private string invoiceStreet1;
        private string invoiceStreet2;
        private string invoiceCity;
        private double? invoiceStateId;
        private double? invoiceCountryId;
        private string invoiceZipCode;
        private bool? invoiceAddressSameAsContact;
        private string note;
        private bool? sendInvoiceByPost;
        private double? invoiceMaturityDays;
        private bool? stopServiceDue;
        private double? stopServiceDueDays;
        private int? organizationId;
        private double? tax1Id;
        private double? tax2Id;
        private double? tax3Id;
        private string registrationDate;
        private string username;
        private string avatarColor;
        private double? addressGpsLat;
        private double? addressGpsLon;
        private bool? generateProformaInvoices;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("contacts")]
        public List<Models.ClientContactWritable> Contacts 
        { 
            get 
            {
                return this.contacts; 
            } 
            set 
            {
                this.contacts = value;
                onPropertyChanged("Contacts");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attributes")]
        public List<Models.ClientAttribute> Attributes 
        { 
            get 
            {
                return this.attributes; 
            } 
            set 
            {
                this.attributes = value;
                onPropertyChanged("Attributes");
            }
        }

        /// <summary>
        /// if filled, client's password will be changed
        /// </summary>
        [JsonProperty("password")]
        public string Password 
        { 
            get 
            {
                return this.password; 
            } 
            set 
            {
                this.password = value;
                onPropertyChanged("Password");
            }
        }

        /// <summary>
        /// "Custom ID" in UCRM, not to be confused with entity "ID" used in URL
        /// </summary>
        [JsonProperty("userIdent")]
        public string UserIdent 
        { 
            get 
            {
                return this.userIdent; 
            } 
            set 
            {
                this.userIdent = value;
                onPropertyChanged("UserIdent");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("previousIsp")]
        public string PreviousIsp 
        { 
            get 
            {
                return this.previousIsp; 
            } 
            set 
            {
                this.previousIsp = value;
                onPropertyChanged("PreviousIsp");
            }
        }

        /// <summary>
        /// if true, this is a lead, otherwise active client
        /// </summary>
        [JsonProperty("isLead")]
        public bool? IsLead 
        { 
            get 
            {
                return this.isLead; 
            } 
            set 
            {
                this.isLead = value;
                onPropertyChanged("IsLead");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientType")]
        public Models.ClientTypeEnum? ClientType 
        { 
            get 
            {
                return this.clientType; 
            } 
            set 
            {
                this.clientType = value;
                onPropertyChanged("ClientType");
            }
        }

        /// <summary>
        /// Required in case of type **Company**
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName 
        { 
            get 
            {
                return this.companyName; 
            } 
            set 
            {
                this.companyName = value;
                onPropertyChanged("CompanyName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyRegistrationNumber")]
        public string CompanyRegistrationNumber 
        { 
            get 
            {
                return this.companyRegistrationNumber; 
            } 
            set 
            {
                this.companyRegistrationNumber = value;
                onPropertyChanged("CompanyRegistrationNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyTaxId")]
        public string CompanyTaxId 
        { 
            get 
            {
                return this.companyTaxId; 
            } 
            set 
            {
                this.companyTaxId = value;
                onPropertyChanged("CompanyTaxId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyWebsite")]
        public string CompanyWebsite 
        { 
            get 
            {
                return this.companyWebsite; 
            } 
            set 
            {
                this.companyWebsite = value;
                onPropertyChanged("CompanyWebsite");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyContactFirstName")]
        public string CompanyContactFirstName 
        { 
            get 
            {
                return this.companyContactFirstName; 
            } 
            set 
            {
                this.companyContactFirstName = value;
                onPropertyChanged("CompanyContactFirstName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("companyContactLastName")]
        public string CompanyContactLastName 
        { 
            get 
            {
                return this.companyContactLastName; 
            } 
            set 
            {
                this.companyContactLastName = value;
                onPropertyChanged("CompanyContactLastName");
            }
        }

        /// <summary>
        /// Required in case of type **Residential**
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName 
        { 
            get 
            {
                return this.firstName; 
            } 
            set 
            {
                this.firstName = value;
                onPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Required in case of type **Residential**
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName 
        { 
            get 
            {
                return this.lastName; 
            } 
            set 
            {
                this.lastName = value;
                onPropertyChanged("LastName");
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
        /// If not specified, taken from default organization
        /// See [Retrieve Countries](#reference/general/countries/get)
        /// </summary>
        [JsonProperty("countryId")]
        public double? CountryId 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoiceStreet1")]
        public string InvoiceStreet1 
        { 
            get 
            {
                return this.invoiceStreet1; 
            } 
            set 
            {
                this.invoiceStreet1 = value;
                onPropertyChanged("InvoiceStreet1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoiceStreet2")]
        public string InvoiceStreet2 
        { 
            get 
            {
                return this.invoiceStreet2; 
            } 
            set 
            {
                this.invoiceStreet2 = value;
                onPropertyChanged("InvoiceStreet2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoiceCity")]
        public string InvoiceCity 
        { 
            get 
            {
                return this.invoiceCity; 
            } 
            set 
            {
                this.invoiceCity = value;
                onPropertyChanged("InvoiceCity");
            }
        }

        /// <summary>
        /// Applicable in case of **United States** and **Canada** only
        /// See [Retrieve States](#reference/general/countriesidstates/get)
        /// </summary>
        [JsonProperty("invoiceStateId")]
        public double? InvoiceStateId 
        { 
            get 
            {
                return this.invoiceStateId; 
            } 
            set 
            {
                this.invoiceStateId = value;
                onPropertyChanged("InvoiceStateId");
            }
        }

        /// <summary>
        /// See [Retrieve Countries](#reference/general/countries/get)
        /// </summary>
        [JsonProperty("invoiceCountryId")]
        public double? InvoiceCountryId 
        { 
            get 
            {
                return this.invoiceCountryId; 
            } 
            set 
            {
                this.invoiceCountryId = value;
                onPropertyChanged("InvoiceCountryId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoiceZipCode")]
        public string InvoiceZipCode 
        { 
            get 
            {
                return this.invoiceZipCode; 
            } 
            set 
            {
                this.invoiceZipCode = value;
                onPropertyChanged("InvoiceZipCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoiceAddressSameAsContact")]
        public bool? InvoiceAddressSameAsContact 
        { 
            get 
            {
                return this.invoiceAddressSameAsContact; 
            } 
            set 
            {
                this.invoiceAddressSameAsContact = value;
                onPropertyChanged("InvoiceAddressSameAsContact");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("note")]
        public string Note 
        { 
            get 
            {
                return this.note; 
            } 
            set 
            {
                this.note = value;
                onPropertyChanged("Note");
            }
        }

        /// <summary>
        /// If `null`, system default is used
        /// Mark client's invoices as to be sent by post
        /// </summary>
        [JsonProperty("sendInvoiceByPost")]
        public bool? SendInvoiceByPost 
        { 
            get 
            {
                return this.sendInvoiceByPost; 
            } 
            set 
            {
                this.sendInvoiceByPost = value;
                onPropertyChanged("SendInvoiceByPost");
            }
        }

        /// <summary>
        /// If `null`, system default is used
        /// </summary>
        [JsonProperty("invoiceMaturityDays")]
        public double? InvoiceMaturityDays 
        { 
            get 
            {
                return this.invoiceMaturityDays; 
            } 
            set 
            {
                this.invoiceMaturityDays = value;
                onPropertyChanged("InvoiceMaturityDays");
            }
        }

        /// <summary>
        /// If `null`, system default is used
        /// Suspend client's service in case of overdue invoice
        /// </summary>
        [JsonProperty("stopServiceDue")]
        public bool? StopServiceDue 
        { 
            get 
            {
                return this.stopServiceDue; 
            } 
            set 
            {
                this.stopServiceDue = value;
                onPropertyChanged("StopServiceDue");
            }
        }

        /// <summary>
        /// If `null`, system default is used
        /// Number of days for which suspend is deferred
        /// For example, if 3 days are set and invoice due date is 17th March suspend will start from 20th March
        /// </summary>
        [JsonProperty("stopServiceDueDays")]
        public double? StopServiceDueDays 
        { 
            get 
            {
                return this.stopServiceDueDays; 
            } 
            set 
            {
                this.stopServiceDueDays = value;
                onPropertyChanged("StopServiceDueDays");
            }
        }

        /// <summary>
        /// If not specified, default organization will be used
        /// See [Retrieve Organizations](#reference/organizations/organizations/get)
        /// </summary>
        [JsonProperty("organizationId")]
        public int? OrganizationId 
        { 
            get 
            {
                return this.organizationId; 
            } 
            set 
            {
                this.organizationId = value;
                onPropertyChanged("OrganizationId");
            }
        }

        /// <summary>
        /// Will be added by default to each client's taxable services and products
        /// See [Retrieve Taxes](#reference/taxes/taxes/get)
        /// </summary>
        [JsonProperty("tax1Id")]
        public double? Tax1Id 
        { 
            get 
            {
                return this.tax1Id; 
            } 
            set 
            {
                this.tax1Id = value;
                onPropertyChanged("Tax1Id");
            }
        }

        /// <summary>
        /// Will be added by default to each client's taxable services and products
        /// See [Retrieve Taxes](#reference/taxes/taxes/get)
        /// </summary>
        [JsonProperty("tax2Id")]
        public double? Tax2Id 
        { 
            get 
            {
                return this.tax2Id; 
            } 
            set 
            {
                this.tax2Id = value;
                onPropertyChanged("Tax2Id");
            }
        }

        /// <summary>
        /// Will be added by default to each client's taxable services and products
        /// See [Retrieve Taxes](#reference/taxes/taxes/get)
        /// </summary>
        [JsonProperty("tax3Id")]
        public double? Tax3Id 
        { 
            get 
            {
                return this.tax3Id; 
            } 
            set 
            {
                this.tax3Id = value;
                onPropertyChanged("Tax3Id");
            }
        }

        /// <summary>
        /// Date string in ISO 8601 format. If not specified, current date will be used
        /// </summary>
        [JsonProperty("registrationDate")]
        public string RegistrationDate 
        { 
            get 
            {
                return this.registrationDate; 
            } 
            set 
            {
                this.registrationDate = value;
                onPropertyChanged("RegistrationDate");
            }
        }

        /// <summary>
        /// If null, client zone is disabled
        /// </summary>
        [JsonProperty("username")]
        public string Username 
        { 
            get 
            {
                return this.username; 
            } 
            set 
            {
                this.username = value;
                onPropertyChanged("Username");
            }
        }

        /// <summary>
        /// Color in hexadecimal format. If not specified, will be assigned randomly.
        /// </summary>
        [JsonProperty("avatarColor")]
        public string AvatarColor 
        { 
            get 
            {
                return this.avatarColor; 
            } 
            set 
            {
                this.avatarColor = value;
                onPropertyChanged("AvatarColor");
            }
        }

        /// <summary>
        /// Latitude of address location
        /// </summary>
        [JsonProperty("addressGpsLat")]
        public double? AddressGpsLat 
        { 
            get 
            {
                return this.addressGpsLat; 
            } 
            set 
            {
                this.addressGpsLat = value;
                onPropertyChanged("AddressGpsLat");
            }
        }

        /// <summary>
        /// Longitude of address location
        /// </summary>
        [JsonProperty("addressGpsLon")]
        public double? AddressGpsLon 
        { 
            get 
            {
                return this.addressGpsLon; 
            } 
            set 
            {
                this.addressGpsLon = value;
                onPropertyChanged("AddressGpsLon");
            }
        }

        /// <summary>
        /// If `null`, system default is used.
        /// If `true` proforma invoice will be generated.
        /// </summary>
        [JsonProperty("generateProformaInvoices")]
        public bool? GenerateProformaInvoices 
        { 
            get 
            {
                return this.generateProformaInvoices; 
            } 
            set 
            {
                this.generateProformaInvoices = value;
                onPropertyChanged("GenerateProformaInvoices");
            }
        }
    }
} 