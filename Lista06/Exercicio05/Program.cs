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
            // Nesse exemplo, é necessário utilizar uma variável (k) para ser a parcela
            // somada em cada iteração. E em cada iteração, o valor de k também é
            // incrementado 
            int k = 1;
            for (int x = 1; x <= 46; x += k, k++)
                Console.Write($"{x} ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
