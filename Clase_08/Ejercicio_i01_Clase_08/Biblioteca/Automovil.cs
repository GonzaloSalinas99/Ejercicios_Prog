using System;

namespace Biblioteca
{
    public enum  Colores
    { 
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }

    public class Automovil:VehiculoTerrestre
    {
        protected short cantidadMarchas;
        protected int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, 
            Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string MostrarAuto()
        {
            return $"{this.MostrarVehiculo()}--Cant. Marchas: {cantidadMarchas}--Cant. Pasajeros: {cantidadPasajeros}";
        }

    }
}
