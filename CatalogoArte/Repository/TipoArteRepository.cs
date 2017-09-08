using CatalogoArteServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatalogoArteServer.Repository
{
    public class TipoArteRepository : ITipoArteRepository
    {
        public TipoArte Create(TipoArte TipoArte)
        {
            return ApplicationDbContext.applicationDbContext.TipoArte.Add(TipoArte);
        }

        public TipoArte Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.TipoArte.Find(id);
        }

        public IQueryable<TipoArte> Get()
        {
            IList<TipoArte> lista = new List<TipoArte>(ApplicationDbContext.applicationDbContext.TipoArte);

            return lista.AsQueryable();
        }


        public void Put(TipoArte TipoArte)
        {
            if (ApplicationDbContext.applicationDbContext.TipoArte.Count(e => e.Id == TipoArte.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(TipoArte).State = EntityState.Modified;
        }

        public TipoArte Delete(long id)
        {
            TipoArte TipoArte = ApplicationDbContext.applicationDbContext.TipoArte.Find(id);
            if (TipoArte == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.TipoArte.Remove(TipoArte);
            return TipoArte;
        }
    }
}