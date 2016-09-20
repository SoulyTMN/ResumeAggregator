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
    public class InnerJobsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/InnerJobs
        public IQueryable<InnerJob> GetInnerJobs()
        {
            return db.InnerJobs;
        }

        // GET: api/InnerJobs/5
        [ResponseType(typeof(InnerJob))]
        public async Task<IHttpActionResult> GetInnerJob(int id)
        {
            InnerJob innerJob = await db.InnerJobs.FindAsync(id);
            if (innerJob == null)
            {
                return NotFound();
            }

            return Ok(innerJob);
        }

        // PUT: api/InnerJobs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInnerJob(int id, InnerJob innerJob)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != innerJob.Id)
            {
                return BadRequest();
            }

            db.Entry(innerJob).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InnerJobExists(id))
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

        // POST: api/InnerJobs
        [ResponseType(typeof(InnerJob))]
        public async Task<IHttpActionResult> PostInnerJob(InnerJob innerJob)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InnerJobs.Add(innerJob);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = innerJob.Id }, innerJob);
        }

        // DELETE: api/InnerJobs/5
        [ResponseType(typeof(InnerJob))]
        public async Task<IHttpActionResult> DeleteInnerJob(int id)
        {
            InnerJob innerJob = await db.InnerJobs.FindAsync(id);
            if (innerJob == null)
            {
                return NotFound();
            }

            db.InnerJobs.Remove(innerJob);
            await db.SaveChangesAsync();

            return Ok(innerJob);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InnerJobExists(int id)
        {
            return db.InnerJobs.Count(e => e.Id == id) > 0;
        }
    }
}