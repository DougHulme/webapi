using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using webapi.Data;
using webapi.Models.BootGrid;

namespace webapi.Controllers
{
    public class radusageController : ApiController
    {
        private OrionAdminEntities db = new OrionAdminEntities();

        // GET: api/radUsage
        public IHttpActionResult Get(int current, int rowCount, string sortBy="Username",string sortDir = "asc", string searchPhrase="",  int _ =1,   string currentFilter="")
        {
            DateTime minus6months = DateTime.Now.AddMonths(-6);
            var RadUsage = (from a in db.radiusUsages
                                where a.date > minus6months
                                select a);
            var RadUsageSub = (from a in RadUsage
                      group a by new { a.username, monthin = a.date.Value.Month } into g
                      orderby g.Key.username, g.Key.monthin
                      select new { Username = g.Key.username, MonthIn = g.Key.monthin, Upload = g.Sum(x => x.upload / 1000000), Download = g.Sum(x => x.download / 1000000) });
           
            //search string filter here
            if (!String.IsNullOrEmpty(searchPhrase))
            {
                RadUsageSub = RadUsageSub.Where(s => s.Username.Contains(searchPhrase));
            }

            // now create the pivot table
            int n = 0;
            string usernamestored = "";
            List<Bootgrid_radiusentry_summary> radiuslist = new List<Bootgrid_radiusentry_summary>();
            Bootgrid_radiusentry_summary sep = new Bootgrid_radiusentry_summary();
            foreach (var be in RadUsageSub)
            {

                if (be.Username != usernamestored)
                {
                    if (usernamestored != "") { radiuslist.Add(sep); }
                    n = n + 1;
                    sep = new Bootgrid_radiusentry_summary();
                    sep.Id = n;
                    usernamestored = be.Username;
                    sep.Username = be.Username;
                   
                }
                switch (be.MonthIn)
                {
                    case 1:
                        sep.Download01 = be.Download + "M / " + be.Upload + "M";
                        sep.down1 = be.Download;
                        break;
                    case 2:
                        sep.Download02 = be.Download + "M / " + be.Upload + "M";
                        sep.down2 = be.Download;
                        break;
                    case 3:
                        sep.Download03 = be.Download + "M / " + be.Upload + "M";
                        sep.down3 = be.Download;
                        break;
                    case 4:
                        sep.Download04 = be.Download + "M / " + be.Upload + "M";
                        sep.down4 = be.Download;
                        break;
                    case 5:
                        sep.Download05 = be.Download + "M / " + be.Upload + "M";
                        sep.down5= be.Download;
                        break;
                    case 6:
                        sep.Download06 = be.Download + "M / " + be.Upload + "M";
                        sep.down6 = be.Download;
                        break;
                    case 7:
                        sep.Download07 = be.Download + "M / " + be.Upload + "M";
                        sep.down7 = be.Download;
                        break;
                    case 8:
                        sep.Download08 = be.Download + "M / " + be.Upload + "M";
                        sep.down8 = be.Download;
                        break;
                    case 9:
                        sep.Download09 = be.Download + "M / " + be.Upload + "M";
                        sep.down9 = be.Download;
                        break;
                    case 10:
                        sep.Download10 = be.Download + "M / " + be.Upload + "M";
                        sep.down10 = be.Download;
                        break;
                    case 11:
                        sep.Download11 = be.Download + "M / " + be.Upload + "M";
                        sep.down11 = be.Download;
                        break;
                    case 12:
                        sep.Download12 = be.Download + "M / " + be.Upload + "M";
                        sep.down12 = be.Download;
                        break;
                }
            }
            // write out last record
            radiuslist.Add(sep);

           
            // sort the records
            string cursort = "";
            if (string.IsNullOrEmpty(sortDir)) { cursort = "username_asc"; } else { cursort = sortBy + "_" + sortDir; };

            switch (cursort)
            {
                case "Username_asc":
                    radiuslist = radiuslist.OrderBy(s => s.Username).ToList();
                    current = 1;
                    break;
                case "Username_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.Username).ToList();
                    current = 1;
                    break;
             
                case "Download01_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down1).ToList();
                    break;
                case "Download01_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down1).ToList();
                    break;
                case "Download02_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down2).ToList();
                    break;
                case "Download02_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down2).ToList();
                    break;
                case "Download03_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down3).ToList();
                    break;
                case "Download03_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down3).ToList();
                    break;
                case "Download04_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down4).ToList();
                    break;
                case "Download04_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down4).ToList();
                    break;
                case "Download05_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down5).ToList();
                    break;
                case "Download05_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down5).ToList();
                    break;
                case "Download06_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down6).ToList();
                    break;
                case "Download06_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down6).ToList();
                    break;
                case "Download07_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down7).ToList();
                    break;
                case "Download07_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down7).ToList();
                    break;
                case "Download08_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down8).ToList();
                    break;
                case "Download08_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down8).ToList();
                    break;
                case "Download09_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down9).ToList();
                    break;
                case "Download09_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down9).ToList();
                    break;
                case "Download10_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down10).ToList();
                    break;
                case "Download10_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down10).ToList();
                    break;
                case "Download11_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down11).ToList();
                    break;
                case "Download11_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down11).ToList();
                    break;
                case "Download12_asc":
                    radiuslist = radiuslist.OrderBy(s => s.down12).ToList();
                    break;
                case "Download12_desc":
                    radiuslist = radiuslist.OrderByDescending(s => s.down12).ToList();
                    break;
            }
      
      
            var radiuslist1 = radiuslist.Skip((current-1)*rowCount).Take(Convert.ToInt32(rowCount)).ToList();
            Bootgrid_radusage bgru = new Bootgrid_radusage();

            bgru.current = current;
            bgru.rowCount = Convert.ToInt32(rowCount);
            bgru.total = radiuslist.Count();
            bgru.rows = radiuslist1;

            return Json(bgru);
        }

       

      

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

       
       
    }
}