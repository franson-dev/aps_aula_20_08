using System;

namespace aps_aula_20_08
{
    class Triangulo : FormaGeometrica
    {
        private double _base;

        public double Base
        {
            get { return _base; }
            set { _base = value; } // Somente nesse contexto: set
        }

public override double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}
