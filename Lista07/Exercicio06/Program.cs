using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, é necessário obter o quociente entre a área do ambiente
            // e a área de uma caixa de revestimento
            // Para isso, é necessário que as unidades de medida sejam iguais
            // Portanto, todas as unidades serão convertidas para centímetros

            // Dados do ambiente
            Console.WriteLine("Digite a largura do ambiente em metros:");
            double lrgAmb = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do ambiente em metros:");
            double cmpAmb = double.Parse(Console.ReadLine());
            // Área do ambiente em centimetros quadrados
            double areaAmb = lrgAmb * 100 * cmpAmb * 100;

            // Dados do revestimento
            Console.WriteLine("Digite a largura do revestimento em centímetros:");
            double lrgRev = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do revestimento em centímetros:");
            double cmpRev = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de peças por caixa:");
            double n = double.Parse(Console.ReadLine());
            // Área de uma caixa de revestimento
            double areaRev = lrgRev * cmpRev * n;

            // Número de caixas necessárias
            Console.WriteLine($"São necessárias {areaAmb/areaRev:0.0} caixas do revestimento.");
            Console.ReadKey();
        }
    }
}
