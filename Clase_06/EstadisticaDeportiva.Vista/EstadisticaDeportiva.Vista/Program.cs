using System;
using Biblioteca;
namespace EstadisticaDeportiva.Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "Barcelona");
            Jugador j1 = new Jugador(123, "Gonzalo", 5, 20);
            Jugador j2 = new Jugador(485, "Facundo", 3, 5);
            Jugador j3 = new Jugador(123, "Franco", 7, 3);
            Jugador j4 = new Jugador(789, "Quimey", 3, 5);

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
            {
                Console.WriteLine(j3.MostrarDatos());

            }
            else
            {
                Console.WriteLine("\n----- \nNO SE AGREGO\n------ \n" + j3.MostrarDatos());
            }
            if (equipo + j4)
            {
                Console.WriteLine(j4.MostrarDatos());

            }
            else
            {
                Console.WriteLine("\n----- \nNO SE AGREGO\n------ \n" + j4.MostrarDatos());
            }
        }
    }
}
