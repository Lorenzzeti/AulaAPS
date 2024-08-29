using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAPS
{
    public class TrianguloEquilatero : Triangulo
    {
        private double _base;
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }
        public override double CalcularArea()
        {
            return ((Math.Sqrt(3) / 4) * Math.Pow(_base, 2));
        }

        public override double CalcularPerimetro()
        {
            return 3 * _base;
        }
    }
}