using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Fibonacci : ISequencia
    {
        private int a, b = 1, c;
        private int k;
        public void Iniciar()
        {
            // Controla o início da sequência contando quantas vezes o método
            // Proximo é chamado
            a = 0;
            b = 1;
            k = 0;
        }
        public int Proximo()
        {
            // Retorna o próximo elemento da sequência
            if (k == 0) { k++; return a; }
            if (k == 1) { k++; return b; }
            // Soma os dois elementos anteriores e retorna
            c = a + b;
            a = b;
            b = c;
            return c;
        }
    }
}
