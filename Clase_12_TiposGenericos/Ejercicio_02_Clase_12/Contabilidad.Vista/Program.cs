using System;
using Biblioteca;
namespace Contabilidad.Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(1000);
            Factura f2 = new Factura(21);
            Factura f3 = new Factura(230);
            Factura f4 = new Factura(1111);

            Recibo r1 = new Recibo(1212);
            Recibo r2 = new Recibo(1313);
            Recibo r3 = new Recibo(4545);
            Recibo r4 = new Recibo(8988);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += f1;
            contabilidad += f2;
            contabilidad += f3;
            contabilidad += f4;
            contabilidad += r1;
            contabilidad += r2;
            contabilidad += r3;
            contabilidad += r4;

            foreach (Factura cont in contabilidad.egresos)
            {
                Console.WriteLine(cont.Numero);
            }

        }
    }
}
