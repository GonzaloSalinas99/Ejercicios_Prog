using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {
        }

        public long Sumar(long primerOperando, long segundoOperando)
        {
            this.cantidadSumas++;
            return primerOperando + segundoOperando;
        }

        public string Sumar(string primerOperando,string segundoOperando)
        {
            this.cantidadSumas++;
            return primerOperando + segundoOperando;
        }
            
        public static explicit operator int (Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator + (Sumador sumador1,Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }


        public static bool operator | (Sumador sumador1,Sumador sumador2)
        {
            return (sumador1.cantidadSumas == sumador2.cantidadSumas);
        }

    }
}
