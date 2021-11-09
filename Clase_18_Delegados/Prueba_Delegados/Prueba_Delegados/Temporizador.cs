using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prueba_Delegados
{
    public class Temporizador
    {

        public static void Esperar(int milisegundos, DelegadoSaludar delegado)
        {
            Thread.Sleep(milisegundos);
            delegado();
        }

        public static void EsperarMilisegundos(int milisegundos,DelegadoConInt delegado)
        {
            Thread.Sleep(milisegundos);
            delegado(milisegundos);
        }

    }
}
