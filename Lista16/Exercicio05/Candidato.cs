using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Candidato : IComparable
    {
        private string nome;
        private DateTime nascimento;
        private int pontos;
        public Candidato(string nome, DateTime nascimento, int pontos)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.pontos = pontos;
        }
        public override string ToString()
        {
            return $"{nome} - {pontos} - {nascimento}";
        }
        public bool Aprovado()
        {
            return pontos >= 60;
        }
        public int CompareTo(object obj)
        {
            Candidato x = (Candidato)obj;
            // Se a pontuação for maior, retorna -1 para o candidato this
            // aparecer primeiro na listagem em relação ao candidato x
            if (pontos > x.pontos) return -1;
            if (pontos < x.pontos) return 1;
            // Mesma pontuação, compara a data de nascimento
            return nascimento.CompareTo(x.nascimento);
        }
    }
}
