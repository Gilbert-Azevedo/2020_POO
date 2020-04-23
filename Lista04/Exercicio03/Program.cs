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
            Console.WriteLine("Informe o salário atual");
            double s = double.Parse(Console.ReadLine());
            double r = 0; // reajuste
            // Verifica as faixas de salário
            if (s < 500) r = 0.2 * s;
            else
                if (s <= 1000) r = 0.15 * s;
                else r = 0.1 * s;
            Console.WriteLine($"Seu novo salário é {s+r:0.00}");
            Console.ReadKey();
        }
    }
}
