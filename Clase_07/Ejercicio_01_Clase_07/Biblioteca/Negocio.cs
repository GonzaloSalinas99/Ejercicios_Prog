using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        public string apellido { get; set; }



        public string nombrePersona { get; set; }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator == (Negocio negocio, Cliente cliente)
        {
            foreach (Cliente cAux in negocio.clientes)
            {
                if(cAux == cliente)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }

        public static bool operator + (Negocio negocio , Cliente cliente)
        {
            if(negocio != cliente)
            {
                negocio.clientes.Enqueue(cliente);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio negocio)
        {
            if (negocio.clientes.Count >0)
            {
                return negocio.caja.Atender(negocio.Cliente);
            }
            return false;
        }

        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }

            set 
            {
                bool respuesta = this + value;
            }
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }
        



    }
}
