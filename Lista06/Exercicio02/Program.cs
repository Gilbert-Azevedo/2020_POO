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
            // Nesse exemplo, a variável é decrementada em cada iteração
            // Repetição com for 
            for (int x = 10; x > 0; x--)
                Console.Write($"{x} ");
            Console.ReadKey();
        }
    }
}
