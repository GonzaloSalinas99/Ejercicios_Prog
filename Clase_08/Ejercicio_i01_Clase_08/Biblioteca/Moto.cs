using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {

        protected short cilindrada;

        public Moto(short cantidadRuedas, 
            Colores color, short cilindrada):base(cantidadRuedas,0,color)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            return $"{this.MostrarVehiculo()}--Cilindrada: {cilindrada}";
        }
    }
}
