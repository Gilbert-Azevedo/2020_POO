using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Historico
    {
        private string aluno;
        private Disciplina[] discs;
        // private Disciplina[] discs = new Disciplina[100];
        public Historico(string aluno)
        {
            this.aluno = aluno;
            discs = new Disciplina[100];
        }
    }
}
