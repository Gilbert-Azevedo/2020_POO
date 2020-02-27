using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Circulo
    {
        private double raio;
        public void SetRaio(double raio)
        {
            if (raio > 0) this.raio = raio;
        }
        public double GetRaio()
        {
            return this.raio;
        }
        public double CalcArea()
        {
            return Math.PI * this.raio * this.raio;
        }
        public double CalcCircunferencia()
        {
            return 2 * Math.PI * this.raio;
        }
    }
}
