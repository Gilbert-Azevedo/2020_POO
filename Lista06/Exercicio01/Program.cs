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
            // As repetições podem ser feitas com quaisquer das estruturas
            // 1 for, 2 while, 3 do-while 
            // Repetição com for
            for (int x = 1; x <= 10; x++)
                Console.Write($"{x} ");
            Console.WriteLine();
            // Repetição com while
            int y = 1;
            while(y <= 10)
            {
                Console.Write($"{y} ");
                y++;
            }
            Console.WriteLine();
            // Repetição com do-while
            int z = 1;
            do
            {
                Console.Write($"{z} ");
                z++;
            } while (z <= 10);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
