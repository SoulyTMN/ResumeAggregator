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
using ResumeAggregator.Models.Internal;

namespace ResumeAggregator.Controllers
{
    public class InnerCitiesController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/InnerCities
        public IQueryable<InnerCity> GetInnerCities()
        {
            return db.InnerCities;
        }

        // GET: api/InnerCities/5
        [ResponseType(typeof(InnerCity))]
        public async Task<IHttpActionResult> GetInnerCity(int id)
        {
            InnerCity innerCity = await db.InnerCities.FindAsync(id);
            if (innerCity == null)
            {
                return NotFound();
            }

            return Ok(innerCity);
        }

        // PUT: api/InnerCities/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInnerCity(int id, InnerCity innerCity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != innerCity.Id)
            {
                return BadRequest();
            }

            db.Entry(innerCity).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InnerCityExists(id))
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

        // POST: api/InnerCities
        [ResponseType(typeof(InnerCity))]
        public async Task<IHttpActionResult> PostInnerCity(InnerCity innerCity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InnerCities.Add(innerCity);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = innerCity.Id }, innerCity);
        }

        // DELETE: api/InnerCities/5
        [ResponseType(typeof(InnerCity))]
        public async Task<IHttpActionResult> DeleteInnerCity(int id)
        {
            InnerCity innerCity = await db.InnerCities.FindAsync(id);
            if (innerCity == null)
            {
                return NotFound();
            }

            db.InnerCities.Remove(innerCity);
            await db.SaveChangesAsync();

            return Ok(innerCity);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InnerCityExists(int id)
        {
            return db.InnerCities.Count(e => e.Id == id) > 0;
        }
    }
}