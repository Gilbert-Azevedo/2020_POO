using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dimensão da matriz
            Console.WriteLine("Informe a dimensão da matriz");
            int m = int.Parse(Console.ReadLine());
            // Instancia a matriz
            int[,] v = new int[m, m];
            // Entrada dos elementos
            for (int i = 0; i < m; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Informe o elemento [{i + 1}, {j + 1}]: ");
                    v[i, j] = int.Parse(Console.ReadLine());
                }
            // Mostra a matriz 
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{v[i, j],5}");
                Console.WriteLine();
            }
            // Mostra a diagonal secundária
            Console.WriteLine("\nDiagonal secundária");
            for (int i = 0; i < m; i++)
                Console.WriteLine(v[i, m - i - 1]);
            Console.ReadKey();
        }
    }
}
