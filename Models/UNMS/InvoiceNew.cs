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
    public class InvoiceNew : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string number;
        private List<Models.InvoiceItem> items;
        private List<Models.InvoiceAttribute> attributes;
        private bool? applyCredit;
        private string createdDate;
        private string emailSentDate;
        private int? maturityDays;
        private string notes;
        private string adminNotes;
        private double? invoiceTemplateId;
        private string organizationName;
        private string organizationRegistrationNumber;
        private string organizationTaxId;
        private string organizationStreet1;
        private string organizationStreet2;
        private string organizationCity;
        private double? organizationCountryId;
        private double? organizationStateId;
        private string organizationZipCode;
        private string organizationBankAccountName;
        private string organizationBankAccountField1;
        private string organizationBankAccountField2;
        private string clientFirstName;
        private string clientLastName;
        private string clientCompanyName;
        private string clientCompanyRegistrationNumber;
        private string clientCompanyTaxId;
        private string clientStreet1;
        private string clientStreet2;
        private string clientCity;
        private double? clientCountryId;
        private double? clientStateId;
        private string clientZipCode;

        /// <summary>
        /// If not specified, the next invoice number will be generated automatically
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("items")]
        public List<Models.InvoiceItem> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attributes")]
        public List<Models.InvoiceAttribute> Attributes 
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
        /// Automatically pay the invoice from available credit. True by default.
        /// </summary>
        [JsonProperty("applyCredit")]
        public bool? ApplyCredit 
        { 
            get 
            {
                return this.applyCredit; 
            } 
            set 
            {
                this.applyCredit = value;
                onPropertyChanged("ApplyCredit");
            }
        }

        /// <summary>
        /// Date string in ISO 8601 format. If not specified, current date will be used
        /// </summary>
        [JsonProperty("createdDate")]
        public string CreatedDate 
        { 
            get 
            {
                return this.createdDate; 
            } 
            set 
            {
                this.createdDate = value;
                onPropertyChanged("CreatedDate");
            }
        }

        /// <summary>
        /// Date string in ISO 8601 format or null. Does not actually send the invoice by email when changed.
        /// </summary>
        [JsonProperty("emailSentDate")]
        public string EmailSentDate 
        { 
            get 
            {
                return this.emailSentDate; 
            } 
            set 
            {
                this.emailSentDate = value;
                onPropertyChanged("EmailSentDate");
            }
        }

        /// <summary>
        /// If not specified, will be taken from global settings
        /// </summary>
        [JsonProperty("maturityDays")]
        public int? MaturityDays 
        { 
            get 
            {
                return this.maturityDays; 
            } 
            set 
            {
                this.maturityDays = value;
                onPropertyChanged("MaturityDays");
            }
        }

        /// <summary>
        /// This text will be displayed on the invoice
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
        /// This text will not be displayed on the invoice and is never shown to client
        /// </summary>
        [JsonProperty("adminNotes")]
        public string AdminNotes 
        { 
            get 
            {
                return this.adminNotes; 
            } 
            set 
            {
                this.adminNotes = value;
                onPropertyChanged("AdminNotes");
            }
        }

        /// <summary>
        /// If not specified, invoice template set on Organization is used
        /// See [Retrieve Invoice Templates](#reference/invoice-templates/invoice-templates/get)
        /// </summary>
        [JsonProperty("invoiceTemplateId")]
        public double? InvoiceTemplateId 
        { 
            get 
            {
                return this.invoiceTemplateId; 
            } 
            set 
            {
                this.invoiceTemplateId = value;
                onPropertyChanged("InvoiceTemplateId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationName")]
        public string OrganizationName 
        { 
            get 
            {
                return this.organizationName; 
            } 
            set 
            {
                this.organizationName = value;
                onPropertyChanged("OrganizationName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationRegistrationNumber")]
        public string OrganizationRegistrationNumber 
        { 
            get 
            {
                return this.organizationRegistrationNumber; 
            } 
            set 
            {
                this.organizationRegistrationNumber = value;
                onPropertyChanged("OrganizationRegistrationNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationTaxId")]
        public string OrganizationTaxId 
        { 
            get 
            {
                return this.organizationTaxId; 
            } 
            set 
            {
                this.organizationTaxId = value;
                onPropertyChanged("OrganizationTaxId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationStreet1")]
        public string OrganizationStreet1 
        { 
            get 
            {
                return this.organizationStreet1; 
            } 
            set 
            {
                this.organizationStreet1 = value;
                onPropertyChanged("OrganizationStreet1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationStreet2")]
        public string OrganizationStreet2 
        { 
            get 
            {
                return this.organizationStreet2; 
            } 
            set 
            {
                this.organizationStreet2 = value;
                onPropertyChanged("OrganizationStreet2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationCity")]
        public string OrganizationCity 
        { 
            get 
            {
                return this.organizationCity; 
            } 
            set 
            {
                this.organizationCity = value;
                onPropertyChanged("OrganizationCity");
            }
        }

        /// <summary>
        /// See [Retrieve Countries](#reference/general/countries/get)
        /// </summary>
        [JsonProperty("organizationCountryId")]
        public double? OrganizationCountryId 
        { 
            get 
            {
                return this.organizationCountryId; 
            } 
            set 
            {
                this.organizationCountryId = value;
                onPropertyChanged("OrganizationCountryId");
            }
        }

        /// <summary>
        /// See [Retrieve States](#reference/general/countriesidstates/get)
        /// </summary>
        [JsonProperty("organizationStateId")]
        public double? OrganizationStateId 
        { 
            get 
            {
                return this.organizationStateId; 
            } 
            set 
            {
                this.organizationStateId = value;
                onPropertyChanged("OrganizationStateId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationZipCode")]
        public string OrganizationZipCode 
        { 
            get 
            {
                return this.organizationZipCode; 
            } 
            set 
            {
                this.organizationZipCode = value;
                onPropertyChanged("OrganizationZipCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationBankAccountName")]
        public string OrganizationBankAccountName 
        { 
            get 
            {
                return this.organizationBankAccountName; 
            } 
            set 
            {
                this.organizationBankAccountName = value;
                onPropertyChanged("OrganizationBankAccountName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationBankAccountField1")]
        public string OrganizationBankAccountField1 
        { 
            get 
            {
                return this.organizationBankAccountField1; 
            } 
            set 
            {
                this.organizationBankAccountField1 = value;
                onPropertyChanged("OrganizationBankAccountField1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("organizationBankAccountField2")]
        public string OrganizationBankAccountField2 
        { 
            get 
            {
                return this.organizationBankAccountField2; 
            } 
            set 
            {
                this.organizationBankAccountField2 = value;
                onPropertyChanged("OrganizationBankAccountField2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientFirstName")]
        public string ClientFirstName 
        { 
            get 
            {
                return this.clientFirstName; 
            } 
            set 
            {
                this.clientFirstName = value;
                onPropertyChanged("ClientFirstName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientLastName")]
        public string ClientLastName 
        { 
            get 
            {
                return this.clientLastName; 
            } 
            set 
            {
                this.clientLastName = value;
                onPropertyChanged("ClientLastName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientCompanyName")]
        public string ClientCompanyName 
        { 
            get 
            {
                return this.clientCompanyName; 
            } 
            set 
            {
                this.clientCompanyName = value;
                onPropertyChanged("ClientCompanyName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientCompanyRegistrationNumber")]
        public string ClientCompanyRegistrationNumber 
        { 
            get 
            {
                return this.clientCompanyRegistrationNumber; 
            } 
            set 
            {
                this.clientCompanyRegistrationNumber = value;
                onPropertyChanged("ClientCompanyRegistrationNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientCompanyTaxId")]
        public string ClientCompanyTaxId 
        { 
            get 
            {
                return this.clientCompanyTaxId; 
            } 
            set 
            {
                this.clientCompanyTaxId = value;
                onPropertyChanged("ClientCompanyTaxId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientStreet1")]
        public string ClientStreet1 
        { 
            get 
            {
                return this.clientStreet1; 
            } 
            set 
            {
                this.clientStreet1 = value;
                onPropertyChanged("ClientStreet1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientStreet2")]
        public string ClientStreet2 
        { 
            get 
            {
                return this.clientStreet2; 
            } 
            set 
            {
                this.clientStreet2 = value;
                onPropertyChanged("ClientStreet2");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientCity")]
        public string ClientCity 
        { 
            get 
            {
                return this.clientCity; 
            } 
            set 
            {
                this.clientCity = value;
                onPropertyChanged("ClientCity");
            }
        }

        /// <summary>
        /// See [Retrieve Countries](#reference/general/countries/get)
        /// </summary>
        [JsonProperty("clientCountryId")]
        public double? ClientCountryId 
        { 
            get 
            {
                return this.clientCountryId; 
            } 
            set 
            {
                this.clientCountryId = value;
                onPropertyChanged("ClientCountryId");
            }
        }

        /// <summary>
        /// See [Retrieve States](#reference/general/countriesidstates/get)
        /// </summary>
        [JsonProperty("clientStateId")]
        public double? ClientStateId 
        { 
            get 
            {
                return this.clientStateId; 
            } 
            set 
            {
                this.clientStateId = value;
                onPropertyChanged("ClientStateId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("clientZipCode")]
        public string ClientZipCode 
        { 
            get 
            {
                return this.clientZipCode; 
            } 
            set 
            {
                this.clientZipCode = value;
                onPropertyChanged("ClientZipCode");
            }
        }
    }
} 