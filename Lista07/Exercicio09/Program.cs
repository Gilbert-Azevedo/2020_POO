using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mais um exemplo que pode ser resolvido com Split para separar as palavras
            // Mas nesse caso, vou utilizar o IndexOf para mostrar outra solução possível
            Console.WriteLine("Digite uma frase com três palavras:");
            string s = Console.ReadLine();
            // Localiza o primeiro espaço no texto
            int x = s.IndexOf(' ');
            // Localiza o segundo espaço no texto. Nesse caso, o espaço é procurado após
            // a posição do primeiro que é x, por isso o argumento x + 1
            int y = s.IndexOf(' ', x + 1);
            // Resultado
            Console.WriteLine($"A sigla é {s[0]}{s[x + 1]}{s[y + 1]}");
            Console.ReadKey();
        }
    }
}
