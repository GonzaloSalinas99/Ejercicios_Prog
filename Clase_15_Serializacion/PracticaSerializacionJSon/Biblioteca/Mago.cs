using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mago : Personaje
    {
        private int puntoMana;

        public Mago()
        {
        }

        public Mago (int puntoVida,string nombre,int puntoMana)
        :base(puntoVida,nombre)
        {
            this.puntoMana = puntoMana;
        }

        public int PuntoMana
        {
            get { return this.puntoMana; }
            set { this.puntoMana = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {PuntoMana}";
        }

    }
}
