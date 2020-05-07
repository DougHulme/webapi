using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webapi.Data;

namespace webapi.Controllers
{
    public class landingpageController : Controller
    {
        private OrionAdminEntities db = new OrionAdminEntities();

        // GET: landingpage
        public ActionResult Index()
        {
            return View(db.ReqLogs.ToList());
        }

        // GET: landingpage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: landingpage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult Create( ReqLog reqLog)
        {
            if (ModelState.IsValid)
            {
                db.ReqLogs.Add(reqLog);
                db.SaveChanges();
                return RedirectToAction("Respond");
            }

            return View(reqLog);
        }
        public ActionResult Respond()
        {
            return View();
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
