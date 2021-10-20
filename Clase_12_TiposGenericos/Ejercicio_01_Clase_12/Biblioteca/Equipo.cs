using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            if (equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }

        public string Ficha()
        {
            return $"{nombre} fundado el {fechaCreacion.ToString("dd/M/yy")}.";
        }

    }
}
