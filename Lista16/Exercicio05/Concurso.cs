using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Concurso
    {
        private Candidato[] candidatos = new Candidato[2];
        private int k;
        public void Inserir(Candidato p)
        {
            // Duplica o tamanho do vetor, caso já tenha sido todo preenchido
            if (k == candidatos.Length) Array.Resize(ref candidatos, candidatos.Length * 2);
            // Insere o candidato e incrementa o contador
            candidatos[k++] = p;
        }
        public Candidato[] Listar()
        {
            // Instancia um vetor com a quantidade de elementos já inseridos
            Candidato[] v = new Candidato[k];
            // Copia os elementos do vetor candidatos para o vetor de retorno
            Array.Copy(candidatos, v, k);
            // Ordena o vetor de acordo com o IComparable de candidatos
            Array.Sort(v);
            return v;
        }
        public Candidato[] Classificados()
        {
            // Vetor de candidatos cadastrados
            Candidato[] v = Listar();
            // Conta o número de candidatos aprovados
            int n = 0;
            foreach (Candidato c in v)
                if (c.Aprovado()) n++;
            // Altera o tamanho do vetor para remover os candidatos não classificados
            Array.Resize(ref v, n);
            return v;
        }
    }
}
