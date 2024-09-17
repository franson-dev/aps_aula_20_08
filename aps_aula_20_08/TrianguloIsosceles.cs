using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps_aula_20_08
{
    class TrianguloIsosceles : Triangulo
    {
        private double _base;
        private double altura;

        public TrianguloIsosceles(double _base, double altura)
        {
            this._base = _base;
            this.altura = altura;
        }

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override double CalcularArea()
        {
            return (_base * altura)/2;
        }

        public override double CalcularHipotenusa()
        {
            return Math.Sqrt(Math.Pow(altura,2) + Math.Pow(_base,2)/2);
        }

        public override double CalcularPerimetro()
        {
            return _base + 2*CalcularHipotenusa();
        }
    }
}
