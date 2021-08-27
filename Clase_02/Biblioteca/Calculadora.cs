using System;

namespace Biblioteca
{
    public class Calculadora
    {
        static int resultado;
        public static int Calcular(int primerOperando, int segundoOperando,char operacion)
        {
            switch(operacion)
            {
                case '+':
                        resultado = primerOperando + segundoOperando;
                    break;

                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;

                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;

                case '/':
                    if(Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    break;
                
            }
            return resultado;
        }

        private static bool Validar(int segundoOperando)
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
