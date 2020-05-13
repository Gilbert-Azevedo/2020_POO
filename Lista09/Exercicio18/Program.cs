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
            Console.WriteLine("Informe um número inteiro positivo");
            int n = int.Parse(Console.ReadLine());
            if (Primo(n)) Console.WriteLine($"O número {n} é primo");
            else Console.WriteLine($"O número {n} não é primo");
            Console.ReadKey();
        }
        public static bool Primo(int n)
        {
            // Para verificar se um número é primo é necessário verificar se há
            // algum divisor entre 2 e a raiz quadrada desse número
            // Se existir, ele não é primo
            bool p = true;
            for (int d = 2; d <= Math.Sqrt(n); d++)
                // Se encontrar um divisor, não precisa continuar
                if (n % d == 0) { p = false; break; } 
            return p;
        }
    }
}
