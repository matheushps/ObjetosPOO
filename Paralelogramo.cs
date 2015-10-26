using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
   public class Paralelogramo : FormaGeometrica
    {
        public double CalcularParalelogramo()
        {
            double areaParalelogramo;
            areaParalelogramo = (LadoA * Altura);
            return areaParalelogramo;

        }
    }
}
