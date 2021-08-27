using System;
using Biblioteca;
using System.Text;
namespace Ejercicio_04_Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder textoMenu = new StringBuilder();
            StringBuilder textoCalculo = new StringBuilder();
            StringBuilder textoError = new StringBuilder();
            StringBuilder TextoUsuario = new StringBuilder();

            TextoUsuario.AppendLine("Desea seguir ingresando numeros?");
            textoMenu.AppendLine("Bienvenido a la Calculadora. Por favor ingrese dos numeros para hacer los calculos");
            textoCalculo.AppendLine("Ingrese el signo (+) si desea sumar\n" +
                                     "Ingrese el signo (-) si desea restar\n" +
                                     "Ingrese el signo (*) si desea multiplicar\n" +
                                     "Ingrese el sino (/) si desea dividir\n" +
                                     "Su respuesta:");




            bool primerNumero;
            bool segundoNumero;

            decimal primeroOperando;
            decimal segundoOperando;

            string respuestaUsuario;

            do
            {




                Console.WriteLine(TextoUsuario);
                respuestaUsuario = Console.ReadLine();
            } while (respuestaUsuario == "si");

        }
    }
}


//Realizar un programa que permita realizar operaciones matemáticas simples
//(suma, resta, multiplicación y división).

//Crear una clase llamada Calculadora que posea dos métodos estáticos
//(de clase):

//Calcular(público): Recibirá tres parámetros, el primer operando,
//el segundo operando y la operación matemática. El método devolverá el
//resultado de la operación.

//Validar (privado): Recibirá como parámetro el segundo operando.
//Este método se debe utilizar sólo cuando la operación elegida sea
//la DIVISIÓN. Este método devolverá true si el operando es distinto
//de cero.

//Se le debe pedir al usuario que ingrese dos números y la operación
//que desea realizar (ingresando el caracter +, -, * o /).

//El usuario decidirá cuándo finalizar el programa.