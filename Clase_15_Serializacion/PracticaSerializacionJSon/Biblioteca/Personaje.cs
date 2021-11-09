using System;

namespace Biblioteca
{
    public class Personaje
    {
        private int puntoVida;
        private string nombre;

        public Personaje()
        {
        }

        public Personaje(int puntoVida,string nombre)
        {
            this.puntoVida = puntoVida;
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int PuntoVida
        {
            get { return this.puntoVida; }
            set { this.puntoVida = value; }
        }


        public override string ToString()
        {
            return $"{Nombre} - {PuntoVida}";
        }
    }
}
