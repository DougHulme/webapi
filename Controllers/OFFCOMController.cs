using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webapi.Data;
using webapi.Helpers;

namespace webapi.Controllers
{
    public class OFFCOMController : Controller
    {
        private OrionAdminEntities db = new OrionAdminEntities();

        // GET: OFFCOM
        public ActionResult Index()
        {
            OFFCOMHelper.writeoffcomtable();
            return View(db.OFFCOMs.ToList());
        }

        // GET: OFFCOM/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFFCOM oFFCOM = db.OFFCOMs.Find(id);
            if (oFFCOM == null)
            {
                return HttpNotFound();
            }
            return View(oFFCOM);
        }

        // GET: OFFCOM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OFFCOM/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,House_no,sitePostcode,C2lettergridsquare,C3lettereasting,C3letternorthing,easting,northing,terminaltype,firstname,surname,address,Town,County,postcode")] OFFCOM oFFCOM)
        {
            if (ModelState.IsValid)
            {
                db.OFFCOMs.Add(oFFCOM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oFFCOM);
        }

        // GET: OFFCOM/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFFCOM oFFCOM = db.OFFCOMs.Find(id);
            if (oFFCOM == null)
            {
                return HttpNotFound();
            }
            return View(oFFCOM);
        }

        // POST: OFFCOM/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,House_no,sitePostcode,C2lettergridsquare,C3lettereasting,C3letternorthing,easting,northing,terminaltype,firstname,surname,address,Town,County,postcode")] OFFCOM oFFCOM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oFFCOM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oFFCOM);
        }

        // GET: OFFCOM/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OFFCOM oFFCOM = db.OFFCOMs.Find(id);
            if (oFFCOM == null)
            {
                return HttpNotFound();
            }
            return View(oFFCOM);
        }

        // POST: OFFCOM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OFFCOM oFFCOM = db.OFFCOMs.Find(id);
            db.OFFCOMs.Remove(oFFCOM);
            db.SaveChanges();
            return RedirectToAction("Index");
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
