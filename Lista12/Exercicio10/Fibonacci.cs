using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Fibonacci
    {
        // Atributos necessários para calcular a sequencia
        private int a = 0, b = 1, c = 0;
        private int n = 0;
        // O método Iniciar retorna os atributos aos valores iniciais
        public void Iniciar()
        {
            a = 0;
            b = 1;
            c = 0;
            n = 0;
        }
        // O método Proximo retorna o próximo elemento da sequencia
        public int Proximo()
        {
            // n é o contador da sequencia. Quando for 0, retorna o primeiro elemento
            // que é a.
            // Observe que n é incrementado após o teste
            if (n == 0) { n++; return a; }
            // Quando for 1, retorna o segundo elemento que é b
            if (n == 1) { n++; return b; }
            // A partir do terceiro elemento, retorna a soma dos anteriores, que
            // é armazenada em c
            c = a + b;
            // Atualiza os valores dos elementos anteriores
            a = b;
            b = c;
            // Retorna o novo elemento
            return c;
        }
    }
}
