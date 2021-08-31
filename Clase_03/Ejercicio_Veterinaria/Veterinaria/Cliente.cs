using System;

namespace Veterinaria
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private int telefono;
       

        public Cliente(string domicilio, string nombre, string apellido, int telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public string GetDomicilio()
        {
            return this.domicilio;
        }
        public int GetTelefono()
        {
            return this.telefono;
        }

        public string Mostrar()
        {
            return $"Nombre: {GetNombre()} Apellido: {GetApellido()} Telefono: {GetTelefono()} Domicilio: {GetDomicilio()}";
        }


        //public bool ValidadNombre(string nombreAValidar)
        //{
        //    if(this.GetNombre() == nombreAValidar)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        
    }
}
