using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mais sobre if-else em: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/if-else

            Console.WriteLine("Digite dois valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            // Solução usando apenas if
            if (a == b) Console.WriteLine("Números iguais");
            if (a > b) Console.WriteLine($"Maior = {a}");
            if (a < b) Console.WriteLine($"Maior = {b}");
            // Solução usando if-else
            if (a == b) Console.WriteLine("Números iguais");
            else
              if (a > b) Console.WriteLine($"Maior = {a}");
            else Console.WriteLine($"Maior = {b}");
            Console.ReadKey();
        }
    }
}
