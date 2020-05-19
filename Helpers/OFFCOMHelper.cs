using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapi.Data;
using webapi.Models;

namespace webapi.Helpers
{
    public class OFFCOMHelper
    {
        public static bool writeoffcomtable()
        {
            OrionAdminEntities db = new OrionAdminEntities();
            string responseString = HTTPHelper.httpGetforunms("devices");
            List<UNMSDevice> devices = JsonConvert.DeserializeObject<List<UNMSDevice>>(responseString);
            foreach(UNMSDevice dev in devices)
            {
                OFFCOM offcom = new OFFCOM();
                if ((dev.identification.site!=null)&&(dev.identification.site.id != null))
                {
                    responseString = HTTPHelper.httpGetforunms("sites/" + dev.identification.site.id);
                    UNMSSite site = JsonConvert.DeserializeObject<UNMSSite>(responseString);
                    offcom.address = site.description.address;
                    offcom.surname = dev.identification.name;
                    offcom.firstname = dev.identification.mac;
                    if ((site.description.location!=null)&&(site.description.location.latitude != 0))
                    {
                        offcom.easting = site.description.location.latitude.ToString();
                        offcom.northing = site.description.location.longitude.ToString();
                        if ((offcom.easting.Substring(0, 1) + offcom.northing.Substring(1, 1)) == "50") { offcom.C2lettergridsquare = "TV"; }
                        if ((offcom.easting.Substring(0, 1) + offcom.northing.Substring(1, 1)) == "51") { offcom.C2lettergridsquare = "TQ"; }
                        if ((offcom.easting.Substring(0, 1) + offcom.northing.Substring(1, 1)) == "52") { offcom.C2lettergridsquare = "TL"; }
                        if ((offcom.easting.Substring(0, 1) + offcom.northing.Substring(1, 1)) == "53") { offcom.C2lettergridsquare = "TF"; }

                        string east = Math.Round(Convert.ToDouble(offcom.easting) / 100, 4).ToString();
                        string north = Math.Round(Convert.ToDouble(offcom.northing) / 10, 4).ToString();
                        offcom.C3lettereasting = offcom.easting.Substring(3, 3);
                        offcom.C3letternorthing = offcom.northing.Substring(3, 3);
                    }
                    offcom.terminaltype = dev.identification.role;
                    db.OFFCOMs.Add(offcom);
                    db.SaveChanges();


                }

               
               

            }
           
            return true;
        }
    }
}