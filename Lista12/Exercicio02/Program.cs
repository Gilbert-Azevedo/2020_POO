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
            Retangulo r = new Retangulo();
            Console.WriteLine("Informe o valor da base");
            r.SetBase(double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe o valor da altura");
            r.SetAltura(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Base = {r.GetBase()}");
            Console.WriteLine($"Altura = {r.GetAltura()}");
            Console.WriteLine($"Área = {r.CalcArea()}");
            Console.WriteLine($"Diagonal = {r.CalcDiagonal()}");
            Console.ReadKey();

        }
    }
}
