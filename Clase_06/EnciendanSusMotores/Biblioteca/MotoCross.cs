using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Motocross : VehiculoDeCarrera
    {
        private short cilindrada;

        public Motocross(short numero,string escuderia):base (numero,escuderia)
        {
        }
        public Motocross(short numero,string escuderia,short cilindrada):this (numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public static bool operator == (Motocross a1,Motocross a2)
        {
            if((a1 == a2) && a1.Cilindrada == a2.Cilindrada)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Motocross a1, Motocross a2)
        {
            return !(a1 == a2);
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {Cilindrada}");

            return sb.ToString();
        }

    }
}
