using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }


        private float CalcularGanancias(TipoLlamada tipoLlamada)
        {
            float retorno;
            if(tipoLlamada == TipoLlamada.Local)
            {
                retorno =
            }
        }
    }
}
