using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    // A classe implementa a interface IMedia e deve, obrigatoriamente, possuir
    // o método GetMedia e ele também deve ser público
    class DisciplinaAnual : IMedia
    {
        private int nota1, nota2, nota3, nota4, notaF;
        public DisciplinaAnual(int nota1, int nota2, int nota3, int nota4, int notaF)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
            this.notaF = notaF;
        }
        public int GetMedia()
        {
            // Cálculo da média considerando pesos 2, 2, 3 e 3
            // Se não for aprovado por média, calcula a média aritmética com a 
            // nota da prova final
            int m = (2 * nota1 + 2 * nota2 + 3 * nota3 + 3 * nota4) / 10;
            if (m < 60) m = (m + notaF) / 2;
            return m;
        }
    }
}
