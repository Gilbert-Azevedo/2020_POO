using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, pode usar uma variável auxiliar que fique alternando
            // o sinal, ou pode testar se o número é par
            // Usando uma variável auxiliar 
            int aux = 1;
            for (int x = 1; x <= 10; x++, aux = -aux)
                Console.Write($"{x * aux} ");
            Console.WriteLine();
            // Testando se o número é par
            for (int x = 1; x <= 10; x++)
                if (x % 2 == 0) Console.Write($"{-x} ");
                else Console.Write($"{x} ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
