using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Pais : IComparable
    {
        private string nome;
        private int ouro, prata, bronze;
        public Pais(string nome, int ouro, int prata, int bronze)
        {
            this.nome = nome;
            this.ouro = ouro;
            this.prata = prata;
            this.bronze = bronze;
        }
        public override string ToString()
        {
            return $"{nome} - {ouro} - {prata} - {bronze}";
        }
        public int CompareTo(object obj)
        {
            Pais x = (Pais)obj;
            // Se o número de medalhas de ouro for maior, retorna -1 para o país this
            // aparecer primeiro na listagem em relação ao país x
            if (ouro > x.ouro) return -1;
            if (ouro < x.ouro) return 1;
            // Mesmo número de medalhas de ouro, então compara as medalhas de prata
            if (prata > x.prata) return -1;
            if (prata < x.prata) return 1;
            // Mesmo número de medalhas de prata, então compara as medalhas de bronze
            if (bronze > x.bronze) return -1;
            if (bronze < x.bronze) return 1;
            // Mesmo número de medalhas, compara o nome
            return nome.CompareTo(x.nome);
        }
    }
}
