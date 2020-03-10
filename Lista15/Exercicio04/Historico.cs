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
        private int k;
        private int max;
        // private Disciplina[] discs = new Disciplina[100];
        public Historico(string aluno) {
            this.aluno = aluno;
            discs = new Disciplina[2];
            k = 0;
            max = 2;
        }
        public void Inserir(Disciplina d) {
            if (k < max) discs[k++] = d;
            else
            {
                Disciplina[] v = new Disciplina[2 * max];
                Array.Copy(discs, v, max);
                discs = v;
                max = 2 * max;
                discs[k++] = d;
            }
        }
        public Disciplina[] Listar() {
            Disciplina[] v = new Disciplina[k];
            Array.Copy(discs, v, k);
            return v;
        }
        public override string ToString() {
            return $"Histórico de {aluno} - {k} disciplina(s)";
        }
        public double CalcularIRA()
        {
            if (k == 0) return 0;
            double ira = 0;
            foreach (Disciplina d in Listar()) ira += d.GetMedia();
            return 1.0 * ira / k;
        }
    }
}
