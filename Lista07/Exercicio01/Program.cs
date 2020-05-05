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
            // Nesse exemplo, é necessário calcular a densidade demográfica de um estado
            // que é dada pelo quociente entre sua população e sua área
            Console.WriteLine("Digite o nome do estado: ");
            string s = Console.ReadLine();
            Console.WriteLine("Digite o número de habitantes:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a área do estado em Km2");
            double a = double.Parse(Console.ReadLine());
            double d = h / a;
            Console.WriteLine($"A densidade demográfica do(a) {s} é {d:0.0} hab/km2");
            Console.ReadKey();
        }
    }
}
