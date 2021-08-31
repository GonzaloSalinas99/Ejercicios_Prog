using System;
using Biblioteca;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Gonzalo", new DateTime(1999, 12, 27), "42038608");
            Persona p2 = new Persona("Eliana", new DateTime(1997, 12, 29), "40488608");
            Persona p3 = new Persona("Ana", new DateTime(1963, 04, 29), "16519917");

            Console.WriteLine(p1.Mostrar());
            Console.WriteLine(p2.Mostrar());
            Console.WriteLine(p3.Mostrar());

            Console.WriteLine(p1.EsMayorDeEdad());
            Console.WriteLine(p2.EsMayorDeEdad());
            Console.WriteLine(p3.EsMayorDeEdad());
        }
    }
}
