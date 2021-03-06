using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Paquete:IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        decimal IAduana.Impuestos
        {
            get { return costoEnvio * 0.35M; }
        }
            

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo de seguimiento: {codigoSeguimiento}");
            sb.AppendLine($"Costo Envio: {costoEnvio}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine($"Peso Kg: {pesoKg}");
            if(TienePrioridad == true)
            {
                sb.AppendLine("Tiene Prioridad.");
            }
            else
            {
                sb.AppendLine("No tiene prioridad.");
            }
            return sb.ToString();
        }

        public decimal AplicarImpuestos()
        {
            throw new NotImplementedException();
        }
    }
}
