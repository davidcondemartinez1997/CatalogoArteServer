using CatalogoArteServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoArteServer.Servicios
{
    public class TipoArteService : ITipoArteService
    {
        private ITipoArteRepository TipoArteRepository;
        public TipoArteService(ITipoArteRepository _TipoArteRepository)
        {
            this.TipoArteRepository = _TipoArteRepository;
        }

        public TipoArte Get(long id)
        {
            return TipoArteRepository.Get(id);
        }

        public IQueryable<TipoArte> Get()
        {
            return TipoArteRepository.Get();
        }

        public TipoArte Create(TipoArte TipoArte)
        {
            return TipoArteRepository.Create(TipoArte);
        }

        public void Put(TipoArte TipoArte)
        {
            TipoArteRepository.Put(TipoArte);
        }

        public TipoArte Delete(long id)
        {
            return TipoArteRepository.Delete(id);
        }
    }
}