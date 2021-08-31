using System;

namespace Biblioteca
{
    public class Conductores
    {
        private string nombre;
        private int[] KilometroPorDia;

        public Conductores(string nombre,int [] kilometrosRecorridos)
        {
            this.nombre = nombre;
            this.KilometroPorDia = kilometrosRecorridos;

        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetKilometros()
        {
            return $"\nDia 1: {KilometroPorDia[0]} \n Dia 2: {KilometroPorDia[1]} \n Dia 3: {KilometroPorDia[2]} \n Dia 4: {KilometroPorDia[3]} \n" +
                $"Dia 5: {KilometroPorDia[4]} \n Dia 6: {KilometroPorDia[5]} \n Dia 7: {KilometroPorDia[6]} \n";
        
        }
        public string Mostrar()
        {
            return $"Nombre Conductor: {GetNombre()} Kilometros Recorridos: {GetKilometros()}";
        }

        public int TotalKmRecorridos()
        {
            return KilometroPorDia[0] + KilometroPorDia[1] + KilometroPorDia[2] + KilometroPorDia[4];
        }

        public string nombreMayorKmRecorridos(Conductores[] listaConductores)
        {
            int mayorKmRecorrido = 0;
            string nombreMayorKmRecorridos="";

            for (int i = 0; i < listaConductores.Length; i++)
            {
                if (i == 0)
                { 
                     nombreMayorKmRecorridos = listaConductores[i].GetNombre();
                    mayorKmRecorrido = listaConductores[i].TotalKmRecorridos();
                }
                else
                {
                    if (mayorKmRecorrido < listaConductores[i].TotalKmRecorridos())
                    {
                        mayorKmRecorrido = listaConductores[i].TotalKmRecorridos();
                        nombreMayorKmRecorridos = listaConductores[i].GetNombre();
                    }
                }
            }
            return nombreMayorKmRecorridos;
        }

        public int GetKmEnDia(int diaABuscar)
        {
            return KilometroPorDia[diaABuscar - 1]; 
        }


    }
}
