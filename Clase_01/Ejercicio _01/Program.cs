using System;

namespace Ejercicio_01

{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max=int.MinValue;
            int min = int.MinValue;
            int acumulador = 0;
            //int promedio;

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("ingresa numero");
                numero = int.Parse(Console.ReadLine());
            
                if(i==0)
                {
                    min = numero;
                    max = numero;
                }

                if(max<numero)
                {
                    max = numero;
                }
                
                if(min>numero)
                {
                    min = numero;
                }

                acumulador += numero;
                
            }

            Console.WriteLine("El n max es {0} y el minimo es {1}",max,min);
            Console.WriteLine("Promedio es {0}",acumulador/5);

        }
    }
}
