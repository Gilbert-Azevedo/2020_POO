using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            // O índice de massa corporal é dado pela massa dividida pelo quadrado 
			// da altura
            
            Console.WriteLine("Informe sua massa em kg:");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura em metros:");
            double a = double.Parse(Console.ReadLine());
            double imc = m / a / a;
            Console.WriteLine($"Seu IMC é {imc:0.00}");
            Console.ReadKey();
        }
    }
}
