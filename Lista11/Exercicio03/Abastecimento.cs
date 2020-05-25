using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Abastecimento
    {
        // Atributos encapsulados
        private double valorLitro, valorPago, kmRodados;
        // Métodos acessores. Apenas os sets foram implementados. 
        public void SetValorLitro(double valorLitro)
        {
            // Para diferenciar o atributo do parâmetro, o atributo deve ser 
            // referenciado por this
            this.valorLitro = valorLitro;
        }
        public void SetValorPago(double valorPago)
        {
            this.valorPago = valorPago;
        }
        public void SetKmRodados(double kmRodados)
        {
            this.kmRodados = kmRodados;
        }
        public double MediaKmLitro()
        {
            // Esse método calcula a média de consumo do veículo considerando
            // que o tanque de combustível é sempre completado. Com isso, é possível
            // calcular o número de litros consumidos para percorrer a distância informada
            double numLitros = valorPago / valorLitro;
            // O consumo é o quociente entre a distância percorrida e o número de litros
            // de combustível gasto
            return kmRodados / numLitros;
        }
        public double MediaReaisKm()
        {
            // Esse método calcula a média de gasto para cada km percorrido
            return valorPago / kmRodados;
        }
    }
}
