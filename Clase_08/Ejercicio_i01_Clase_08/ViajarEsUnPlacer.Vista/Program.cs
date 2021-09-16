using System;
using System.Collections.Generic;
using Biblioteca;
namespace ViajarEsUnPlacer.Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto1 = new Moto(2, Colores.Blanco, 300);
            Camion camion1= new Camion(2, 2, Colores.Blanco,16,6000);
            Automovil auto1= new Automovil(2, 4, Colores.Blanco,6,4);

            List<VehiculoTerrestre> listaVehiculos = new List<VehiculoTerrestre>();
            listaVehiculos.Add(moto1);
            listaVehiculos.Add(camion1);
            listaVehiculos.Add(auto1);

            foreach (VehiculoTerrestre item in listaVehiculos)
            {
                if(item is Moto)
                {
                    Moto motoAux = moto1;
                    Console.WriteLine(motoAux.MostrarMoto());
                }
                else if(item is Camion)
                {
                    Camion camionAux = camion1;
                    Console.WriteLine(camionAux.MostrarCamion());
                }
                else if(item is Automovil)
                {
                    Automovil autoAux =auto1;
                    Console.WriteLine(autoAux.MostrarAuto());

                }
            }

        }
    }
}
