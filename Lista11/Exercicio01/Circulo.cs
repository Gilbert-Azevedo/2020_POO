using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    // A classe Circulo representa a figura geométrica para fins de cálculo
    // de sua área e circunferência
    // Uma classe define um novo tipo de variável sendo, geralmente, escrita
    // em um arquivo separado. Mas isso é apenas uma convenção.
    class Circulo
    {
        // Os atributos da classe listam as informações armazenadas para
        // cada objeto (variável ou instância da classe)
        private double raio;
        // Os métodos listam as operações que podem ser realizadas pelo objeto
        // Get e Set são métodos acessores, provendo acesso ao atributo do
        // objeto que está encapsulado pelo modificador de acesso private
        public void SetRaio(double raio)
        {
            if (raio > 0) this.raio = raio;
        }
        public double GetRaio()
        {
            return this.raio;
        }
        // Os métodos CalcArea e CalcCircunferencia realizam as outras operações 
        // previstas para os objetos
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
