﻿using System;
using System.Text;

namespace Centralita
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }


    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion Llamada: {Duracion}");
            sb.AppendLine($"Numero Destino: {nroDestino}");
            sb.AppendLine($"Numero Origen: {nroOrigen}");
            
            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1 , Llamada llamada2)
        {
            int retorno = 0;
            if(llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if(llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }
            return retorno;
        }


    }
}
