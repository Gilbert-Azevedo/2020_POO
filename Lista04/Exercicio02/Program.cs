using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string s = Console.ReadLine();
            // Nesse exemplo, a solução mais fácil também é utilizando o Split
            string[] v = s.Split();
            // Agora, mostra a terceira palavra e a inicial das duas primeiras
            // v[x][y] é a letra de número y da palavra x
            Console.WriteLine($"{v[2]}, {v[0][0]}. {v[1][0]}.");
            Console.ReadKey();
        }
    }
}
