using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoArteServer
{
    public class Arte
    {
        public long Id { get; set; }
        public string TipoArte { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Pais { get; set; }
        public float Precio { get; set; }
    }
}