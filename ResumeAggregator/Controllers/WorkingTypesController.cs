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
    public class WorkingTypesController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/WorkingTypes
        public IQueryable<WorkingType> GetWorkingTypes()
        {
            return db.WorkingTypes;
        }

        // GET: api/WorkingTypes/5
        [ResponseType(typeof(WorkingType))]
        public async Task<IHttpActionResult> GetWorkingType(int id)
        {
            WorkingType workingType = await db.WorkingTypes.FindAsync(id);
            if (workingType == null)
            {
                return NotFound();
            }

            return Ok(workingType);
        }

        // PUT: api/WorkingTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutWorkingType(int id, WorkingType workingType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != workingType.id)
            {
                return BadRequest();
            }

            db.Entry(workingType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkingTypeExists(id))
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

        // POST: api/WorkingTypes
        [ResponseType(typeof(WorkingType))]
        public async Task<IHttpActionResult> PostWorkingType(WorkingType workingType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WorkingTypes.Add(workingType);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = workingType.id }, workingType);
        }

        // DELETE: api/WorkingTypes/5
        [ResponseType(typeof(WorkingType))]
        public async Task<IHttpActionResult> DeleteWorkingType(int id)
        {
            WorkingType workingType = await db.WorkingTypes.FindAsync(id);
            if (workingType == null)
            {
                return NotFound();
            }

            db.WorkingTypes.Remove(workingType);
            await db.SaveChangesAsync();

            return Ok(workingType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WorkingTypeExists(int id)
        {
            return db.WorkingTypes.Count(e => e.id == id) > 0;
        }
    }
}