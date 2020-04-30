using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, é necessário testar se o número é múltiplo de 3
            // Quando isso ocorrer, a soma de três elementos da sequência é efetuada:
            // o elemento atual e os dois anteriores. Como em cada iteração o elemento
            // atual é dado por x, os elementos anteriores são x-1 e x-2. Portanto,
            // a soma é: x + (x-1) + (x-2) 
            for (int x = 1; x <= 30; x++)
            {
                // Escreve cada elemento
                Console.Write($"{x} ");
                // Escreva a soma acima quando o elemento for múltiplo de 3
                if (x % 3 == 0) Console.Write($"{x + (x - 1) + (x - 2)} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
