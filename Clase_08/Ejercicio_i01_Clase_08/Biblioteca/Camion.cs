using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion:VehiculoTerrestre
    {
        
        protected short cantidadMarchas;
        protected int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, 
            Colores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string MostrarCamion()
        {
            return $"{this.MostrarVehiculo()}--Cant. Marchas: {cantidadMarchas}--Peso de Carga: {pesoCarga}";
        }
    }
}
