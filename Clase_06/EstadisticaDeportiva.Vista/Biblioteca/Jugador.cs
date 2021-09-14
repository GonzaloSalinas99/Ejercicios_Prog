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

        public float GetPromedioGoles()
        {   
            this.promedioGoles= totalGoles / (float)partidosJugados;
            return promedioGoles;
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
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Dni: {dni}");
            sb.AppendLine($"P. Jugados: {partidosJugados}");
            sb.AppendLine($"Total Goles: {totalGoles}");
            sb.AppendLine($"Prom. Goles: {GetPromedioGoles()}");
            sb.AppendLine("--------------------");

            return sb.ToString();
                
        }

    }

    
}
