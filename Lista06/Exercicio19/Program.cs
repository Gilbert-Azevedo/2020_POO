using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, é necessário uma repetição para o primeiro elemento
            for (int x = 1; x <= 10; x++) 
            {
                Console.WriteLine($"Tabuada de {x}");
                // E uma repetição aninhada (dentro da primeira) para o segundo elemento
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{x} x {y} = {x * y}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
