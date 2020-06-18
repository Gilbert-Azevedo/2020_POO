using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Historico
    {
        // Vetor para até 100 disciplinas
        private Disciplina[] discs = new Disciplina[100];
        // Número de disciplinas já inseridas
        private int k;
        // Método para inserir uma disciplina
        public void Inserir(Disciplina c)
        {
            if (k < 100)        // Verifica se ainda não chegou ao limite do vetor
                discs[k++] = c; // Insere a disciplina no vetor
        }
        // Método para retornar o vetor com as disciplinas já cadastradas
        public Disciplina[] Listar()
        {
            // Vetor com a quantidade de disciplinas já cadastradas
            Disciplina[] v = new Disciplina[k];
            // Copia para o vetor de retorno, as disciplinas já inseridas
            Array.Copy(discs, v, k);
            return v;
        }
        // Método para calcular o IRA do aluno
        public double CalcularIRA()
        {
            // O IRA é calculado com as disciplinas que o aluno tenha sido aprovado
            int n = 0;        // Número de disciplina em que o aluno foi aprovado
            double ira = 0;   // ira = média das médias das disciplinas
            foreach(Disciplina d in Listar())
                if (d.GetAprovado()) { n++; ira += d.GetMedia(); }
            if (n == 0) return 0;
            else return ira / n;
        }
    }
}
