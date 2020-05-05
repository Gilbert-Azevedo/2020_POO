using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, é necessário dividir o texto encontrando as palavras
            // Novamente, utilizando o Split
            // Depois mostra o tamanho de cada palavra
            Console.WriteLine("Digite uma frase com três palavras:");
            string s = Console.ReadLine();
            string[] v = s.Split();
            Console.Write(v[0].Length);
            Console.Write(v[1].Length);
            Console.Write(v[2].Length);
            Console.ReadKey();
        }
    }
}
