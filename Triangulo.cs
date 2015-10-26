using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
    public class Triangulo : FormaGeometrica
    {
        public double CalcularTriangulo()
        {
            double areaTriangulo;
            areaTriangulo = (LadoA * Altura) / 2;
            return areaTriangulo;

        }
    }
}
