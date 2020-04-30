using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine(); 
            // Nesse exemplo, basta contar o número de espaços na string e adicionar um
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // Recupera cada caractere da string
                char c = s[i];
                // Teste se é espaço
                if (c == ' ') total++;
            }
            Console.WriteLine(total + 1);
            Console.ReadKey();
        }
    }
}
