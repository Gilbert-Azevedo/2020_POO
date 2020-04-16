using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            // A variável sp vai totalizar a soma dos números pares
            // A variável si vai totalizar a soma dos números pares
            // Toda variável que totaliza uma soma deve iniciar com zero
            int sp = 0, si = 0;
            // Verifica cada um dos números, somando em sp se for par
            // ou em si se for ímpar
            if (a % 2 == 0) sp += a; else si += a;
            if (b % 2 == 0) sp += b; else si += b;
            if (c % 2 == 0) sp += c; else si += c;
            if (d % 2 == 0) sp += d; else si += d;
            Console.WriteLine($"Soma dos pares = {sp}");
            Console.WriteLine($"Soma dos ímpares = {si}");
            Console.ReadKey();
        }
    }
}
