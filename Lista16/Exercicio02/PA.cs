using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class PA : ISequencia
    {
        private int primeiroElemento, razao;
        private int k;
        public PA(int primeiroElemento, int razao)
        {
            this.primeiroElemento = primeiroElemento;
            this.razao = razao;
        }
        public void Iniciar()
        {
            // Controla o início da sequência contando quantas vezes o método
            // Proximo é chamado
            k = 0;
        }
        public int Proximo()
        {
            // Retorna o próximo elemento da sequência
            if (k == 0) { k++; return primeiroElemento; }
            // Calcula o k-ésimo elemento da sequência
            return primeiroElemento + k++ * razao;
        }
    }
}
