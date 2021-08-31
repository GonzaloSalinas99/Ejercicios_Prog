using System;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public string GetFechaNacimiento()
        {
            return fechaNacimiento.ToLongDateString();
        }

        public string GetDni()
        {
            return dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        public int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime today = DateTime.Today;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }

        public string Mostrar()
        {
            return $"Nombre: {GetNombre()} Dni: {GetDni()} Edad: {CalcularEdad(fechaNacimiento)}";
        }

        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad(fechaNacimiento);
            if(edad>17)
            {
                return "Es mayor de edad";
            }
            return "Es menor de edad";
        }
    }
}
