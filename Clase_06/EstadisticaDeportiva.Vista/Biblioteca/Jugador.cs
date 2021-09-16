using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private float promedioGoles;

        private Jugador()
        {
            partidosJugados = 0;
            totalGoles = 0;
            promedioGoles = 0;
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        public float PromedioGoles
        {
            get
            {
                this.promedioGoles = totalGoles / (float)partidosJugados;
                return promedioGoles;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set 
            { 
                if(value is not null)
                {
                    this.nombre = value;
                }
            }
        }

        public int Dni
        {
            get { return this.dni; }
            set
            {
                if (value>0)
                {
                    this.dni = value;
                }
            }
        }

        public Jugador(int dni,string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos):this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }


        public static bool operator ==(Jugador j , Jugador j2)
        {
            if(j.dni == j2.dni)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator !=(Jugador j,Jugador j2)
        {
            return !(j.dni == j2.dni);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nDetalles del jugador");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"P. Jugados: {PartidosJugados}");
            sb.AppendLine($"Total Goles: {TotalGoles}");
            sb.AppendLine($"Prom. Goles: {PromedioGoles}");
            sb.AppendLine("--------------------");

            return sb.ToString();
                
        }

    }

    
}
