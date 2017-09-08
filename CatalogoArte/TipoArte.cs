using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoArteServer
{
    public class TipoArte
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public bool Tangible { get; set; }
        public DateTime FechaIni { get; set; }
        public string Composicion { get; set; }
        public bool Colectivo { get; set; }
        
    }
}