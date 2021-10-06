using System;

namespace Biblioteca
{
    public static class Calculadora
    {
        public static int Add (string numeros)
        {
            if (numeros == "")
            {
                return 0;
            }
            else
            {
                string[] array = numeros.Split(",");
                if (array.Length == 1)
                {
                    return int.Parse(array[0]);
                }
                else
                {
                    int retorno = 0;
                    for(int i=0;i<array.Length; i++)
                    {
                        retorno += int.Parse(array[i]);
                    }
                    return retorno;
                }
            }
            
            
            
        }

    }
}
