using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webapi.Data;

namespace webapi.Controllers
{
    public class HomeController : Controller
    {
        OrionAdminEntities db = new OrionAdminEntities();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            string ip = Request.UserHostAddress;
            unms_Suspend us = (from x in db.unms_Suspend
                              where x.ipaddress == ip
                              select x).FirstOrDefault();
            if (us != null) { return View("suspend_page"); };
            return View();
        }
    }
}
