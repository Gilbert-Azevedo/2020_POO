using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class QuadroMedalhas
    {
        private Pais[] paises = new Pais[2];
        private int k;
        public void Inserir(Pais p)
        {
            // Duplica o tamanho do vetor, caso já tenha sido todo preenchido
            if (k == paises.Length) Array.Resize(ref paises, paises.Length * 2);
            // Insere o país e incrementa o contador
            paises[k++] = p;
        }
        public Pais[] Listar()
        {
            // Instancia um vetor com a quantidade de elementos já inseridos
            Pais[] v = new Pais[k];
            // Copia os elementos do vetor paises para o vetor de retorno
            Array.Copy(paises, v, k);
            // Ordena o vetor de acordo com o IComparable de países
            Array.Sort(v);
            return v;
        }
    }
}
