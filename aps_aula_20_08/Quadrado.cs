using System;

namespace aps_aula_20_08
{
    class Quadrado : FormaGeometrica
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; } // Somente nesse contexto: set
        }

        public override double CalcularArea()
        {
            return Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return lado * 4;
        }
        public override string ToString()
        {
            return $"Quadrado ({lado})";
        }
    }
}
