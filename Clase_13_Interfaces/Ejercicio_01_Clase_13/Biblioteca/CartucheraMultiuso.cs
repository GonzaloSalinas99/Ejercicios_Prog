using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraMultiuso
    {
        private List<IAcciones> listaObjetos;

        public CartucheraMultiuso()
        {

            listaObjetos = new List<IAcciones>();
        }
        
        public IAcciones Agregar
        {
            set { 
                this.listaObjetos.Add(value); 
            }
        }

        public bool RecorrerElementos()
        {
            int contador = 0;
            if(listaObjetos.Count > 0)
            {
                foreach (IAcciones item in listaObjetos)
                {
                    if (item.UnidadesDeEscritura > 1)
                    {
                        item.UnidadesDeEscritura -= 1;
                    }
                    else
                    {
                        if (item.UnidadesDeEscritura <= 1)
                        {
                            item.UnidadesDeEscritura += 20;
                            item.UnidadesDeEscritura -= 1;
                        }
                    }
                    contador++;
                }
                if(contador == listaObjetos.Count)
                {
                    return true;
                }

            }
            return false;
        }


    }
}
