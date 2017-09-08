using CatalogoArteServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoArteServer.Servicios
{
    public class ArteService: IArteService
    {
        private IArteRepository ArteReposistory;
        public ArteService(IArteRepository _ArteRepository)
        {
            this.ArteReposistory = _ArteRepository;
        }

        public Arte Get(long id)
        {
            return ArteReposistory.Get(id);
        }

        public IQueryable<Arte> Get()
        {
            return ArteReposistory.Get();
        }

        public Arte Create(Arte Arte)
        {
            return ArteReposistory.Create(Arte);
        }

        public void Put(Arte Arte)
        {
            ArteReposistory.Put(Arte);
        }

        public Arte Delete(long id)
        {
            return ArteReposistory.Delete(id);
        }
    }
}