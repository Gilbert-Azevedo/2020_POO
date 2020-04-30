using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, é necessário uma repetição para o primeiro elemento
            for (int i = 1; i <= 10; i++) 
            {
                Console.Write(i + " ");
                // E uma repetição aninhada (dentro da primeira) para o segundo elemento
                // O detalhe é que o segundo elemento inicia em 2
                // e termina no valor do primeiro
                for (int j = 2; j <= i; j++)
                {
                    if (j % 2 == 0) Console.Write(j + " "); // Mostra apenas se for par
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
