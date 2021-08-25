using System;
using Biblioteca;
namespace Ejercicio_03_Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa numero");
            int numero;
            numero = int.Parse(Console.ReadLine());
            string numeroBinario;
            numeroBinario = Conversor.ConvertirDecimalABinario(numero)    ;
            Console.WriteLine(numeroBinario);
        }
    }
}
