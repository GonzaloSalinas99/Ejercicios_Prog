using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {

        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;


        static Negocio()
        {
            realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> listaCaja)
        {
            cajas = listaCaja;
            clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {

            List<Task> hilos = new List<Task>();

            foreach (Caja caja in cajas)
            {
                hilos.Add(caja.IniciarAtencion());
                
            }

            hilos.Add(Task.Run(GenerarCliente));
            hilos.Add( Task.Run(AsignarCaja));

            return hilos;
        }

        private void GenerarCliente()
        {
            do
            {
                string cliente = realNameGenerator.Generate();
                clientes.Enqueue(cliente);
                Thread.Sleep(1000);

            } while (true);
        }

        private void AsignarCaja()
        {
            do
            {
                Caja caja = cajas.OrderBy(c => c.CantidadClientesALaEspera).First();
                                clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    caja.AgregarCliente(cliente);

                }
            } while (true);
        
        }




    }
}
