using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _20162017.Models;

namespace _20162017.Controllers
{
    public class API_ModulesController : ApiController
    {
        private CoreContext db = new CoreContext();

        // GET: api/API_Modules
        public IQueryable<Module> GetModulesRef()
        {
            return db.ModulesRef;
        }

        // GET: api/API_Modules/5
        [ResponseType(typeof(Module))]
        public IHttpActionResult GetModule(int id)
        {
            Module module = db.ModulesRef.Find(id);
            if (module == null)
            {
                return NotFound();
            }

            return Ok(module);
        }

        // PUT: api/API_Modules/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutModule(int id, Module module)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != module.ID)
            {
                return BadRequest();
            }

            db.Entry(module).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleExists(id))
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

        // POST: api/API_Modules
        [ResponseType(typeof(Module))]
        public IHttpActionResult PostModule(Module module)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ModulesRef.Add(module);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = module.ID }, module);
        }

        // DELETE: api/API_Modules/5
        [ResponseType(typeof(Module))]
        public IHttpActionResult DeleteModule(int id)
        {
            Module module = db.ModulesRef.Find(id);
            if (module == null)
            {
                return NotFound();
            }

            db.ModulesRef.Remove(module);
            db.SaveChanges();

            return Ok(module);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModuleExists(int id)
        {
            return db.ModulesRef.Count(e => e.ID == id) > 0;
        }
    }
}