using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} - Apellido: {this.apellido}";
        }
    }
}
