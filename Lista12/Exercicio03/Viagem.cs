using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Viagem
    {
        // Atributos
        private double distancia, tempo;
        // Construtor
        public Viagem(double d, double t)
        {
            distancia = d;
            tempo = t;
        }
        // Métodos de acesso
        public void SetDistancia(double d)
        {
            distancia = d;
        }
        public void SetTempo(double t)
        {
            tempo = t;
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public double GetTempo()
        {
            return tempo;
        }
        // Método de cálculo
        public double CalcVelocidade()
        {
            return distancia / tempo;
        }
        // Redefinição do método ToString
        public override string ToString()
        {
            return $"Distância = {distancia} e Tempo = {tempo}";
        }
    }
}
