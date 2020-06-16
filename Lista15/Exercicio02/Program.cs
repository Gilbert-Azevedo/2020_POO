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
            // Inicia um bingo com 10 números
            Bingo b = new Bingo();
            b.Iniciar(10);
            // Sorteia os 10 números
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            Console.WriteLine(b.Proximo());
            // Sequencia de sorteio
            foreach (int n in b.Sorteados())
                Console.Write(n + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
