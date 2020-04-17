using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dez valores inteiros");
            string s = Console.ReadLine();
            // Nesse caso, é melhor usar o Split para separar os valores
            string[] v = s.Split();
            // Passando os valores para inteiro para encontrar o maior e o menor
            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);
            int c = int.Parse(v[2]);
            int d = int.Parse(v[3]);
            int e = int.Parse(v[4]);
            int f = int.Parse(v[5]);
            int g = int.Parse(v[6]);
            int h = int.Parse(v[7]);
            int i = int.Parse(v[8]);
            int j = int.Parse(v[9]);
            // Menor valor - Mesmo algoritmo do Exercício 06
            int x = a;
            if (b < x) x = b;
            if (c < x) x = c;
            if (d < x) x = d;
            if (e < x) x = e;
            if (f < x) x = f;
            if (g < x) x = g;
            if (h < x) x = h;
            if (i < x) x = i;
            if (j < x) x = j;
            // Maior valor - Mesmo algoritmo do Exercício 06
            int y = a;
            if (b > y) y = b;
            if (c > y) y = c;
            if (d > y) y = d;
            if (e > y) y = e;
            if (f > y) y = f;
            if (g > y) y = g;
            if (h > y) y = h;
            if (i > y) y = i;
            if (j > y) y = j;
            Console.WriteLine($"O maior valor é {y} e o menor é {x}");
            Console.ReadKey();
        }
    }
}
