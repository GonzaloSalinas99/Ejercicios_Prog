using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballoDeFuerza;

        public AutoF1(short numero,string escuderia):base(numero,escuderia)
        {
        }
        public AutoF1(short numero, string escuderia,short caballoDeFuerza) : this(numero, escuderia)
        {
            CaballoDeFuerza = caballoDeFuerza;
        }


        public static bool operator ==(AutoF1 primerAuto, AutoF1 segundoAuto)
        {

            if ((primerAuto == segundoAuto) && primerAuto.caballoDeFuerza == segundoAuto.caballoDeFuerza)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 primerAuto, AutoF1 segundoAuto)
        {
            return (!(primerAuto == segundoAuto));
        }

        


        public short CaballoDeFuerza
        {
            get { return this.caballoDeFuerza; }
            set { this.caballoDeFuerza = value; }
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {CaballoDeFuerza}");

            return sb.ToString();
        }


    }
} 

