using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            // Se a for zero, não é uma equação do II grau
            if (a == 0)
                Console.WriteLine("A equação não é do II grau");
            else
            {
                // Quando a não for zero, é necessário utilizar a fórmula de Bhaskara
                // e calcular o valor de delta
                double delta = b * b - 4 * a * c;
                // Se o delta for negativo, não tem raízes reais
                if (delta < 0)
                    Console.WriteLine("Impossível calcular, a equação não tem raízes reais");
                else
                {
                    // Cálculo das raízes
                    double x1 = (-b + Math.Sqrt(delta)) / 2 / a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 / a;
                    Console.WriteLine($"As raízes são {x1} e {x2}");
                }
            }
            Console.ReadKey();
        }
    }
}
