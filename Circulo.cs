using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
    public class Circulo : FormaGeometrica
    {
        public double CalcularAreaCirculo()
        {
            double areaCirculo;
            areaCirculo = Math.PI * Math.Pow(RaioCirculo, 2);
            return areaCirculo;
            
        }
    }
}
