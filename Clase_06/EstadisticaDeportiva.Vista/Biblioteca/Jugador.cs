using System;
using System.Collections.Generic;

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
            return j.dni == j2.dni;
        }

        public static bool operator !=(Jugador j,Jugador j2)
        {
            return !(j.dni == j2.dni);
        }

        public string MostrarDatos()
        {
            return $"Nombre: {nombre}\n DNI: {dni}\n Goles: {totalGoles}\n P. Jugados: {partidosJugados}\n Prom. Goles {GetPromedioGoles()}";
        }

    }

    
}
