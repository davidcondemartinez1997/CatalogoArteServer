using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoArteServer.Servicios
{
    public interface ITipoArteService
    {
        TipoArte Create(TipoArte TipoArte);
        TipoArte Get(long id);
        IQueryable<TipoArte> Get();
        void Put(TipoArte TipoArte);
        TipoArte Delete(long id);
    }
}
