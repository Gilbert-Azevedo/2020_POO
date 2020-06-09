using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia o vetor
            int[] v = new int[30];
            // Primeiros elementos
            v[0] = 0;
            v[1] = 1;
            // Demais elementos
            for (int i = 2; i < 30; i++)
                v[i] = v[i - 2] + v[i - 1];
            // Resultado
            foreach (int i in v) 
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
