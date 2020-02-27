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
            Console.WriteLine("Informe o raio do círculo");
            double r = double.Parse(Console.ReadLine());
            Circulo c = new Circulo();
            Circulo x = c;
            c.SetRaio(r);
            Console.WriteLine($"Raio = {c.GetRaio():0.00}");
            Console.WriteLine($"Raio = {x.GetRaio():0.00}");
            c.SetRaio(15);
            Console.WriteLine($"Raio = {c.GetRaio():0.00}");
            Console.WriteLine($"Raio = {x.GetRaio():0.00}");
            Console.WriteLine($"Área = {x.CalcArea():0.00}");
            Console.WriteLine($"Circunferência = {x.CalcCircunferencia():0.00}");
            Console.WriteLine(c.ToString());
            c = new Circulo();
            c.SetRaio(10);
            Console.WriteLine($"Raio = {c.GetRaio():0.00}");
            Console.WriteLine($"Raio = {x.GetRaio():0.00}");
            Console.ReadKey();
        }
    }
}
