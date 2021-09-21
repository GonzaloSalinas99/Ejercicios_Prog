using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        protected double baseFigura;
        protected double alturaFigura;

        public Rectangulo(double baseFigura, double alturaFigura)
        {
            this.baseFigura = baseFigura;
            this.alturaFigura = alturaFigura;
        }

        public override string Dibujar()
        {
            return "Dibujando un rectangulo";
        }

        public override double CalcularPerimetro()
        {
            return Math.Round((baseFigura + alturaFigura)* 2);
        }

        public override double CalcularSuperficie()
        {
            return Math.Round(baseFigura * alturaFigura);
        }
        
    }
}
