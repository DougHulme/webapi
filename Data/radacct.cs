//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class radacct
    {
        public long radacctid { get; set; }
        public string acctsessionid { get; set; }
        public string acctuniqueid { get; set; }
        public string username { get; set; }
        public string groupname { get; set; }
        public string realm { get; set; }
        public string nasipaddress { get; set; }
        public string nasportid { get; set; }
        public string nasporttype { get; set; }
        public Nullable<System.DateTime> acctstarttime { get; set; }
        public Nullable<System.DateTime> acctstoptime { get; set; }
        public Nullable<int> acctsessiontime { get; set; }
        public string acctauthentic { get; set; }
        public string connectinfo_start { get; set; }
        public string connectinfo_stop { get; set; }
        public Nullable<long> acctinputoctets { get; set; }
        public Nullable<long> acctoutputoctets { get; set; }
        public string calledstationid { get; set; }
        public string callingstationid { get; set; }
        public string acctterminatecause { get; set; }
        public string servicetype { get; set; }
        public string framedprotocol { get; set; }
        public string framedipaddress { get; set; }
        public Nullable<int> acctstartdelay { get; set; }
        public Nullable<int> acctstopdelay { get; set; }
        public string xascendsessionsvrkey { get; set; }
    }
}
