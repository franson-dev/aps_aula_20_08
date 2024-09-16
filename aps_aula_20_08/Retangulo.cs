using System;

namespace aps_aula_20_08
{
    class Retangulo : FormaGeometrica
    {
        private double _base;
        private double altura;

        public Retangulo(double _base, double altura) 
        { 
            this._base = _base;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return _base * altura;
        }

        public override double CalcularPerimetro()
        {
            return (_base * 2) + (altura * 2);
        }

        public override string ToString()
        {
            return $"Retângulo ({_base}x{altura})";
        }
    }
}
