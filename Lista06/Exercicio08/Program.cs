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
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine();
            // Solução 1 - Utilizando o Split 
            // Nesse caso, você pode encontrar as palavras da frase e, em cada palavra,
            // pegar a letra na última posição
            string[] v = s.Split();
            // O número de palavras é dado pelo tamanho do vetor v: v.Length
            for (int i = 0; i < v.Length; i++)
            {
                string p = v[i];          // Cada palavra da frase
                char c = p[p.Length - 1]; // Última letra de cada palavra
                Console.Write(c);
                //Console.Write(v[i][v[i].Length - 1]); // Sem as variáveis p e c
            }
            Console.WriteLine();
            // Solução 2 - Utilizando o indexador []
            // Nesse, basta mostrar as letras antes de um espaço e a última letra
            // Mais simples ainda, se incluir um espaço no fim da frase
            s = s + " ";
            for (int i = 0; i < s.Length; i++)
                if (s[i] == ' ')              // Na posição i tem um espaço
                    Console.Write(s[i - 1]);  // Mostra a posição i - 1
             Console.ReadKey();
        }
    }
}
