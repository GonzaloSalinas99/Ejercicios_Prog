using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta nuevaCuenta = new Cuenta("Gonzalo",365478);
            Console.WriteLine($"{nuevaCuenta.Mostrar()}");
            if(nuevaCuenta.Ingresar(-23146)==false)
            {
                Console.WriteLine("Hubo un error");
            }
            Console.WriteLine($"{nuevaCuenta.Mostrar()}");
            nuevaCuenta.Retirar(388624);
            Console.WriteLine($"{nuevaCuenta.Mostrar()}");
        }
    }
}
