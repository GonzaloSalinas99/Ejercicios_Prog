using System;
using Veterinaria;
namespace Veterinaria.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente[] listaClientes = new Cliente[3];
            listaClientes[0] =new Cliente("2 de mayo 2768", "Gonzalo", "Salinas", 42414903);
            listaClientes[1] = new Cliente("1 de mayo 2768", "Quimey", "Espinosa", 20365984);
            listaClientes[2] = new Cliente("20 de Septiembre 2768", "Alejo", "Marcona", 13659861);



            foreach(Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.Mostrar());
            }


            Mascota[] listaMascotas = new Mascota[5];
            listaMascotas[0] = new Mascota("Kitty", "Gato", new DateTime(2013,09,13), "Elias", listaClientes);
            listaMascotas[1] = new Mascota("Ponchi", "Perro", new DateTime(2000, 03, 19), "Quimey", listaClientes);
            listaMascotas[2] = new Mascota("Abril", "Gato", new DateTime(1999, 01, 11), "Quimey", listaClientes);
            listaMascotas[3] = new Mascota("Pepito", "Loro", new DateTime(2020, 12, 05), "Alejo", listaClientes);
            listaMascotas[4] = new Mascota("Gallo Carlos", "Gallo", new DateTime(2021, 10, 27), "Gonzalo", listaClientes);

            listaMascotas[0].SetLibretaVacunacion("Triple Felina");
            listaMascotas[1].SetLibretaVacunacion("Contra la Rabia");

            foreach(Mascota mascota in listaMascotas)
            {
                Console.WriteLine(mascota.Mostrar());
            }
        
        
        }
    }
}
