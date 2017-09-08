﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoArteServer.Repository
{
    public interface IArteRepository
    {
        Arte Create(Arte Arte);
        Arte Get(long id);
        IQueryable<Arte> Get();
        void Put(Arte Arte);
        Arte Delete(long id);
    }
}
