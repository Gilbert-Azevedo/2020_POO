using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, é só testar se o número é múltiplo de 3 
            for (int x = 1; x <= 30; x++)
                if (x % 3 == 0) Console.Write($"{-x} ");
                else Console.Write($"{x} ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
