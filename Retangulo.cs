using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
   public class Retangulo : FormaGeometrica
    {
        public double CalcularRetangulo()
        {
            double areaRetangulo;
            areaRetangulo = (LadoA * Altura);
            return areaRetangulo;

        }
    }
}
