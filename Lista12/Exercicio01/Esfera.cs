using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Esfera
    {
        // Atributo encapsulado
        private double raio;
        // Métodos de acesso
        public void SetRaio(double r)
        {
            raio = r;
        }
        public double GetRaio()
        {
            return raio;
        }
        // Métodos de cálculo
        public double CalcArea()
        {
            return 4 * Math.PI * raio * raio;
        }
        public double CalcVolume()
        {
            return 4.0 / 3 * Math.PI * Math.Pow(raio, 3);
        }
    }
}
