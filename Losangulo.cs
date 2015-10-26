using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
   public class Losangulo : FormaGeometrica
    {
        public double CalcularAreaLosangulo()
        {
            double areaLosangulo;
            areaLosangulo = (LadoA * LadoB) / 2;
            return areaLosangulo;

        }
    }
}
