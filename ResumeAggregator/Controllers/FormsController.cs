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
    public class FormsController : ApiController
    {
        private ResumeAggregatorContext db = new ResumeAggregatorContext();

        // GET: api/Forms
        public IQueryable<Form> GetForms()
        {
            return db.Forms;
        }

        // GET: api/Forms/5
        [ResponseType(typeof(Form))]
        public async Task<IHttpActionResult> GetForm(int id)
        {
            Form form = await db.Forms.FindAsync(id);
            if (form == null)
            {
                return NotFound();
            }

            return Ok(form);
        }

        // PUT: api/Forms/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutForm(int id, Form form)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != form.id)
            {
                return BadRequest();
            }

            db.Entry(form).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormExists(id))
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

        // POST: api/Forms
        [ResponseType(typeof(Form))]
        public async Task<IHttpActionResult> PostForm(Form form)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Forms.Add(form);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = form.id }, form);
        }

        // DELETE: api/Forms/5
        [ResponseType(typeof(Form))]
        public async Task<IHttpActionResult> DeleteForm(int id)
        {
            Form form = await db.Forms.FindAsync(id);
            if (form == null)
            {
                return NotFound();
            }

            db.Forms.Remove(form);
            await db.SaveChangesAsync();

            return Ok(form);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FormExists(int id)
        {
            return db.Forms.Count(e => e.id == id) > 0;
        }
    }
}