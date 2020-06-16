using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Agenda
    {
        // Vetor para até 100 compromissos
        private Compromisso[] comps = new Compromisso[100];
        // Número de compromissos já inseridos
        private int k;
        // Método para inserir um compromisso
        public void Inserir(Compromisso c)
        {
            if (k < 100)        // Verifica se ainda não chegou ao limite do vetor
                comps[k++] = c; // Insere o compromisso no vetor
        }
        // Método para retornar o vetor com os compromissos já cadastrados
        public Compromisso[] Listar()
        {
            // Vetor com a quantidade de compromissos já cadastrados
            Compromisso[] v = new Compromisso[k];
            // Copia para o vetor de retorno, os compromissos já inseridos
            Array.Copy(comps, v, k);
            return v;
        }
    }
}
