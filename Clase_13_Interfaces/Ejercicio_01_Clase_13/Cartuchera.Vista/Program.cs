using System;
using Biblioteca;
namespace Cartuchera.Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            Boligrafo b1 = new Boligrafo(13, ConsoleColor.Red);
            Boligrafo b2 = new Boligrafo(11, ConsoleColor.Green);
            Boligrafo b3 = new Boligrafo(12, ConsoleColor.Yellow);
            Boligrafo b5 = new Boligrafo(20, ConsoleColor.Blue);
            Boligrafo b6 = new Boligrafo(1, ConsoleColor.Cyan);
            Boligrafo b7 = new Boligrafo(0, ConsoleColor.DarkRed);
            Boligrafo b4 = new Boligrafo(23, ConsoleColor.Magenta);

            Lapiz l1 = new Lapiz(20);
            Lapiz l2 = new Lapiz(10);
            Lapiz l3 = new Lapiz(9);
            Lapiz l4 = new Lapiz(3);
            Lapiz l5 = new Lapiz(1);
            Lapiz l6 = new Lapiz(0);
            Lapiz l7 = new Lapiz(13);
            Lapiz l8 = new Lapiz(6);

            CartucheraMultiuso cartuMulti = new CartucheraMultiuso();
            CartucheraSimple cartuSimple = new CartucheraSimple();

            cartuMulti.Agregar = l1;
            cartuMulti.Agregar = l2;
            cartuMulti.Agregar = l3;
            cartuMulti.Agregar = b1;
            cartuMulti.Agregar = b2;
            cartuMulti.Agregar = b3;

            cartuSimple.Boligrafo = b4;
            cartuSimple.Boligrafo = b5;
            cartuSimple.Boligrafo = b6;
            cartuSimple.Boligrafo = b7;
            cartuSimple.Lapiz = l4;
            cartuSimple.Lapiz = l5;
            cartuSimple.Lapiz = l6;



            Console.WriteLine(cartuSimple.RecorrerElementos());
            Console.WriteLine(cartuMulti.RecorrerElementos());


            //EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            //Console.ForegroundColor = eLapiz.color;
            //Console.WriteLine(eLapiz.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miLapiz);

            //EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            //Console.ForegroundColor = eBoligrafo.color;
            //Console.WriteLine(eBoligrafo.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miBoligrafo);

            //Console.ReadKey();
        }
    }
}
