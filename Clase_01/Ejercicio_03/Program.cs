using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool respuesta;
            string respuestaUsuario;
            int contadorDivisores= 0;

            do
            { 
                Console.WriteLine("Ingrese un numero para calcular sus numeros primos");
                respuesta = int.TryParse(Console.ReadLine(), out numero);
                if (respuesta == true)
                {
                    if (numero > 1)
                    {
                        for (int i = 1; i <= numero; i++)
                        {

                            if (numero % i == 0)
                            { 
                                contadorDivisores++;
                            }
                        }
                        if (contadorDivisores > 2 || numero <= 1)
                        {
                            Console.WriteLine("Este numero no es primo");
                        }
                        else
                        {
                            Console.WriteLine("Este numero es primo");
                        }
                    }
                    Console.WriteLine("Es un numero primo {0} y tiene {1} numero primos", numero, contadorDivisores);
                }
                else
                {
                    Console.WriteLine("Error, no ingresaste un numero");
                }

                Console.WriteLine("Desea ingresar otro numero? si - no");
                respuestaUsuario = Console.ReadLine();
            } while (respuestaUsuario == "si");
                 
        }
    }
}
//Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

//Validar que el dato ingresado por el usuario sea un número.

//Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

//Si ingresa "salir", cerrar la consola.

//Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.