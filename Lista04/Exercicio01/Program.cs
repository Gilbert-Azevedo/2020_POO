using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:"); 
            string s = Console.ReadLine();
            // Nesse exemplo, a solução mais fácil é utilizar o Split
            string[] v = s.Split();
            // Agora, mostra a segunda palavra, primeira palavra
            Console.WriteLine($"{v[1]}, {v[0]}");
            Console.ReadKey();
        }
    }
}
