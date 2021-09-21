using System;
using System.Collections.Generic;
using Biblioteca;
namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(2));
            figuras.Add(new Cuadrado(6));
            figuras.Add(new Rectangulo(3,6));

            foreach (Figura figura in figuras)
            {
                int contador = 0;
                Console.WriteLine($"------Figura {contador++}-------");
                Console.WriteLine($"Tipo : {figura.GetType()}");
                Console.WriteLine($"{figura.Dibujar()}");
                Console.WriteLine($"Area: {figura.CalcularSuperficie()}");
                Console.WriteLine($"Perimetro: {figura.CalcularPerimetro()}");
                Console.WriteLine($"----------------------------------\n\n");
            }


        }
    }
}
