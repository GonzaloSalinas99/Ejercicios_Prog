using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteca;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja.DelegadoClienteAtendido clienteAtendido = (caja, cliente) =>
            {
                string mensaje = $"{DateTime.Now:HH:MM:ss} - Hilo{Task.CurrentId} - {caja.NombreCaja} - " +
                $"Atendiendo a {cliente}. Quedan {caja.CantidadClientesALaEspera} clientes en esta caja";
                Console.WriteLine(mensaje);
            };

            Caja c1 = new Caja("Caja 01",clienteAtendido);
            Caja c2 = new Caja("Caja 02",clienteAtendido);

            List<Caja> cajas = new List<Caja>();

            cajas.Add(c1);
            cajas.Add(c2);

            Negocio negocio = new Negocio(cajas);

            Console.WriteLine("Asignando cajas....");

            List<Task> hilos = negocio.ComenzarAtencion();

            Task.WaitAll(hilos.ToArray());

        }
    }
}
