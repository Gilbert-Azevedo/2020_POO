using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio da esfera");
            double r = double.Parse(Console.ReadLine());
            // Chama o método VolumeEsfera que retorna o valor do volume
            double v = VolumeEsfera(r);
            Console.WriteLine($"O volume da esfera é {v}");
            Console.ReadKey();
        }
        public static double VolumeEsfera(double r)
        {
            // Calcula e retorna o volume da esfera
            return 4 * Math.PI * r * r * r / 3;
        }
    }
}
