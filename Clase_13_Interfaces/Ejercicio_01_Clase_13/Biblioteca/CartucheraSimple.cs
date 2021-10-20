using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CartucheraSimple
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public Boligrafo Boligrafo
        {
            set { this.boligrafos.Add(value); }
        }

        public Lapiz Lapiz
        {
            set { this.lapices.Add(value); }
        }
        public CartucheraSimple()
        {
            boligrafos = new List<Boligrafo>();
            lapices = new List<Lapiz>();
        }


        public bool RecorrerElementos()
        {
            
            if(boligrafos.Count >0 && lapices.Count >0)
            {
                int contadorLapices = 0;
                int contadorBoligrafos = 0;
                foreach (Boligrafo boligrafo in boligrafos)
                {
                    if(boligrafo.UnidadesDeEscritura >1)
                    {
                        boligrafo.UnidadesDeEscritura -= 1;
                    }
                    else
                    {
                        if(boligrafo.UnidadesDeEscritura <=1 )
                        {
                            boligrafo.UnidadesDeEscritura += 20;
                            boligrafo.UnidadesDeEscritura -= 1;
                        }
                    }
                    contadorBoligrafos++;
                }
                foreach (Lapiz lapiz in lapices)
                {
                    if (((IAcciones)lapiz).UnidadesDeEscritura > 1)
                    {
                        ((IAcciones)lapiz).UnidadesDeEscritura -= 1;
                    }
                    else
                    {
                        if (((IAcciones)lapiz).UnidadesDeEscritura <=1)
                        {
                            ((IAcciones)lapiz).UnidadesDeEscritura += 20;
                            ((IAcciones)lapiz).UnidadesDeEscritura -= 1;
                        }
                    }
                    contadorLapices++;
                }
                
                
                if(contadorBoligrafos == boligrafos.Count && contadorLapices == lapices.Count)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
