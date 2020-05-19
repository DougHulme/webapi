using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class UNMSDevice
    {
        public UD_Attributes attributes { get; set; }
        public bool enabled { get; set; }
        public UD_identification identification { get; set; }
      }
    public class UD_Attributes
    {
        public string series { get; set; }
        public string ssid { get; set; }
        public string gatewayId { get; set; }
        public bool hasGatewayInterfaceAvailable { get; set; }
        public bool isGatewaySupported { get; set; }
    }
    public class UD_identification
    {
        public bool authorized { get; set; }
        public string category { get; set; }
        public string displayName { get; set; }
        public string firmwareVersion { get; set; }
        public string hostname { get; set; }
        public string id { get; set; }
        public string ip { get; set; }
        public string mac { get; set; }
        public string model { get; set; }
        public string modelName { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string serialNumber { get; set; }
        public ud_site site { get; set; }
    }
    public class ud_site
    {
        public string id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string type { get; set; }
    }

    public class UNMSSite
    {
        public string id { get; set; }
        public US_identification identification { get; set; }
        
        public US_Description description { get; set; }
        public int height { get; set; }
        public int elevation { get; set; }
        public int deviceCount { get; set; }
        public US_Service service { get; set; }
       
    }
    public class US_identification
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public bool suspended { get; set; }
    }
    public class US_Description
    {
        public string address { get; set; }
        public string note { get; set; }
        public US_Contact contact { get; set; }
        public US_Location location { get; set; }
        public double? height { get; set; }
       
        public int? elevation { get; set; }
    }
    public class US_Location
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
    }
    public class US_Service
    {
        public double id { get; set; }
        public string name { get; set; }
        public int status { get; set; }
    }
    public class US_Contact
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}



