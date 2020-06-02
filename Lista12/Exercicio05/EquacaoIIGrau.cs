using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class EquacaoIIGrau
    {
        // Atributos 
        // O valor do atributo a inicia com 1
        // Uma equação do II grau não pode ter a = 0
        private double a = 1, b, c;
        // Métodos de acesso
        public void SetABC(double a, double b, double c)
        {
            if (a != 0) this.a = a;
            this.b = b;
            this.c = c;
        }
        public void GetABC(out double a, out double b, out double c)
        {
            // Nesse exemplo, o método get usa parâmetros de saída
            // para retornar 3 atributos simultaneamente
            a = this.a;
            b = this.b;
            c = this.c;
        }
        // Métodos de cálculo
        public bool RaizesReais()
        {
            // A equação tem raízes reais qdo o delta é maior ou igual a zero
            return Delta() >= 0;
        }
        public double Delta()
        {
            // Retorna o valor de delta
            return b * b - 4 * a * c;
        }
        public bool X1(out double x)
        {
            // Retorna verdadeiro qdo tem raízes reais e o valor da raiz em x
            x = 0;
            if (!RaizesReais()) return false;
            x = (-b + Math.Sqrt(Delta())) / 2 / a;
            return true;
        }
        public bool X2(out double x)
        {
            // Retorna verdadeiro qdo tem raízes reais e o valor da raiz em x
            x = 0;
            if (!RaizesReais()) return false;
            x = (-b - Math.Sqrt(Delta())) / 2 / a;
            return true;
        }
    }
}
