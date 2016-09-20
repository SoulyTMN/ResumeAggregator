using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ResumeAggregator.Models;
using ResumeAggregator.Models.E1;

namespace ResumeAggregator.Controllers
{
    public class DriverLicensesController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/DriverLicenses
        public IQueryable<DriverLicense> GetDriverLicenses()
        {
            return db.DriverLicenses;
        }

        // GET: api/DriverLicenses/5
        [ResponseType(typeof(DriverLicense))]
        public async Task<IHttpActionResult> GetDriverLicense(int id)
        {
            DriverLicense driverLicense = await db.DriverLicenses.FindAsync(id);
            if (driverLicense == null)
            {
                return NotFound();
            }

            return Ok(driverLicense);
        }

        // PUT: api/DriverLicenses/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDriverLicense(int id, DriverLicense driverLicense)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != driverLicense.id)
            {
                return BadRequest();
            }

            db.Entry(driverLicense).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DriverLicenseExists(id))
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

        // POST: api/DriverLicenses
        [ResponseType(typeof(DriverLicense))]
        public async Task<IHttpActionResult> PostDriverLicense(DriverLicense driverLicense)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DriverLicenses.Add(driverLicense);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = driverLicense.id }, driverLicense);
        }

        // DELETE: api/DriverLicenses/5
        [ResponseType(typeof(DriverLicense))]
        public async Task<IHttpActionResult> DeleteDriverLicense(int id)
        {
            DriverLicense driverLicense = await db.DriverLicenses.FindAsync(id);
            if (driverLicense == null)
            {
                return NotFound();
            }

            db.DriverLicenses.Remove(driverLicense);
            await db.SaveChangesAsync();

            return Ok(driverLicense);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DriverLicenseExists(int id)
        {
            return db.DriverLicenses.Count(e => e.id == id) > 0;
        }
    }
}