using System;
using Biblioteca;
namespace ConsultaIndice
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libros = new Libro();

            libros[0] = "HOLA";
            libros[1] = "Juan";
            libros[2] = "Carlos";
            libros[3] = "Como";
            libros[4] = "estas";
            libros[5] = "Chupa";
            libros[6] = "Pija";

            Console.WriteLine(libros[3]);
        }
    }
}
