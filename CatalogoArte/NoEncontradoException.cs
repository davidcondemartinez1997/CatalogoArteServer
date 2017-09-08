using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoArteServer
{
    public class NoEncontradoException : Exception
    {
        public NoEncontradoException() : base()
        {

        }

        public NoEncontradoException(String Arte) : base(Arte)
        {

        }

        public NoEncontradoException(String Arte, Exception innerException) : base(Arte, innerException)
        {

        }
    }
}