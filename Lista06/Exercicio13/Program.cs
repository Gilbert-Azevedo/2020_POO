using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine(); 
            // Nesse exemplo, basta percorrer a string iniciando na última posição (Length-1)
            // voltando até a primeira (0)
            for (int i = s.Length - 1; i >= 0; i--)
                Console.Write(s[i]);
            Console.ReadKey();
        }
    }
}
