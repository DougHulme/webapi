using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapi.Data;
using webapi.Models;

namespace webapi.Helpers
{
    public class SNMPHelper
    {

        public static bool editsnmpresults()
        {
            
              OrionAdminEntities db = new OrionAdminEntities();
                
            List<snmpResult> rslist = (from x in db.snmpResults where x.Date>= new DateTime(2020,1,1) orderby  x.Server, x.Date, x.Name select x).ToList();
         
            long? raduploadbytes = 0;
            long? raddownloadbytes = 0;
            string pppName = "";


            foreach (snmpResult rs in rslist)
                {
                    if(( rs.Name!= pppName) && (pppName != "")) { db.SaveChanges(); };
                
                if ((raddownloadbytes != 0) && (rs.outbytes > raddownloadbytes))
                    {
                            snmpResultsEdited snmpe = new snmpResultsEdited();
                            snmpe.Server = rs.Server;
                            snmpe.Name = rs.Name;
                            snmpe.DateFrom = rs.Date;
                            snmpe.download = (rs.outbytes - raddownloadbytes) / 30000000;
                            snmpe.upload = (rs.inbytes - raduploadbytes) / 30000000;
                            db.snmpResultsEditeds.Add(snmpe);
                            db.SaveChanges();
                    }

                    raduploadbytes = rs.inbytes;
                    raddownloadbytes = rs.outbytes;
                }
            db.SaveChanges();
            return true;
        }
    }
}