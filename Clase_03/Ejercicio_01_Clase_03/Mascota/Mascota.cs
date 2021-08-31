using System;
using Veterinaria;
namespace Veterinaria
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;

        public Mascota(string nombre, DateTime fechaNacimiento,string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetFechaNacimiento()
        {
            return fechaNacimiento.ToShortDateString();
        }

        public string GetEspecie()
        {
            return especie;
        }


    }
}
