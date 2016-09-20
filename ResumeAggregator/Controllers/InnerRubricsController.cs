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
    public class InnerRubricsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/InnerRubrics
        public IQueryable<InnerRubric> GetInnerRubrics()
        {
            return db.InnerRubrics;
        }

        // GET: api/InnerRubrics/5
        [ResponseType(typeof(InnerRubric))]
        public async Task<IHttpActionResult> GetInnerRubric(int id)
        {
            InnerRubric innerRubric = await db.InnerRubrics.FindAsync(id);
            if (innerRubric == null)
            {
                return NotFound();
            }

            return Ok(innerRubric);
        }

        // PUT: api/InnerRubrics/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInnerRubric(int id, InnerRubric innerRubric)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != innerRubric.id)
            {
                return BadRequest();
            }

            db.Entry(innerRubric).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InnerRubricExists(id))
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

        // POST: api/InnerRubrics
        [ResponseType(typeof(InnerRubric))]
        public async Task<IHttpActionResult> PostInnerRubric(InnerRubric innerRubric)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InnerRubrics.Add(innerRubric);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = innerRubric.id }, innerRubric);
        }

        // DELETE: api/InnerRubrics/5
        [ResponseType(typeof(InnerRubric))]
        public async Task<IHttpActionResult> DeleteInnerRubric(int id)
        {
            InnerRubric innerRubric = await db.InnerRubrics.FindAsync(id);
            if (innerRubric == null)
            {
                return NotFound();
            }

            db.InnerRubrics.Remove(innerRubric);
            await db.SaveChangesAsync();

            return Ok(innerRubric);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InnerRubricExists(int id)
        {
            return db.InnerRubrics.Count(e => e.id == id) > 0;
        }
    }
}