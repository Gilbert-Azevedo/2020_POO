using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dimensão da matriz
            Console.WriteLine("Informe a dimensão das matrizes");
            Console.Write("Número de linhas: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Número de colunas: ");
            int n = int.Parse(Console.ReadLine());
            // Instancia as matrizes
            int[,] v = new int[m, n];
            int[,] w = new int[n, m];
            // Entrada dos elementos da primeira matriz
            Console.WriteLine("Primeira matriz");
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Informe o elemento A[{i + 1}, {j + 1}]: ");
                    v[i, j] = int.Parse(Console.ReadLine());
                }
            // Cálculo dos elementos da segunda matriz
            for (int i = 0; i < n; i++)       // w tem n linhas e m colunas
                for (int j = 0; j < m; j++)
                    w[i, j] = v[m - j - 1, i];
            // Mostra a primeira matriz
            Console.WriteLine("Matriz A");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{v[i, j],5}");
                Console.WriteLine();
            }
            // Mostra a segunda matriz
            Console.WriteLine("\nMatriz B");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{w[i, j],5}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
