using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mago : Personaje
    {
        private int puntosDeMana;

        public Mago()
        {
        }

        public Mago(int puntosDeVida,string nombre,int puntosDeMana)
        :base(puntosDeVida,nombre)
        {
            this.puntosDeMana = puntosDeMana;
        }

        public int PuntosDeMana
        {
            get { return this.puntosDeMana; }
            set { this.puntosDeMana = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {PuntosDeMana} puntos de Mana ";
        }
    }
}
