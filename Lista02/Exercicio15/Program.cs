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
            // Mais sobre Selection Sort em: https://pt.wikipedia.org/wiki/Selection_sort

            Console.WriteLine("Digite três valores");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            // É possível ordenar uma sequência de números, comparando dois a dois os
            // valores e trocando as suas posições caso o primeiro valor seja maior que 
            // o segundo
            // Para o algoritmo funcionar, todas as combinações de dois números devem 
            // ser realizadas. Esse algoritmo é chamado Selection Sort
            // Uma variável auxiliar é necessária para alternar os números, se necessário
            int x;
            // Compara o primeiro valor (a) com o segundo (b)
            if (a > b)
            {
                // O elemento a é maior que b e está na posição errada. 
                // a tem que trocar de posição com b
                x = a;
                a = b;
                b = x;
            }
            // Compara o primeiro valor (a) com o terceiro (c)
            if (a > c)
            {
                // O elemento a é maior que c e está na posição errada. 
                // a tem que trocar de posição com c
                x = a;
                a = c;
                c = x;
            }
            // Compara o segundo valor (b) com o terceiro (c)
            if (b > c)
            {
                // O elemento b é maior que c e está na posição errada. 
                // b tem que trocar de posição com c
                x = b;
                b = c;
                c = x;
            }
            // a, b e c estão ordenados
            Console.WriteLine($"{a}, {b}, {c}");
            Console.ReadKey();
        }
    }
}
