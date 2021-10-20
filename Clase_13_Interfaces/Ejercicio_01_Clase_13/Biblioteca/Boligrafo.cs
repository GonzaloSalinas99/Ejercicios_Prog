using System;
using System.Text;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        public Boligrafo(int unidades,ConsoleColor color)
        {
            Color = color;
            UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            char[] array = texto.ToCharArray();
            
            if(array.Length>0)
            {
                float cantidadCaracteres = array.Length;
                UnidadesDeEscritura= UnidadesDeEscritura - (float)(cantidadCaracteres * 0.3);
                EscrituraWrapper aux = new EscrituraWrapper(texto, Color);

                return aux; 
            }
            return null;
        }

        public bool Recargar(int unidades)
        {
            if(unidades>0)
            {
                UnidadesDeEscritura += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Boligrafo");
            sb.AppendLine($"Color: {((IAcciones)this).Color}");
            sb.AppendLine($"Nivel Tinta: {((IAcciones)this).UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
