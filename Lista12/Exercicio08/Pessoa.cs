using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Pessoa
    {
        private string nome;
        private DateTime nascimento;
        public void SetNome(string n) {
            nome = n;
        }
        public void SetNascimento(DateTime d) {
            nascimento = d;
        }
        public string GetNome() {
            return nome;
        }
        public DateTime GetNascimento() {
            return nascimento;
        }
        public int Idade() {
            DateTime hoje = DateTime.Now;
            DateTime n = nascimento;
            if ( hoje.Month > n.Month ||
                 (hoje.Month == n.Month && hoje.Day >= n.Day)
               )
                return hoje.Year - n.Year;
            else
                return hoje.Year - n.Year - 1;
        }

        public string Iniciais()
        {
            return nome[0].ToString();
        }
    }
}
