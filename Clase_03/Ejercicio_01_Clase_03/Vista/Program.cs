using System;
using Veterinaria;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota[] mascotas = new Mascota[2];
            Mascota gato = new Mascota("Kitty", new DateTime(2013, 04, 13), "gato");
            Mascota perrito = new Mascota("Rinti", new DateTime(1965, 11, 6), "perro");

            mascotas[0] = new Mascota("Kitty", new DateTime(2013, 04, 13), "gato");
            mascotas[1] = new Mascota("Rinti", new DateTime(1965, 11, 6), "perro");
            foreach (Mascota mascota in mascotas)
            {
                Console.WriteLine($"{mascota.GetNombre()} {mascota.GetFechaNacimiento()}");
            }
            
        }
    }
}
