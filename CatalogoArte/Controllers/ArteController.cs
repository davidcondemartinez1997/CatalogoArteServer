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
using CatalogoArteServer;
using CatalogoArteServer.Models;
using CatalogoArteServer.Servicios;
using System.Web.Http.Cors;

namespace CatalogoArteServer.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class ArteController : ApiController
    {
        private IArteService ArteService;

        public ArteController(IArteService _ArteService)
        {
            this.ArteService = _ArteService;
        }

        // GET: api/Arte
        public IQueryable<Arte> GetArte()
        {
            return ArteService.Get();
        }

        // GET: api/Arte/5
        [ResponseType(typeof(Arte))]
        public IHttpActionResult GetArte(long id)
        {
            Arte Arte = ArteService.Get(id);
            if (Arte == null)
            {
                return NotFound();
            }

            return Ok(Arte);
        }

        // PUT: api/Arte/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArte(long id, Arte Arte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Arte.Id)
            {
                return BadRequest();
            }

            try
            {
                ArteService.Put(Arte);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Arte
        [ResponseType(typeof(Arte))]
        public IHttpActionResult PostArte(Arte Arte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Arte = ArteService.Create(Arte);

            return CreatedAtRoute("DefaultApi", new { id = Arte.Id }, Arte);
        }

        // DELETE: api/Arte/5
        [ResponseType(typeof(Arte))]
        public IHttpActionResult DeleteArte(long id)
        {
            Arte pelicula;
            try
            {
                pelicula = ArteService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(pelicula);
        }
    }
}