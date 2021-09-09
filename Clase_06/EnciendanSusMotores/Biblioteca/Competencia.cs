using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public static bool operator + (Competencia c , AutoF1 a)
        {

            if (c.competidores.Count < c.cantidadCompetidores)
            {
                if(c!=a)
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

        public static bool operator == (Competencia c , AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
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
