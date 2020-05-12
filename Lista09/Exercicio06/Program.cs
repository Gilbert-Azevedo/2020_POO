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
            Console.WriteLine("Informe o peso do produto em kg");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a distância até o destino em km");
            double d = double.Parse(Console.ReadLine());
            // Calcula o frete
            double f = Frete(p, d);
            Console.WriteLine($"O valor do frete é {f:c2}");
            Console.ReadKey();
        }
        public static double Frete(double massa, double distancia)
        {
            // Calcula o valor do frete com base no peso e distância percorrida
            return 0.01 * massa * distancia;
        }
    }
}
