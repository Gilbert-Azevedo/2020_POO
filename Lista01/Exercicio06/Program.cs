using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            // O método Sqrt calcula a raiz quadrada de um número

            Console.WriteLine("Digite a base e a altura do retângulo");
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double a = b * h;
            double p = 2 * b + 2 * h;
            double d = Math.Sqrt(b * b + h * h);
            Console.WriteLine($"Área = {a} - Perímetro = {p} - Diagonal = {d}");
            Console.ReadKey();
        }
    }
}
