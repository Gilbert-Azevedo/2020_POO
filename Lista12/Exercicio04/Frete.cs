using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Frete
    {
        // Atributos
        private double distancia, peso;
        // Construtor
        public Frete(double d, double p)
        {
            distancia = d;
            peso = p;
        }
        // Métodos acessores
        public void SetDistancia(double d)
        {
            distancia = d;
        }
        public void SetPeso(double p)
        {
            peso = p;
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public double GetPeso()
        {
            return peso;
        }
        // Método de cálculo
        public double CalcFrete()
        {
            return 0.01 * distancia * peso;
        }
        // Redefinição do método ToString
        public override string ToString()
        {
            return $"Distância = {distancia} e Peso = {peso}";
        }
    }
}
