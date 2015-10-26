using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
    public class FormaGeometrica
    {
        private double _ladoA;
        public double LadoA
        {

            get
            {
                return this._ladoA;
            }

            set
            {
                this._ladoA = value > 0 ? value : 0;

            }
        }
        private double _ladoB;
        public double LadoB
        {

            get
            {
                return this._ladoB;
            }

            set
            {
                this._ladoB = value > 0 ? value : 0;

            }
        }
        private double _altura;
        public double Altura
        {

            get
            {
                return this._altura;
            }

            set
            {
                this._altura = value > 0 ? value : 0;

            }
        }
        private double _raioCirculo;
        public double RaioCirculo
        {

            get
            {
                return this._raioCirculo;
            }

            set
            {
                this._raioCirculo = value > 0 ? value : 0;

            }
        }
    }
}
