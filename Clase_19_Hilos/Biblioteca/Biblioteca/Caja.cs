using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string cliente);

        private static Random random;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtendido;


        public string NombreCaja
        {
            get { return this.nombreCaja; }
        }
        
        public int CantidadClientesALaEspera
        {

            get { return clientesALaEspera.Count; }
        }

        static Caja()
        {
            random = new Random();
        }

        public Caja(string nombre,DelegadoClienteAtendido delegadoClienteAtendido)
        {
            clientesALaEspera = new Queue<string>();
            nombreCaja = nombre;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {


            //Task hilo = new Task(AtenderCliente);
            //hilo.Start();
            //return hilo;



            return Task.Run(AtenderCliente);
        }

        private void AtenderCliente()
        {
            do
            {
                if(clientesALaEspera.Any())
                {
                    string cliente = clientesALaEspera.Dequeue();
                    if(delegadoClienteAtendido is not null)
                    {
                        delegadoClienteAtendido.Invoke(this, cliente);
                    }

                    Thread.Sleep(random.Next(1000,5000));
                }



            } while (true);
        }


    }
}
