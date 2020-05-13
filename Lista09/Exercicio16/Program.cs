using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua data de nascimento dd/mm/aaaa");
            string s = Console.ReadLine();
            // Para o método, tem que passar duas variáveis de saída
            int a, m;
            Idade(s, out a, out m);
            Console.WriteLine($"Sua idade: {a} ano(s), {m} mes(es)");
            Console.ReadKey();
        }
        public static void Idade(string nascimento, out int anos, out int meses)
        {
            // Nesse exemplo, é necessário encontrar o mês e ano do nascimento
            string[] v = nascimento.Split('/');
            int m_nasc = int.Parse(v[1]); // mês
            int a_nasc = int.Parse(v[2]); // ano
            // Para encontrar mês e ano da data atual, é necessário usar uma variável
            // DateTime
            DateTime agora = DateTime.Now;
            int m_atual = agora.Month;
            int a_atual = agora.Year;
            // Calcula a diferença de meses e anos, dias são ignorados no cálculo
            meses = m_atual - m_nasc;
            anos = a_atual - a_nasc;
            // Verifica se número de meses está negativo e ajusta os valores
            if (meses < 0)
            {
                meses += 12;
                anos--;
            }
        }

    }
}
