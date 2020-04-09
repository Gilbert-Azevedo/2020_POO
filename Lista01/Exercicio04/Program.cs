using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // A nota para passar é calculada isolando a variável n4 na equação
            // de cálculo da média, considerando a média igual a 60
            // m = (2 * n1 + 2 * n2 + 3 * n3 + 3 * n4) / 10 = 60

            Console.WriteLine("Digite as notas dos três primeiros bimestres");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = (600 - 2 * n1 - 2 * n2 - 3 * n3) / 3;
            Console.WriteLine($"Nota para passar = {n4}");
            Console.ReadKey();
        }
    }
}
