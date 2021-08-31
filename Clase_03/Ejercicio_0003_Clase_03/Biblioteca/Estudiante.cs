using System;
using System.Text;
namespace Biblioteca
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerPacial(int nota)
        {
            this.notaPrimerParcial=nota;

        }

        public void SetNotaSegundoPacial(int nota)
        {
            this.notaSegundoParcial = nota;

        }

        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial>=4 && notaSegundoParcial>=4)
            {
                return random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }
        public double CalcularPromedio()
        {
            return (this.notaPrimerParcial + (float)this.notaSegundoParcial) / 2;
        }

        public string Mostrar()
        {
            StringBuilder texto = new StringBuilder();
            double notaFinal = CalcularNotaFinal();

            texto.AppendLine($"Nombre: {this.nombre}  Apellido: {this.apellido}  Legajo: {this.legajo}");
            texto.AppendLine($"Nota Primer Parcial: {this.notaPrimerParcial}  Nota Segundo Parcial: {this.notaSegundoParcial}");
            texto.AppendLine($"Promedio Final: {CalcularPromedio()}");
            Console.WriteLine(notaFinal);
            if(notaFinal>4)
            {
                texto.AppendLine($"Su nota final es: {notaFinal}");
            }
            else
            {
                texto.AppendLine("Usted no aprobo la materia");
            }
            return texto.ToString();
        }
    }
}
