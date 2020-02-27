using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Informe o valor da base:");
            double.Parse(Console.ReadLine());
            r.SetBase(10);
            Console.WriteLine($"Base = {r.GetBase():0.00}");
            Console.ReadKey();
        }
    }
}
