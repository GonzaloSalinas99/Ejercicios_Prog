using System;
using Biblioteca;
namespace Vista
{
    class Program
    {
        private static float temp1;
        private static float temp2;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           temp1=ConversorDeTemperatura.ConvertirCelsiusAKelvin(14.6f);
           temp2= ConversorDeTemperatura.ConvertirKelvinACelsius(263.6f);

            MostrarTemperaturas();
        }

        static void MostrarTemperaturas()
        {
            Console.WriteLine("{0} grados Kelvin",temp1);
            Console.WriteLine("{0}ºC grados ",temp2);
        }
    }
}
