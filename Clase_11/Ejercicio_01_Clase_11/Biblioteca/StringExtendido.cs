using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class StringExtendido
    {

        public static int  ContarPalabras(this string str)
        {
            return str.Split(" ",StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
