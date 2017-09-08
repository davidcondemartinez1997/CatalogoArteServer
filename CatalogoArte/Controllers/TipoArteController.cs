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
    public class TipoArteController : ApiController
    {
        private ITipoArteService TipoArteService;

        public TipoArteController(ITipoArteService _TipoArteService)
        {
            this.TipoArteService = _TipoArteService;
        }

        // GET: api/TipoArte
        public IQueryable<TipoArte> GetTipoArte()
        {
            return TipoArteService.Get();
        }

        // GET: api/TipoArte/5
        [ResponseType(typeof(TipoArte))]
        public IHttpActionResult GetTipoArte(long id)
        {
            TipoArte TipoArte = TipoArteService.Get(id);
            if (TipoArte == null)
            {
                return NotFound();
            }

            return Ok(TipoArte);
        }

        // PUT: api/TipoArte/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoArte(long id, TipoArte TipoArte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != TipoArte.Id)
            {
                return BadRequest();
            }

            try
            {
                TipoArteService.Put(TipoArte);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TipoArte
        [ResponseType(typeof(TipoArte))]
        public IHttpActionResult PostUsuario(TipoArte TipoArte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TipoArte = TipoArteService.Create(TipoArte);

            return CreatedAtRoute("DefaultApi", new { id = TipoArte.Id }, TipoArte);
        }

        // DELETE: api/TipoArte/5
        [ResponseType(typeof(TipoArte))]
        public IHttpActionResult DeleteTipoArte(long id)
        {
            TipoArte TipoArte;
            try
            {
                TipoArte = TipoArteService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(TipoArte);
        }
    }
}