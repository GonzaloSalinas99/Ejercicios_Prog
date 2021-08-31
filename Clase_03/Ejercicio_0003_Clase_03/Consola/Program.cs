using System;
using Biblioteca;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante primerEstudiante = new Estudiante("Gonzalo", "Salinas", "123456");            
            Estudiante segundoEstudiante = new Estudiante("Eliana", "Cuervo", "574894");            
            Estudiante tercerEstudiante = new Estudiante("Hugo", "Sanchez", "156484");

            primerEstudiante.SetNotaPrimerPacial(7);
            primerEstudiante.SetNotaSegundoPacial(9);

            segundoEstudiante.SetNotaPrimerPacial(5);
            segundoEstudiante.SetNotaSegundoPacial(6);

            tercerEstudiante.SetNotaPrimerPacial(5);
            tercerEstudiante.SetNotaSegundoPacial(3);

            Console.WriteLine(primerEstudiante.Mostrar());
            Console.WriteLine(segundoEstudiante.Mostrar());
            Console.WriteLine(tercerEstudiante.Mostrar());
        
        
        }
    }
}
