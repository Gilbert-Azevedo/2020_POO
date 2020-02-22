using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class MinhaClasse
    {
        public int x;
        public double Maior(double x, double y)
        {
            return x > y ? x : y;
        }
        public static double Menor(double x, double y)
        {
            return x > y ? x : y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            MinhaClasse r = new MinhaClasse();
            r.x = 5;
            Console.WriteLine(r.Maior(10, 20));
            Console.WriteLine(MinhaClasse.Menor(20, 10));
            Console.ReadKey();
        }
    }
}
