using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
    public class Quadrado : FormaGeometrica
    {
        public double CalcularQuadrado()
        {
            double areaQuadrado;
            areaQuadrado = (LadoA * LadoB);
            return areaQuadrado;

        }
    }
}
