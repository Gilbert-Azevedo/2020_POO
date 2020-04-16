using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            // Cálculo da média. Importante dividir por 4.0 para obter um valor real.
            double m = (a + b + c + d) / 4.0;
            Console.WriteLine($"Média = {m}");
            // Verifica os valores menores que a média
            Console.WriteLine("Números menores que a média");
            if (a < m) Console.WriteLine(a);
            if (b < m) Console.WriteLine(b);
            if (c < m) Console.WriteLine(c);
            if (d < m) Console.WriteLine(d);
            // Verifica os valores maiores ou iguais a média
            Console.WriteLine("Números maiores ou iguais a média");
            if (a >= m) Console.WriteLine(a);
            if (b >= m) Console.WriteLine(b);
            if (c >= m) Console.WriteLine(c);
            if (d >= m) Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
