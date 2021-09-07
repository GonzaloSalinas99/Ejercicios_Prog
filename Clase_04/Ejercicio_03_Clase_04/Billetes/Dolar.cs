using System;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private double cotizRespectoDolar;
        


        public Dolar()
        {
            cotizRespectoDolar = 1;
        }
    
    
    }

    public class Euro
    {
        private double cantidad;
        private double cotizRespectoDolar;

        public Euro()
        {
            cotizRespectoDolar = 1.17;
        }
    }

    public class Pesos
    {
        private double cantidad;
        private double cotizRespectoDolar;

        public Pesos()
        {
            cotizRespectoDolar = 102.65;
        }
    }


}
