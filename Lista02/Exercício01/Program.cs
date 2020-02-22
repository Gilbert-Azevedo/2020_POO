using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a == b) Console.WriteLine("Números Iguais");
            if (a > b) Console.WriteLine(a);
            if (a < b) Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
