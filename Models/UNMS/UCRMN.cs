using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class InvoiceUpd
    {
        public int maturityDays;

    }
    public class InvoiceN
    {
        // These fields hold the values for the public properties.
        public string number { get; set; }
        public List<Models.InvoiceItemN> items { get; set; }
        public List<Models.InvoiceAttributeN> attributes { get; set; }
        public string createdDate { get; set; }
        public string emailSentDate { get; set; }
        public int? maturityDays { get; set; }
        public string organizationName { get; set; }
        public string organizationRegistrationNumber { get; set; }
        public string organizationTaxId { get; set; }
        public string organizationStreet1 { get; set; }
        public string organizationStreet2 { get; set; }
        public string organizationCity { get; set; }
        public double? organizationCountryId { get; set; }
        public double? organizationStateId { get; set; }
        public string organizationZipCode { get; set; }
        public string organizationBankAccountName { get; set; }
        public string organizationBankAccountField1 { get; set; }
        public string organizationBankAccountField2 { get; set; }
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }
        public string clientCompanyName { get; set; }
        public string clientCompanyRegistrationNumber { get; set; }
        public string clientCompanyTaxId { get; set; }
        public string clientStreet1 { get; set; }
        public string clientStreet2 { get; set; }
        public string clientCity { get; set; }
        public int? clientCountryId { get; set; }
        public double? clientStateId { get; set; }
        public string clientZipCode { get; set; }
    }
    public class InvoiceAttributeN
    {
        // These fields hold the values for the public properties.
        public string value { get; set; }
        public int? customAttributeId { get; set; }
    }
    public class PaymentAttributeN
    {
        // These fields hold the values for the public properties.
        public string value { get; set; }
        public int? customAttributeId { get; set; }
    }
    public class attributeN
    {
        public int id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string attributeType { get; set; }
    }
    public class InvoiceItemN
    {
        // These fields hold the values for the public properties.
        public string label { get; set; }
        public double price { get; set; }
        public double? quantity { get; set; }
        public string unit { get; set; }
        public int? tax1Id { get; set; }
        public double? tax2Id { get; set; }
        public double? tax3Id { get; set; }
    }
    public class PaymentN
    {
        // These fields hold the values for the public properties.
        public int? clientId { get; set; }
        public string methodId { get; set; }
        public string checkNumber { get; set; }
        public string createdDate { get; set; }
        public double amount { get; set; }
        public string currencyCode { get; set; }
        public string note { get; set; }
        public bool? applyToInvoicesAutomatically { get; set; }
        public List<Models.PaymentAttributeN> attributes { get; set; }

    }
    public class RefundN : BaseModel
    {
        // These fields hold the values for the public properties.
        public Models.RefundMethod1Enum method;
        public string createdDate;
        public double amount;
        public int? clientId;
    }
}