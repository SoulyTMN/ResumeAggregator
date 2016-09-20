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
    public class SubwaysController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/Subways
        public IQueryable<Subway> GetSubways()
        {
            return db.Subways;
        }

        // GET: api/Subways/5
        [ResponseType(typeof(Subway))]
        public async Task<IHttpActionResult> GetSubway(int id)
        {
            Subway subway = await db.Subways.FindAsync(id);
            if (subway == null)
            {
                return NotFound();
            }

            return Ok(subway);
        }

        // PUT: api/Subways/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSubway(int id, Subway subway)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subway.id)
            {
                return BadRequest();
            }

            db.Entry(subway).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubwayExists(id))
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

        // POST: api/Subways
        [ResponseType(typeof(Subway))]
        public async Task<IHttpActionResult> PostSubway(Subway subway)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Subways.Add(subway);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = subway.id }, subway);
        }

        // DELETE: api/Subways/5
        [ResponseType(typeof(Subway))]
        public async Task<IHttpActionResult> DeleteSubway(int id)
        {
            Subway subway = await db.Subways.FindAsync(id);
            if (subway == null)
            {
                return NotFound();
            }

            db.Subways.Remove(subway);
            await db.SaveChangesAsync();

            return Ok(subway);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SubwayExists(int id)
        {
            return db.Subways.Count(e => e.id == id) > 0;
        }
    }
}