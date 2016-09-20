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
    public class ExperienceLengthsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/ExperienceLengths
        public IQueryable<ExperienceLength> GetExperienceLengths()
        {
            return db.ExperienceLengths;
        }

        // GET: api/ExperienceLengths/5
        [ResponseType(typeof(ExperienceLength))]
        public async Task<IHttpActionResult> GetExperienceLength(int id)
        {
            ExperienceLength experienceLength = await db.ExperienceLengths.FindAsync(id);
            if (experienceLength == null)
            {
                return NotFound();
            }

            return Ok(experienceLength);
        }

        // PUT: api/ExperienceLengths/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutExperienceLength(int id, ExperienceLength experienceLength)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != experienceLength.id)
            {
                return BadRequest();
            }

            db.Entry(experienceLength).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExperienceLengthExists(id))
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

        // POST: api/ExperienceLengths
        [ResponseType(typeof(ExperienceLength))]
        public async Task<IHttpActionResult> PostExperienceLength(ExperienceLength experienceLength)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ExperienceLengths.Add(experienceLength);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = experienceLength.id }, experienceLength);
        }

        // DELETE: api/ExperienceLengths/5
        [ResponseType(typeof(ExperienceLength))]
        public async Task<IHttpActionResult> DeleteExperienceLength(int id)
        {
            ExperienceLength experienceLength = await db.ExperienceLengths.FindAsync(id);
            if (experienceLength == null)
            {
                return NotFound();
            }

            db.ExperienceLengths.Remove(experienceLength);
            await db.SaveChangesAsync();

            return Ok(experienceLength);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExperienceLengthExists(int id)
        {
            return db.ExperienceLengths.Count(e => e.id == id) > 0;
        }
    }
}