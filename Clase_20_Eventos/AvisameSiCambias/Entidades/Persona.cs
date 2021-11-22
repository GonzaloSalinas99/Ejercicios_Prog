using System;

namespace Entidades
{
    public delegate void DelegadoString (string msg);


    public class Persona
    {
        private string nombre;
        private string apellido;


        public string Nombre
        {
            get { return nombre; }
            set 
            {
                nombre = value;
                EventoString.Invoke(nombre);
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set 
            { 
                apellido = value;
                EventoString.Invoke(apellido);
            }
        }

        public Persona()
        {
        }

        public string Mostrar()
        {
            return $"{Nombre} {Apellido}";
        }

        public event DelegadoString EventoString;

    }
}
