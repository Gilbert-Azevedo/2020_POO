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
            Console.WriteLine("Informe o raio do círculo");
            double r = double.Parse(Console.ReadLine());
            // Chama o método AreaCirculo que retorna o valor da área
            double a = AreaCirculo(r);
            Console.WriteLine($"A área do círculo é {a}");
            Console.ReadKey();
        }
        public static double AreaCirculo(double raio)
        {
            // Calcula e retorna a área do círculo
            return Math.PI * raio * raio;
        }
    }
}
