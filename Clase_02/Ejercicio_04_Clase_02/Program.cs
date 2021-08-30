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
            StringBuilder primerNumero = new StringBuilder();
            StringBuilder segundoNumero = new StringBuilder();

            textoError.AppendLine("No se pudo realizar la operacion");
            TextoUsuario.AppendLine("Desea seguir ingresando numeros?  Si - No");
            textoMenu.AppendLine("Bienvenido a la Calculadora. Por favor ingrese dos numeros para hacer los calculos");
            primerNumero.AppendLine("Ingrese el primer numero a calcular");
            segundoNumero.AppendLine("\nIngrese el segundo numero a calcular");
            textoCalculo.AppendLine("Ingrese el signo (+) si desea sumar\n" +
                                     "Ingrese el signo (-) si desea restar\n" +
                                     "Ingrese el signo (*) si desea multiplicar\n" +
                                     "Ingrese el sino (/) si desea dividir\n" +
                                     "Su respuesta:");

            decimal primerOperando;
            decimal segundoOperando;
            string calculoARealizar;
            decimal resultado;

            string respuestaUsuario;

            do
            {
                Console.WriteLine(textoMenu);
                Console.WriteLine(primerNumero);
                primerOperando = decimal.Parse(Console.ReadLine());
                Console.WriteLine(segundoNumero);
                segundoOperando = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Usted ingresó {0} y {1}", primerOperando, segundoOperando);

                Console.WriteLine(textoCalculo);
                calculoARealizar = Console.ReadLine();
                resultado = Calculadora.Calcular(primerOperando, segundoOperando, calculoARealizar,textoError);

                Console.WriteLine($"El calculo que se realizo es {primerOperando} {calculoARealizar} {segundoOperando} y el resultado es {resultado}");

                Console.WriteLine(TextoUsuario);
                respuestaUsuario = Console.ReadLine();
            } while (respuestaUsuario == "si");

        }
    }
}
