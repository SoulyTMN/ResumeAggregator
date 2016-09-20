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
    public class InnerSecondaryEducationsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/InnerSecondaryEducations
        public IQueryable<InnerSecondaryEducations> GetInnerSecondaryEducations()
        {
            return db.InnerSecondaryEducations;
        }

        // GET: api/InnerSecondaryEducations/5
        [ResponseType(typeof(InnerSecondaryEducations))]
        public async Task<IHttpActionResult> GetInnerSecondaryEducations(int id)
        {
            InnerSecondaryEducations innerSecondaryEducations = await db.InnerSecondaryEducations.FindAsync(id);
            if (innerSecondaryEducations == null)
            {
                return NotFound();
            }

            return Ok(innerSecondaryEducations);
        }

        // PUT: api/InnerSecondaryEducations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInnerSecondaryEducations(int id, InnerSecondaryEducations innerSecondaryEducations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != innerSecondaryEducations.Id)
            {
                return BadRequest();
            }

            db.Entry(innerSecondaryEducations).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InnerSecondaryEducationsExists(id))
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

        // POST: api/InnerSecondaryEducations
        [ResponseType(typeof(InnerSecondaryEducations))]
        public async Task<IHttpActionResult> PostInnerSecondaryEducations(InnerSecondaryEducations innerSecondaryEducations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InnerSecondaryEducations.Add(innerSecondaryEducations);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = innerSecondaryEducations.Id }, innerSecondaryEducations);
        }

        // DELETE: api/InnerSecondaryEducations/5
        [ResponseType(typeof(InnerSecondaryEducations))]
        public async Task<IHttpActionResult> DeleteInnerSecondaryEducations(int id)
        {
            InnerSecondaryEducations innerSecondaryEducations = await db.InnerSecondaryEducations.FindAsync(id);
            if (innerSecondaryEducations == null)
            {
                return NotFound();
            }

            db.InnerSecondaryEducations.Remove(innerSecondaryEducations);
            await db.SaveChangesAsync();

            return Ok(innerSecondaryEducations);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InnerSecondaryEducationsExists(int id)
        {
            return db.InnerSecondaryEducations.Count(e => e.Id == id) > 0;
        }
    }
}