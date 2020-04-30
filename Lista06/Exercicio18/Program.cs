using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de números separados por vírgula:");
            string s = Console.ReadLine(); 
            // Nesse exemplo, é necessário dividir a frase num vetor de palavras. Isso
            // pode ser feito com Split. Depois converte cada palavra em um número e soma
            string[] v = s.Split(','); // A vírgula é o separador
            // Somador
            int soma = 0;
            // Percorre o vetor de palavras. v.Length é o número de palavras
            for (int k = 0; k < v.Length; k++)
            {
                // Cada palavra da frase
                string p = v[k];
                // Soma cada número depois de converter em inteiro
                soma += int.Parse(p);
            }
            Console.WriteLine($"Soma = {soma}");
            Console.ReadKey();
        }
    }
}
