using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero ,string escuderia)
        {
            this.enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public static bool operator ==(AutoF1 primerAuto, AutoF1 segundoAuto)
        {

            if ((primerAuto.numero == segundoAuto.numero) && (primerAuto.escuderia.ToString() == segundoAuto.escuderia.ToString()))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 primerAuto, AutoF1 segundoAuto)
        {
            return (!(primerAuto == segundoAuto));
        }

        public bool GetEstadoCompetencia()
        {
            return this.enCompetencia;
        }

        public short GetCantidadCombustie()
        {
            return this.cantidadCombustible;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetEstadoCompetencia(bool nuevoEstado)
        {
            this.enCompetencia = nuevoEstado;
        }

        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }


        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            string estado;
            if(enCompetencia)
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


    }
} 

