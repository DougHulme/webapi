using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webapi.Data;
using webapi.Helpers;

namespace webapi.Controllers
{
    public class RadiusController : ApiController
    {
        private radiusEntities db = new radiusEntities();

        // GET: api/Radius
        public IHttpActionResult GetRadiusEntries()
        {

            MikrotikHelper.UpdateRadius();
            return Ok();
        }

        // GET: api/Radius/5
        [ResponseType(typeof(RadiusEntry))]
        public IHttpActionResult GetRadiusEntry(long id)
        {
            RadiusEntry radiusEntry = db.RadiusEntries.Find(id);
            if (radiusEntry == null)
            {
                return NotFound();
            }

            return Ok(radiusEntry);
        }

        // PUT: api/Radius/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRadiusEntry(long id, RadiusEntry radiusEntry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != radiusEntry.id)
            {
                return BadRequest();
            }

            db.Entry(radiusEntry).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RadiusEntryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Radius
        [ResponseType(typeof(RadiusEntry))]
        public IHttpActionResult PostRadiusEntry(RadiusEntry radiusEntry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RadiusEntries.Add(radiusEntry);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RadiusEntryExists(radiusEntry.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = radiusEntry.id }, radiusEntry);
        }

        // DELETE: api/Radius/5
        [ResponseType(typeof(RadiusEntry))]
        public IHttpActionResult DeleteRadiusEntry(long id)
        {
            RadiusEntry radiusEntry = db.RadiusEntries.Find(id);
            if (radiusEntry == null)
            {
                return NotFound();
            }

            db.RadiusEntries.Remove(radiusEntry);
            db.SaveChanges();

            return Ok(radiusEntry);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RadiusEntryExists(long id)
        {
            return db.RadiusEntries.Count(e => e.id == id) > 0;
        }
    }
}