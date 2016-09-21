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
    public class InnerResumesController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/InnerResumes
        public IQueryable<InnerCV> GetInnerResumes()
        {
            return db.InnerCVs;
        }

        // GET: api/InnerResumes/5
        [ResponseType(typeof(InnerCV))]
        public async Task<IHttpActionResult> GetInnerResume(int id)
        {
            InnerCV innerResume = await db.InnerCVs.FindAsync(id);
            if (innerResume == null)
            {
                return NotFound();
            }

            return Ok(innerResume);
        }

        // PUT: api/InnerResumes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInnerResume(int id, InnerCV innerResume)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != innerResume.Id)
            {
                return BadRequest();
            }

            db.Entry(innerResume).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InnerResumeExists(id))
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

        // POST: api/InnerResumes
        [ResponseType(typeof(InnerCV))]
        public async Task<IHttpActionResult> PostInnerResume(InnerCV innerResume)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InnerCVs.Add(innerResume);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (InnerResumeExists(innerResume.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(innerResume);
        }

        // DELETE: api/InnerResumes/5
        [ResponseType(typeof(InnerCV))]
        public async Task<IHttpActionResult> DeleteInnerResume(int id)
        {
            InnerCV innerResume = await db.InnerCVs.FindAsync(id);
            if (innerResume == null)
            {
                return NotFound();
            }

            db.InnerCVs.Remove(innerResume);
            await db.SaveChangesAsync();

            return Ok(innerResume);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InnerResumeExists(int id)
        {
            return db.InnerCVs.Count(e => e.Id == id) > 0;
        }
    }
}