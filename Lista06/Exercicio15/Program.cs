using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:"); 
            string s = Console.ReadLine();
            // Nesse exemplo, é necessário dividir a frase num vetor de palavras. Isso
            // pode ser feito com Split. Depois mostra o tamanho de cada palavra.
            string[] v = s.Split();
            // Percorre o vetor de palavras. v.Length é o número de palavras
            for (int k = 0; k < v.Length; k++)
            {
                // Cada palavra da frase
                string p = v[k];
                // Mostra o tamanho da palavra
                Console.Write(p.Length);
            }
            Console.ReadKey();
        }
    }
}
