using System;
using Biblioteca;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(4);
            long sumaLong = sumador.Sumar(21, 32);
            Console.WriteLine(sumaLong);

            string sumaString = sumador.Sumar("Hola", "Mundo");
            Console.WriteLine(sumaString);

            int numeroDeCantidadDeSumas = (int)sumador;
            Console.WriteLine(numeroDeCantidadDeSumas);

            Console.WriteLine(sumador+sumador2);
            Console.WriteLine(sumador | sumador2);

        }
    }
}
