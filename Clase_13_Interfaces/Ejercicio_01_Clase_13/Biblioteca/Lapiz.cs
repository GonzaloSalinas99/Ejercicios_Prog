using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

         ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura 
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }
        public EscrituraWrapper Escribir(string texto)
        {
            if(texto is not null || texto !="")
            {
                char[] array = texto.ToCharArray();
                if(array.Length > 0)
                {
                    int cantidadCaracteres = array.Length;
                    ((IAcciones)this).UnidadesDeEscritura -= (float)(cantidadCaracteres * 0.1);
                    EscrituraWrapper aux = new EscrituraWrapper(texto, ((IAcciones)this).Color);
                    return aux;
                }
            }
            return null;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Lapiz");
            sb.AppendLine($"Color: {((IAcciones)this).Color}");
            sb.AppendLine($"Nivel Tinta: {((IAcciones)this).UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
