using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
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
            int[,] w = new int[m, n];
            // Entrada dos elementos da primeira matriz
            Console.WriteLine("Primeira matriz");
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Informe o elemento A[{i + 1}, {j + 1}]: ");
                    v[i, j] = int.Parse(Console.ReadLine());
                }
            // Entrada dos elementos da segunda matriz
            Console.WriteLine("Segunda matriz");
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Informe o elemento B[{i + 1}, {j + 1}]: ");
                    w[i, j] = int.Parse(Console.ReadLine());
                }
            // Cálculo da matriz de resultados
            int[,] x = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    x[i, j] = v[i, j] + w[i, j];
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
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{w[i, j],5}");
                Console.WriteLine();
            }
            // Mostra a matriz soma
            Console.WriteLine("\nMatriz A + B");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{x[i, j],5}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
