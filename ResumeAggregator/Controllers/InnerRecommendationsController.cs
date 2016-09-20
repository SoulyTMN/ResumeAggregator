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
    public class InnerRecommendationsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/InnerRecommendations
        public IQueryable<InnerRecommendation> GetInnerRecommendations()
        {
            return db.InnerRecommendations;
        }

        // GET: api/InnerRecommendations/5
        [ResponseType(typeof(InnerRecommendation))]
        public async Task<IHttpActionResult> GetInnerRecommendation(int id)
        {
            InnerRecommendation innerRecommendation = await db.InnerRecommendations.FindAsync(id);
            if (innerRecommendation == null)
            {
                return NotFound();
            }

            return Ok(innerRecommendation);
        }

        // PUT: api/InnerRecommendations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInnerRecommendation(int id, InnerRecommendation innerRecommendation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != innerRecommendation.Id)
            {
                return BadRequest();
            }

            db.Entry(innerRecommendation).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InnerRecommendationExists(id))
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

        // POST: api/InnerRecommendations
        [ResponseType(typeof(InnerRecommendation))]
        public async Task<IHttpActionResult> PostInnerRecommendation(InnerRecommendation innerRecommendation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InnerRecommendations.Add(innerRecommendation);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = innerRecommendation.Id }, innerRecommendation);
        }

        // DELETE: api/InnerRecommendations/5
        [ResponseType(typeof(InnerRecommendation))]
        public async Task<IHttpActionResult> DeleteInnerRecommendation(int id)
        {
            InnerRecommendation innerRecommendation = await db.InnerRecommendations.FindAsync(id);
            if (innerRecommendation == null)
            {
                return NotFound();
            }

            db.InnerRecommendations.Remove(innerRecommendation);
            await db.SaveChangesAsync();

            return Ok(innerRecommendation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InnerRecommendationExists(int id)
        {
            return db.InnerRecommendations.Count(e => e.Id == id) > 0;
        }
    }
}