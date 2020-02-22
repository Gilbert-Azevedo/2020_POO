using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        public static void AntecessorSucessor(int x,
            out int antecessor, out int sucessor)
        {
            antecessor = x - 1;
            sucessor = x + 1;
        }
        static void Main(string[] args)
        {
            int a, b;
            AntecessorSucessor(5, out a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
