using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAPS
{
    public  class Triangulo : FormaGeometrica
    {
        private double base_;
        public double Base
        {
            get { return base_; }
            set { base_ = value; }
        }

        private double altura;
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        private double lado1;
        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }

        private double lado2;
        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        public override double CalcularArea()
        {
            return (base_ * altura / 2);
        }

        public override double CalcularPerimetro()
        {
            return (base_  + lado1 + lado2);
        }
        public override string ToString()
        {
            return $"Triângulo ({base_}, {altura}, {lado1}, {lado2})";
        }


    }
}
