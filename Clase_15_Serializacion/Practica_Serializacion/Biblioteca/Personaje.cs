using System;
using System.Xml.Serialization;
namespace Biblioteca
{
    [XmlInclude(typeof(Mago))]
    public class Personaje
    {
        private int puntosDeVida;
        private string nombre;

        public Personaje()
        {
        }

        public Personaje(int puntosDeVida, string nombre)
        {
            this.puntosDeVida = puntosDeVida;
            this.nombre = nombre;
        }

        public int PuntosDeVida
        {
            get { return puntosDeVida; }
            set { puntosDeVida = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return $"{Nombre} - {PuntosDeVida} puntos de vida.";
        }
    }
}
