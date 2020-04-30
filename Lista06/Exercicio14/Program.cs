using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:"); 
            string s = Console.ReadLine();
            // Nesse exemplo, é necessário dividir a frase num vetor de palavras. Isso
            // pode ser feito com Split. Depois faz o algoritmo da questão 13 em cada palavra
            string[] v = s.Split();
            // Percorre o vetor de palavras. v.Length é o número de palavras
            for (int k = 0; k < v.Length; k++)
            {
                // Cada palavra da frase
                string p = v[k]; 
                // Percorre a palavra do fim até o início
                for (int i = p.Length - 1; i >= 0; i--)
                    Console.Write(p[i]);
                // Pula uma linha para apresentar a palavra seguinte
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
