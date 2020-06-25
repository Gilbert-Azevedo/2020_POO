using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    // A classe implementa a interface IMedia e deve, obrigatoriamente, possuir
    // o método GetMedia e ele também deve ser público
    class DisciplinaSemestral : IMedia
    {
        private int nota1, nota2, notaF;
        public DisciplinaSemestral(int nota1, int nota2, int notaF)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.notaF = notaF;
        }
        public int GetMedia()
        {
            // Cálculo da média considerando pesos 2 e 3
            // Se não for aprovado por média, calcula a média aritmética com a 
            // nota da prova final
            int m = (2 * nota1 + 3 * nota2) / 5;
            if (m < 60) m = (m + notaF) / 2;
            return m;
        }
    }
}
