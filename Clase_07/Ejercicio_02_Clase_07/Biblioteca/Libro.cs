using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas;

        public string this [int index]
        {
            get 
            { 
                if(index < paginas.Count  && paginas[index] is not null)
                {
                    return paginas[index];
                }
                else
                {
                    return String.Empty;
                }
            }
            set 
            {
                if (index < paginas.Count)
                {
                    paginas[index] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }

    }
}
