using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi.Helpers;
using webapi.Models;
using webapi.Models.BootGrid;

namespace webapi.Controllers
{
    public class unmsreportsController : ApiController
    {
        public IHttpActionResult Get(int current, int rowCount, string sortBy = "Username", string sortDir = "asc", string searchPhrase = "", int _ = 1, string currentFilter = "")
           
        {
            List<InvoiceReadOnly> invoices = UNMSHelper.getinvoices();
            List<bootgridinvoiceSummary_list> invoicelist = (from x in invoices
                                                             where x.Status!=InvoiceStatusEnum.ENUM_3
                                                             group x by new { firstName = x.ClientFirstName, lastName= x.ClientLastName } into g
                                                             orderby g.Key.firstName, g.Key.lastName
                                                             select new bootgridinvoiceSummary_list
                                                             {
                                                                 Name = g.Key.firstName + " " +g.Key.lastName,
                                                                 Jan = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 1).Sum(z => z.Total),
                                                                 Feb = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 2).Sum(z => z.Total),
                                                                 Mar = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 3).Sum(z => z.Total),
                                                                 Apr = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 4).Sum(z => z.Total),
                                                                 May = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 5).Sum(z => z.Total),
                                                                 Jun = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 6).Sum(z => z.Total),
                                                                 Jul = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 7).Sum(z => z.Total),
                                                                 Aug = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 8).Sum(z => z.Total),
                                                                 Sep = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 9).Sum(z => z.Total),
                                                                 Oct = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 10).Sum(z => z.Total),
                                                                 Nov = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 11).Sum(z => z.Total),
                                                                 Dec = g.Where(x => DateTime.Parse(x.CreatedDate).Month == 12).Sum(z => z.Total),
                                                                 Tot = g.Sum(z => z.Total)
                                                             }).ToList();



            Bootgrid_invoicesummary bgru = new Bootgrid_invoicesummary();


         //   bgru.current = 1;
        //    bgru.rowCount = 20;
            bgru.current = current;
            bgru.rowCount = Convert.ToInt32(rowCount);
            bgru.total = invoicelist.Count();
            bgru.rows = invoicelist;

            return Json(bgru);
        }
    }
}
