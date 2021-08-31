using System;
using System.Text;
namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular,decimal cantidadMonto)
        {
            this.titular = titular;
            cantidad = cantidadMonto;
        }

        public string GetNombreTitular()
        {
            return this.titular;
        }

        public decimal GetCantidadMonto()
        {
            return this.cantidad;
        }

        public string Mostrar ()
        {
            return ($"Nombre Titular:{GetNombreTitular()} Dinero en cuenta: ${GetCantidadMonto()}");
        }
        public bool Ingresar (decimal montoAIngresar)
        {
            
            if(montoAIngresar>0)
            {
                this.cantidad += montoAIngresar;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Retirar(decimal montoARetirar)
        {
            this.cantidad -= montoARetirar;
        }

    }
}
