using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }
        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public VehiculoDeCarrera(short numero,string escuderia)
        {
            EnCompetencia = false;
            CantidadCombustible = 0;
            VueltasRestantes = 0;
            Numero = numero;
            Escuderia = escuderia;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            string estado;
            if (enCompetencia)
            {
                estado = "Fuera de Competencia";
            }
            else
            {
                estado = "En Competencia";
            }

            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"Numero: {numero}");
            sb.AppendLine($"Estado de Competencia: {estado}");
            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"Vueltas Restantes: {vueltasRestantes}");

            return sb.ToString();
        }

        public static bool operator == (VehiculoDeCarrera v1 , VehiculoDeCarrera v2)
        {
            if((v1.Numero == v2.Numero) && (v1.Escuderia == v2.Escuderia))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

    }
}
