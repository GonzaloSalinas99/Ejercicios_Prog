using System;

namespace Prueba_Delegados
{
    public delegate void DelegadoSaludar();
    public delegate void DelegadoConInt(int numeroInt);
    class Program
    {
        

        static void Main(string[] args)
        {
            DelegadoConInt delega = SaludarMiliSegundos;
            Temporizador.EsperarMilisegundos(new Random().Next(1000, 5000), delega);

        }

        static void SaludarMiliSegundos(int milisegundos)
        {
            Console.WriteLine($"Pasaron :  { milisegundos}");
        }

        static void Saludar()
        {
            Console.WriteLine("HOLA LALOOO");
        }
    }
}
