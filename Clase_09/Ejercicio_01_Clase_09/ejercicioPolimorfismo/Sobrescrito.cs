using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioPolimorfismo
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();


        public override string ToString()
        {
            return "Este es mi metodo ToString sobrescrito";
        }

        public override bool Equals(object obj)
        {
            
            return obj is Sobrescrito;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

    }

    public class SobreSobrescrito : Sobrescrito
    {
        public SobreSobrescrito()
        {}
        public override string MiPropiedad
        {
            get { return this.miAtributo; }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }

    }
}
