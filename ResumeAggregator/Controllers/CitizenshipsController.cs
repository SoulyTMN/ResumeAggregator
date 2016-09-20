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
    public class CitizenshipsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/Citizenships
        public IQueryable<Citizenship> GetCitizenships()
        {
            return db.Citizenships;
        }

        // GET: api/Citizenships/5
        [ResponseType(typeof(Citizenship))]
        public async Task<IHttpActionResult> GetCitizenship(int id)
        {
            Citizenship citizenship = await db.Citizenships.FindAsync(id);
            if (citizenship == null)
            {
                return NotFound();
            }

            return Ok(citizenship);
        }

        // PUT: api/Citizenships/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCitizenship(int id, Citizenship citizenship)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != citizenship.id)
            {
                return BadRequest();
            }

            db.Entry(citizenship).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitizenshipExists(id))
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

        // POST: api/Citizenships
        [ResponseType(typeof(Citizenship))]
        public async Task<IHttpActionResult> PostCitizenship(Citizenship citizenship)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Citizenships.Add(citizenship);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = citizenship.id }, citizenship);
        }

        // DELETE: api/Citizenships/5
        [ResponseType(typeof(Citizenship))]
        public async Task<IHttpActionResult> DeleteCitizenship(int id)
        {
            Citizenship citizenship = await db.Citizenships.FindAsync(id);
            if (citizenship == null)
            {
                return NotFound();
            }

            db.Citizenships.Remove(citizenship);
            await db.SaveChangesAsync();

            return Ok(citizenship);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CitizenshipExists(int id)
        {
            return db.Citizenships.Count(e => e.id == id) > 0;
        }
    }
}