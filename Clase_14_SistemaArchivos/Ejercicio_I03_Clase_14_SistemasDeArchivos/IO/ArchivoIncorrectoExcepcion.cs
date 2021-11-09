using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ArchivoIncorrectoExcepcion : Exception
    {
        public ArchivoIncorrectoExcepcion(string mensaje):base(mensaje,null)
        {
        }
        public ArchivoIncorrectoExcepcion (string mensaje,Exception exception):base(mensaje,exception)
        {
        }

    }
}
