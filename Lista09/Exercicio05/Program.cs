using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe altura, largura e profundidade em metros");
            double h = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            // Chama o método VolumeLitros que retorna o valor do volume
            double v = VolumeLitros(h, l, p);
            Console.WriteLine($"O volume da caixa d´água é {v} litros");
            Console.ReadKey();
        }
        public static double VolumeLitros(double h, double l, double p)
        {
            // Calcula e retorna o volume da caixa em litros
            return h * l * p * 1000;
        }
    }
}
