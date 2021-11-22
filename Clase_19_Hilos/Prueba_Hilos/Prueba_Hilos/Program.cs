using System;
using System.Threading;

namespace Prueba_Hilos
{
    //private static Random random;
    class Program
    {
        private static Random random;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }


        public static void EjercutarTarea(string codigo)
        {

            int random = new Random().Next(1000, 3000);
            Thread.Sleep(random);
            Console.WriteLine($"Ejecutando Tarea : {codigo} en un tiempo de: {random}");
        }

    }

    
}
