using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia o vetor
            string[] v = new string[10];
            // Entrada dos elementos
            Console.WriteLine("Informe 10 textos para ordenação");
            for (int i = 0; i < 10; i++)
                v[i] = Console.ReadLine();
            // A class Array possui o método Sort para ordenação
            Array.Sort(v);
            // Resultado
            foreach (string i in v)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
