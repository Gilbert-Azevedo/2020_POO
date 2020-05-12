using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome");
            string x = Console.ReadLine();
            // Chama o método que retorna as iniciais
            string r = Iniciais(x);
            Console.WriteLine($"As inicias de seu nome são {r}");
            Console.ReadKey();
        }
        public static string Iniciais(string s)
        {
            // Uma solução possível é incluir a primeira letra e as letras subsequentes
            // a um espaço
            string r = s[0].ToString(); // Primeira letra
            // Percorre a string para localizar os espaços
            for (int i = 0; i < s.Length; i++)
                // Quando encontrar um espaço na posição i, insere a letra na posição i + 1
                if (s[i] == ' ') r += s[i + 1];
            return r;
        }
    }
}
