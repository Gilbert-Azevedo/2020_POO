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
            // Instancia o vetor
            int[] v = new int[10];
            // Entrada dos elementos
            Console.WriteLine("Informe 10 valores inteiros");
            for (int i = 0; i < 10; i++)
                v[i] = int.Parse(Console.ReadLine());
            // A class Array possui o método Sort para ordenação
            Array.Sort(v);
            // E um para inverter a ordem
            Array.Reverse(v);
            // Resultado
            foreach (int i in v)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
