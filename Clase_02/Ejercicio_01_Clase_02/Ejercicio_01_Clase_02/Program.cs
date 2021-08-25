using System;
using Validar;
namespace Ejercicio_01_Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
         
            bool respuesta;
            int numeroIngresado;
            int acumuladorNumeros = 0;

            int numMin=0;
            int numMax=0;

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Ingrese un numero");
                respuesta = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if(respuesta==true)
                {
                    
                    if(Validador.Validar(numeroIngresado, -100, 100))
                    {
                        if(i==0)
                        {
                            numMax = numeroIngresado;
                            numMin = numeroIngresado;
                        }

                        if(numMax<numeroIngresado)
                        {
                            numMax = numeroIngresado;
                        }
                        else if(numMin>numeroIngresado)
                        {
                            numMin = numeroIngresado;
                        }

                        acumuladorNumeros += numeroIngresado;
                    }
                    else
                    {
                        Console.WriteLine("No ingresaste un numero");
                        i--;
                    }

                }
            }
            Console.WriteLine("El numero maximo ingresado es {0} \n El numero minimo ingresado es {1} \n El promedio de los numeros ingresados es {2}/{3} = {4}",numMax,numMin,acumuladorNumeros,10,acumuladorNumeros/10);
        }
    }
}
