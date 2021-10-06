using System;

namespace Biblioteca
{
    public static class Int32Extendido
    {
        public static string FizzBuzz(this Int32 numero)
        {
            string retorno = null;
            if(numero%3 == 0 && numero%5 == 0)
            {
                retorno = "FizzBuzz";
            }
            else
            {
                if (numero % 3 == 0)
                {
                    retorno = "Fizz";
                }
                else
                {
                    if (numero % 5 == 0)
                    {
                        retorno = "Buzz";
                    }
                    else
                    {
                        retorno = numero.ToString();
                    }
                }
            }
            return retorno;
        }


    }
}
