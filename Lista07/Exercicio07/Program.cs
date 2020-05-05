using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo é análogo ao anterior
            // A difenrença está apenas na entrada dos dados
            // Nesse caso, é necessário separar com Split as dimensões
            // do ambiente e do revestimento

            // Dados do ambiente
            Console.WriteLine("Digite a dimensão do ambiente em metros no formato largura x comprimento:");

            string a = Console.ReadLine();
            // Separa a largura e o comprimento do ambiente
            string[] v = a.Split('x');
            // Converte a largura e o comprimento do ambiente em números,
            // Remove espaços desnecessários com Trim
            double lrgAmb = double.Parse(v[0].Trim());
            double cmpAmb = double.Parse(v[1].Trim());
            // Área do ambiente em centimetros quadrados
            double areaAmb = lrgAmb * 100 * cmpAmb * 100;

            // Dados do revestimento
            Console.WriteLine("Digite a dimensão do revestimento em centímetros no formato largura x comprimento:");
            a = Console.ReadLine();
            // Separa a largura e o comprimento do revestimento
            v = a.Split('x');
            // Converte a largura e o comprimento do revestimento em números,
            // Remove espaços desnecessários com Trim
            double lrgRev = double.Parse(v[0].Trim());
            double cmpRev = double.Parse(v[1].Trim());
            Console.WriteLine("Digite o número de peças por caixa:");
            double n = double.Parse(Console.ReadLine());
            // Área de uma caixa de revestimento
            double areaRev = lrgRev * cmpRev * n;

            // Número de caixas necessárias
            Console.WriteLine($"São necessárias {areaAmb / areaRev:0.0} caixas do revestimento.");
            Console.ReadKey();
        }
    }
}
