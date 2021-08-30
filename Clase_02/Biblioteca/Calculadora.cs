using System;
using System.Text;

namespace Biblioteca
{
    public class Calculadora
    {
        static decimal resultado;
        public static decimal Calcular(decimal primerOperando, decimal segundoOperando,string operacion,StringBuilder mensajeError)
        {
            switch(operacion)
            {
                case "+":
                        resultado = primerOperando + segundoOperando;
                    break;

                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;

                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;

                case "/":
                    if(Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine(mensajeError);
                    }
                    break;
                
            }
            return resultado;
        }

        private static bool Validar(decimal segundoOperando)
        {
            bool respuesta=true;
            if (segundoOperando == 0)
            { 
                respuesta = false;
            }
            return respuesta;
        }


    }
}
