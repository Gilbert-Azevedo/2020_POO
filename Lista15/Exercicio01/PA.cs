using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class PA
    {
        // Atributos da progressão
        private double primeiroElemento;
        private double razao;
        // Metodos de acesso - não listados no diagrama
        public void SetPrimeiroElemento(double pe)
        {
            primeiroElemento = pe;
        }
        public void SetRazao(double r)
        {
            razao = r;
        }
        // Método que retorna n-ésimo elemento da progressão
        public double GetElemento(int n)
        {
            return primeiroElemento + (n - 1) * razao;
        }
        // Método que um vetor com os n primeiros elementos da progressão
        public double[] GetElementos(int n)
        {
            // Instancia o vetor com n elementos
            double[] v = new double[n];
            // Primeiro elemento
            v[0] = primeiroElemento;
            // Elementos seguintes
            for (int i = 1; i < n; i++)
                v[i] = v[i - 1] + razao;
            return v;
        }
        // Método que retorna o elemento no índice n da progressão
        public double GetSoma(int n)
        {
            return (primeiroElemento + primeiroElemento + (n - 1) * razao) * n / 2;
        }
    }
}
