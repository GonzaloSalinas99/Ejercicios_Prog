using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Veterinaria
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaNacimiento;
        private string libretaVacunacion;
        //Cliente cliente;
        private string nombreCliente;
        public Mascota(string nombre, string especie, DateTime fechaNacimiento,string nombreCliente,Cliente[] listaClientes)
        {
            
            if(ValidarNombreCliente(listaClientes,nombreCliente))
            {
                this.nombre = nombre;
                this.especie = especie;
                this.fechaNacimiento = fechaNacimiento;
                this.nombreCliente = nombreCliente;
                this.libretaVacunacion = "-";
            }
            else
            {
                this.nombreCliente=("No pudimos encontrar el nombre del dueño");
            }
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetEspecie()
        {
            return this.especie;
        }
        public string GetLibretaVacunacion()
        {
            return this.libretaVacunacion;
        }

        public string GetFechaNacimiento()
        {
            return this.fechaNacimiento.ToLongDateString();
        }
        public string GetNombreCliente()
        {
            return this.nombreCliente;
        }

        public void SetLibretaVacunacion(string vacuna)
        {
            this.libretaVacunacion = vacuna;
        }

        public string Mostrar()
        {
            return $"\nNombre Mascota: {GetNombre()} Especie: {GetEspecie()} Fecha de Nacimiento: {GetFechaNacimiento()} Libreta de Vacunacion: {GetLibretaVacunacion()} Nombre del Dueño: {GetNombreCliente()}";
        }

        public bool ValidarNombreCliente(Cliente[] listaClientes,string nombreCliente)
        {
            for(int i=0;i<listaClientes.Length;i++)
            {
                if(listaClientes[i].GetNombre() == nombreCliente)
                {
                    return true;
                }
            }
            return false;
        }



    }


}
