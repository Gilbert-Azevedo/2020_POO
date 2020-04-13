using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Há quantos anos você fuma?");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos cigarros por dia?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço da carteira de cigarros?");
            double p = double.Parse(Console.ReadLine());
            // Valor de um cigarro
            double c = p / 20;
            // Número de cigarros fumados
            double nc = n * a * 365;
            // Total gasto
            double t = c * nc;
            Console.WriteLine($"Total gasto = {t:c2}");
            Console.ReadKey();
        }
    }
}
