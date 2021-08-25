using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            /* Console.WriteLine("Ingresa numero");
             numero = double.Parse(Console.ReadLine());
            */
            bool respuesta;

            respuesta = int.TryParse(Console.ReadLine(), out numero);
            
            if (respuesta==true)
            {
                if(numero>0)
                {
                    Console.WriteLine(Math.Pow(numero, 3));
                    Console.WriteLine(Math.Pow(numero, 2));

                }
                else
                {
                    Console.WriteLine("ERROR el numero debe ser mayor a 0");
                }
            }
            else
            {
                Console.WriteLine("No ha ingresado ningun numero");
            }
            
        }
    }
}
