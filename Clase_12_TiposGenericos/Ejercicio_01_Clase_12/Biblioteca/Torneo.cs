using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        public string nombre;
        public Equipo algo;


        public Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(T equipoAValidar, Torneo<T> torneo)
        {
            foreach (T equipo in torneo.equipos)
            {
                if (equipo == equipoAValidar)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(T equipoAValidar, Torneo<T> listaEquipos)
        {
            return !(equipoAValidar == listaEquipos);
        }

        public static bool operator +(Torneo<T> torneo,T equipoAAgregar)
        {
                torneo.equipos.Add((T)equipoAAgregar);
            return true;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del torneo: {nombre}");
            foreach (T equipos in equipos)
            {
                sb.AppendLine(equipos.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();
            return $"{equipo1.nombre} {random.Next(0, 10)} - {equipo2.nombre} {random.Next(0, 10)}";
        }

        public string JugarPartido
        {
            get
            {
                if (equipos.Count > 1)
                {
                    Random num = new Random();

                    int index1;
                    int index2;
                    do
                    {
                        index1 = num.Next(0, equipos.Count);
                        index2 = num.Next(0, equipos.Count);
                    } while (index1 == index2);

                    return CalcularPartido(equipos[index1], equipos[index2]);

                }
                else
                {
                    return "No se pudo realizar el partido";
                }
            }

        }


    }
}
