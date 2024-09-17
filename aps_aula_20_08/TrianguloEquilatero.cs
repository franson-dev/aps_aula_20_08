using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps_aula_20_08
{
    class TrianguloEquilatero : Triangulo
    {
        private double _base;

        public TrianguloEquilatero(double _base)
        {
            this._base = _base;
        }

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }


        public override double CalcularArea()
        {
            //Cálculo da hipotenusa foi manipulado para que retorne a altura.
            return Math.Round(_base * CalcularHipotenusa() / 2, 3 );
        }

        public override double CalcularHipotenusa()
        {
            //Cálculo da hipotenusa foi manipulado para que retorne a altura.
            return Math.Round(Math.Sqrt(Math.Pow(_base, 2) - Math.Pow(_base/2, 2)), 3);
        }

        public override double CalcularPerimetro()
        {
            return Math.Round(_base *3, 3);
        }
        public override string ToString()
        {
            return $"Triângulo Equilátero ({_base})";
        }
    }
}
