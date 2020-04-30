using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:"); 
            string s = Console.ReadLine();
            // Nesse exemplo, é necessário dividir a frase num vetor de palavras. 
            // E depois fazer a contagem das vogais, como no Exercício 16, para cada palavra
            // Finalmente, repetir a palavra de acordo com o valor do contador
            // Vetor de palavras
            string[] v = s.Split();
            // Percorre o vetor de palavras. v.Length é o número de palavras
            for (int k = 0; k < v.Length; k++)
            {
                // Apenas um contador é necessário 
                int vg = 0;
                // Percorre os caracteres, usando um foreach (pode ser feito como no Exercício 16, também)
                foreach (char c in v[k])
                    switch (c.ToString().ToLower()) // Passa o caractere para minúsculo antes de testar
                    {
                        case "a":
                        case "e":
                        case "i":
                        case "o":
                        case "u": vg++; break; // Incrementa o contador qdo uma vogal é encontrada
                    }
                // Repete a palavra de acordo com o contador
                for (int i = 0; i < vg; i++)
                    Console.Write($"{v[k]} ");
            }
            Console.ReadKey();
        }
    }
}
