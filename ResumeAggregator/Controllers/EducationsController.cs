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
    public class EducationsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/Educations
        public IQueryable<Education> GetEducations()
        {
            return db.Educations;
        }

        // GET: api/Educations/5
        [ResponseType(typeof(Education))]
        public async Task<IHttpActionResult> GetEducation(int id)
        {
            Education education = await db.Educations.FindAsync(id);
            if (education == null)
            {
                return NotFound();
            }

            return Ok(education);
        }

        // PUT: api/Educations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEducation(int id, Education education)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != education.id)
            {
                return BadRequest();
            }

            db.Entry(education).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationExists(id))
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

        // POST: api/Educations
        [ResponseType(typeof(Education))]
        public async Task<IHttpActionResult> PostEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Educations.Add(education);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = education.id }, education);
        }

        // DELETE: api/Educations/5
        [ResponseType(typeof(Education))]
        public async Task<IHttpActionResult> DeleteEducation(int id)
        {
            Education education = await db.Educations.FindAsync(id);
            if (education == null)
            {
                return NotFound();
            }

            db.Educations.Remove(education);
            await db.SaveChangesAsync();

            return Ok(education);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EducationExists(int id)
        {
            return db.Educations.Count(e => e.id == id) > 0;
        }
    }
}