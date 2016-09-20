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
    public class InnerInstitutionCollectionsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/InnerInstitutionCollections
        public IQueryable<InnerInstitutionCollection> GetInnerInstitutionCollections()
        {
            return db.InnerInstitutionCollections;
        }

        // GET: api/InnerInstitutionCollections/5
        [ResponseType(typeof(InnerInstitutionCollection))]
        public async Task<IHttpActionResult> GetInnerInstitutionCollection(int id)
        {
            InnerInstitutionCollection innerInstitutionCollection = await db.InnerInstitutionCollections.FindAsync(id);
            if (innerInstitutionCollection == null)
            {
                return NotFound();
            }

            return Ok(innerInstitutionCollection);
        }

        // PUT: api/InnerInstitutionCollections/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInnerInstitutionCollection(int id, InnerInstitutionCollection innerInstitutionCollection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != innerInstitutionCollection.Id)
            {
                return BadRequest();
            }

            db.Entry(innerInstitutionCollection).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InnerInstitutionCollectionExists(id))
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

        // POST: api/InnerInstitutionCollections
        [ResponseType(typeof(InnerInstitutionCollection))]
        public async Task<IHttpActionResult> PostInnerInstitutionCollection(InnerInstitutionCollection innerInstitutionCollection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InnerInstitutionCollections.Add(innerInstitutionCollection);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = innerInstitutionCollection.Id }, innerInstitutionCollection);
        }

        // DELETE: api/InnerInstitutionCollections/5
        [ResponseType(typeof(InnerInstitutionCollection))]
        public async Task<IHttpActionResult> DeleteInnerInstitutionCollection(int id)
        {
            InnerInstitutionCollection innerInstitutionCollection = await db.InnerInstitutionCollections.FindAsync(id);
            if (innerInstitutionCollection == null)
            {
                return NotFound();
            }

            db.InnerInstitutionCollections.Remove(innerInstitutionCollection);
            await db.SaveChangesAsync();

            return Ok(innerInstitutionCollection);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InnerInstitutionCollectionExists(int id)
        {
            return db.InnerInstitutionCollections.Count(e => e.Id == id) > 0;
        }
    }
}