using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    public enum Puesto
    {
        Caja1,
        Caja2
    }
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get { return numeroActual++; }
        }


        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion (Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cliente)
        {
            if(cliente is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
