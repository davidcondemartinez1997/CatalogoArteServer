using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoArteServer.Repository
{
    public interface ITipoArteRepository
    {
        TipoArte Create(TipoArte usuario);
        TipoArte Get(long id);
        IQueryable<TipoArte> Get();
        void Put(TipoArte usuario);
        TipoArte Delete(long id);
    }
}
