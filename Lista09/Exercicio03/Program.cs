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
            Console.WriteLine("Informe base e altura do retângulo");
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            // Chama o método Diagonal 
            double d = Diagonal(b, h);
            Console.WriteLine($"A diagonal do retângulo é {d}");
            Console.ReadKey();
        }
        public static double Diagonal(double b, double h)
        {
            // Calcula e retorna a diagonal do retângulo
            return Math.Sqrt(b * b + h * h);
        }
    }
}
