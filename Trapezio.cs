using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
    public class Trapezio : FormaGeometrica
    {
        public double CalcularTrapezio()
        {
            double areaTrapezio;
            areaTrapezio = (Altura * (LadoA - LadoB)) / 2;
            return areaTrapezio;

        }
    }
}
