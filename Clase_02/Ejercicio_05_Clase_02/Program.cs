using System;

namespace Ejercicio_05_Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUsuario;

            Console.WriteLine("Ingresame un numero:");
            numeroUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuantas veces se tiene que multiplicar??");
            int vecesAMultiplicar = int.Parse(Console.ReadLine());
            int multiplicacion = 1;
            int resultado;
            

            while(multiplicacion<=vecesAMultiplicar)
            {
                resultado = multiplicacion * numeroUsuario;
                Console.WriteLine($"{numeroUsuario} * {multiplicacion} = {resultado}");

                multiplicacion++;
            }
        }



    }
}

//Crear una aplicación de consola que permita al usuario ingresar un número entero.

//Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

//Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

//Mostrar en la consola el resultado.