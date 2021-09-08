using System;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private string genero;
        private int edad;
        private string nombre;
        private string pais;

        public Ingresante(string[] cursos, string direccion, string genero, int edad, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.genero = genero;
            this.edad = edad;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            return $"Nombre: {nombre}\nDireccion: {direccion}\nEdad: {edad}\nGenero: {genero}\nPais: {pais}\nCurso/s: {cursos}";
        }

        public static bool setNombre(string nombre)
        {
            if(String.IsNullOrWhiteSpace(nombre))
            {
                return true;
            }
            return false;
        }

        public static bool setDireccion(string direccion)
        {
            if (String.IsNullOrWhiteSpace(direccion))
            {
                return true;
            }
            return false;
        }

        public static bool setPais(string pais)
        {
            if (String.IsNullOrWhiteSpace(pais))
            {
                return true;
            }
            return false;
        }

        public static bool setGenero(string genero)
        {
            if (String.IsNullOrWhiteSpace(genero))
            {
                return true;
            }
            return false;
        }

        public static bool setCursos(string[] cursos)
        {
            for(int i=0;i<cursos.Length;i++)
            {
                if (String.IsNullOrWhiteSpace(cursos[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool setEdad(string edad)
        {
            if (String.IsNullOrWhiteSpace(edad))
            {
                return true;
            }
            return false;
        }
    }
}
