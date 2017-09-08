using CatalogoArteServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatalogoArteServer.Repository
{
    public class ArteRepository : IArteRepository
    {
        public Arte Create(Arte Arte)
        {
            return ApplicationDbContext.applicationDbContext.Arte.Add(Arte);
        }

        public Arte Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Arte.Find(id);
        }

        public IQueryable<Arte> Get()
        {
            IList<Arte> lista = new List<Arte>(ApplicationDbContext.applicationDbContext.Arte);

            return lista.AsQueryable();
        }


        public void Put(Arte Arte)
        {
            if (ApplicationDbContext.applicationDbContext.Arte.Count(e => e.Id == Arte.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(Arte).State = EntityState.Modified;
        }

        public Arte Delete(long id)
        {
            Arte Arte = ApplicationDbContext.applicationDbContext.Arte.Find(id);
            if (Arte == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Arte.Remove(Arte);
            return Arte;
        }
    }
}