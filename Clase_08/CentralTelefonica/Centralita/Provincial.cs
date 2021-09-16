using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public enum Franja
    { 
        Franja_1,
        Franja_2,
        Franja_3
    }


    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;
        
        public Provincial(Llamada llamada,Franja miFranja)
            :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja,float duracion,string origen,string destino)
        :this(new Llamada(duracion,destino,origen),miFranja)
        {
        }

        private float CalcularCosto()
        {
            float retorno;
            if(this.franjaHoraria == Franja.Franja_1)
            {
                retorno = 0.99f * this.duracion;
            }
            else if(this.franjaHoraria == Franja.Franja_2)
            {
                retorno = 1.25f * this.duracion;
            }
            else
            {
                retorno = 0.66f * this.duracion;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja Horaria: {franjaHoraria}");
            sb.AppendLine($"Costo Llamada: {CalcularCosto()}");

            return sb.ToString();
        }



    }
}
