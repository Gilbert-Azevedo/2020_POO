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
            // Todo vetor é um objeto e precisa ser instanciado. Na construção,
            // é informado o número de elementos do vetor
            int[] v = new int[30];
            // Primeiro elemento
            v[0] = 1;
            // Demais elementos
            for (int i = 1; i < 30; i++)
                v[i] = 2 * v[i - 1];
            // Resultado
            // Mostrando com um for: i é o índice
            for (int i = 0; i < 30; i++) Console.Write(v[i] + " ");
            Console.WriteLine();
            // Mostrando com um foreach: i é o elemento
            foreach (int i in v) Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
