using System;


namespace aps_aula_20_08
{
    class Circulo : FormaGeometrica
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
            return Math.Round(Math.PI * Math.Pow(raio, 2) , 3);
        }

        public override double CalcularPerimetro()
        {
            return Math.Round(2 * Math.PI * raio , 3);
        }

        public override string ToString()
        {
            return $"Circulo ({raio})";
        }
    }
}
