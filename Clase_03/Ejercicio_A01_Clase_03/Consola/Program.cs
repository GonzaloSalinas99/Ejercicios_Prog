using System;
using Biblioteca;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductores[] listaConductores = new Conductores[2];
            
            for(int i=0;i<listaConductores.Length;i++)
            {
                Console.WriteLine("Ingrese el nombre del conductor:");
                string nombreConductor = Console.ReadLine();

                int[] kmRecorridos = new int[7];
                int km;
                for(int j=0;j<kmRecorridos.Length;j++)
                {
                    if (j==0||j==1||j==2||j==4)
                    {
                        Console.WriteLine($"Ingrese el km recorrido en el dia {j + 1}");
                        if (int.TryParse(Console.ReadLine(), out km))
                        {
                            kmRecorridos[j] = km;
                        }
                        else
                        {
                            Console.WriteLine("No se pudo guardar el km");
                        }
                    }
                    else
                    {
                        kmRecorridos[j] = 0;
                    }
                }
                listaConductores[i] = new Conductores(nombreConductor, kmRecorridos);
            }



            int mayorKmEnUnDia=0;
            int diaABuscar;
            string nombreConductorMasKm="";
            Console.WriteLine("Ingrese el dia a buscar para saber el conductor con mas KM");
            diaABuscar = int.Parse(Console.ReadLine());
            for(int i=0;i<listaConductores.Length;i++)
            {
                if(i==0)
                {
                    mayorKmEnUnDia = listaConductores[i].GetKmEnDia(diaABuscar);
                    nombreConductorMasKm = listaConductores[i].GetNombre();
                }
                else
                {
                    if(mayorKmEnUnDia<listaConductores[i].GetKmEnDia(diaABuscar))
                    {
                        mayorKmEnUnDia = listaConductores[i].GetKmEnDia(diaABuscar);
                        nombreConductorMasKm = listaConductores[i].GetNombre();

                    }
                }
            }

            Console.WriteLine($"Nombre del conductor que mas viajo el Dia {diaABuscar} de la semana: {nombreConductorMasKm}");


            foreach(Conductores conductor in listaConductores)
            {
                Console.WriteLine(conductor.Mostrar());
                Console.WriteLine(conductor.nombreMayorKmRecorridos(listaConductores));
            }


        }
    }
}


//Consigna#
//De una empresa de transporte de cargas se quiere guardar el nombre de los conductores y los kilómetros que conducen cada día de la semana.

//Para guardar esta información, la empresa de transporte tendrá un array de conductores.

//De cada conductor se tendrá la siguiente información:

//Nombre del conductor.
//Kilometros recorridos por cada día de la semana. Por ejemplo:
//Día 1: 200
//Día 2: 599
//Día 3: 899
//Día 4: 0(tiene franco)
//Día 5: 256
//Día 6: 0
//Día 7: 0
//Desarrollar las clases y métodos necesarios. Toda la lógica de negocio deberá estar encapsulada en clases y dentro de un proyecto de tipo biblioteca de clases.

//Crear un proyecto de consola y en el método Main cargar 3 conductores a la empresa de transportes.

//Luego mostrar:

//El conductor que hizo más km en esa semana.
//El conductor que hizo más km el día 3.
//El conductor que hizo más km el día 5.