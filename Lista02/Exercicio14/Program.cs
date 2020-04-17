using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            // Três valores formam um triângulo quando cada um dos valores é menor
            // que a soma dos outros dois
            if (a < b + c && b < a + c && c < a + b)
            {
                // Se os três lados forem iguais, o triângulo é equilátero
                if (a == b && a == c) Console.WriteLine("O triângulo é equilátero");
                else
                {
                    // Se dois lados forem iguais, o triângulo é isósceles
                    if (a == b || a == c || b == c)
                        Console.WriteLine("O triângulo é isósceles");
                    // Se nenhum lado for igual, o triângulo é escaleno
                    else
                        Console.WriteLine("O triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Esses valores não formam um triângulo");
            }
            Console.ReadKey();
        }
    }
}
