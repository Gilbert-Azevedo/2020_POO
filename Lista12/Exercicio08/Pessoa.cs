using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Pessoa
    {
        // Atributos
        private string nome;
        private DateTime nascimento;
        // Métodos de acesso
        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetNascimento(DateTime d)
        {
            nascimento = d;
        }
        public string GetNome()
        {
            return nome;
        }
        public DateTime GetNascimento()
        {
            return nascimento;
        }
        // Métodos de cálculo
        public int Idade()
        {
            // Nesse método é calculado a idade em anos
            // Para encontrar ano da data atual, é necessário usar uma variável
            // DateTime
            DateTime agora = DateTime.Now;
            int a_atual = agora.Year;
            // Calcula a diferença de anos, dias e meses são ignorados no cálculo
            int anos = a_atual - nascimento.Year;
            // Retorna a idade
            return anos;
        }
    }
}
