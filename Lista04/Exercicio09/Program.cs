using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Informe quatro valores inteiros diferentes");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            // Como são apenas 4 valores, a forma mais simples é ordenar os números
            // e isso pode ser feito utilizando o algoritmo Seleciotion Sort
            // de forma análoga ao Exercício 15 da Lista 2
            // Neste caso, é necessário testar todas as combinações de 2 números:
            // ab, ac, ad, bc, bd, cd
            int x;
            if (a > b) { x = a; a = b; b = x; }
            if (a > c) { x = a; a = c; c = x; }
            if (a > d) { x = a; a = d; d = x; }
            if (b > c) { x = b; b = c; c = x; }
            if (b > d) { x = b; b = d; d = x; }
            if (c > d) { x = c; c = d; d = x; }
            // Os números estão ordenados em ordem crescente
            Console.WriteLine($"A soma dos dois menores valores é {a+b}");
            Console.ReadKey();
        }
    }
}
