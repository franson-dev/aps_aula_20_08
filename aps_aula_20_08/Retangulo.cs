using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aps_aula_20_08
{
    class Retangulo : FormaGeometrica
    {
        private double _base;
        private double altura;

        public override double CalcularArea()
        {
            return _base * altura;
        }

        public override double CalcularPerimetro()
        {
            return (_base * 2) + (altura * 2);
        }

    }
}
