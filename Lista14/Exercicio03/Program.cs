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
            // Instancia o vetor
            int[] v = new int[30];
            // Entrada dos elementos
            Console.WriteLine("Informe 10 valores inteiros");
            for (int i = 0; i < 10; i++)
                v[i] = int.Parse(Console.ReadLine());
            // Menor elemento inicia com o primeiro elemento
            int m = v[0];
            // Verifica os demais elementos
            for (int i = 1; i < 10; i++)
                if (v[i] < m) m = v[i];
            // Resultado
            Console.WriteLine($"Menor elemento = {m}");
            Console.ReadKey();
        }
    }
}
