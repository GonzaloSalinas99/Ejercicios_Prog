using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public enum TipoCompetencia
    {
        F1,MotoCross
    }
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipoCompetencia;
        

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas,TipoCompetencia tipoCompetencia):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            
        }
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipoCompetencia; }
            set { this.tipoCompetencia = value; }
        }

        public VehiculoDeCarrera this [int i]
        {
            get { return competidores[i]; }
            set { competidores[i] = value; }
        }

        public static bool operator + (Competencia c , VehiculoDeCarrera v)
        {

            if (c.competidores.Count < c.cantidadCompetidores)
            {
                if(c!=v)
                {
                    Random random = new Random();
                    a.SetEstadoCompetencia(true);
                    a.SetVueltasRestantes(c.cantidadVueltas);
                    a.SetCantidadCombustible((short)random.Next(15, 100));
                    c.competidores.Add(a);
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool operator == (Competencia c , VehiculoDeCarrera v)
        {
            Motocross motoAux;
            if(c.Tipo == TipoCompetencia.MotoCross &&   v.GetType() == motoAux.GetType())
            {
                
            }
            else
            {

            }
            foreach (VehiculoDeCarrera item in c.competidores)
            {
                if (item == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c , AutoF1 a)
        {
            return (!(c == a));
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------COMPETENCIA------------");
            sb.AppendLine($"Cantidad de corredores: {cantidadCompetidores}");
            foreach (AutoF1 a in this.competidores)
            {
                sb.AppendLine("--------");
                sb.AppendLine(a.MostrarDatos());
                sb.AppendLine("--------");
                    }
            sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");

            return sb.ToString();
        }


    }
}
