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
            Console.WriteLine("Digite quatro valores inteiros diferentes");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            // Verificar se algum número está repetido
            if (a == b || a == c || a == d || b == c || b == d || c == d)
                Console.WriteLine("Algum número está repetido");
            else
            {
                // Menor valor - Mesmo algoritmo do Exercício 06
                int x = a;
                if (b < x) x = b;
                if (c < x) x = c;
                if (d < x) x = d;
                // Maior valor - Mesmo algoritmo do Exercício 06
                int y = a;
                if (b > y) y = b;
                if (c > y) y = c;
                if (d > y) y = d;
                // Soma do segundo maior com segundo menor
                int s = a + b + c + d - x - y;
                Console.WriteLine($"Maior valor = {y}");
                Console.WriteLine($"Menor valor = {x}");
                Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {s}");
            }
            Console.ReadKey();
        }
    }
}
