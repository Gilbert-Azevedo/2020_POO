using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // O tipo double representa um número real
            // O método Parse faz a conversão de um texto em um número inteiro
            // A classe Math implementa várias operações da matemática
            // A constante PI retorna o valor de pi que é a razão entre a circunferência e o
            // diâmetro de um círculo

            // Mais sobre números reais em: https://docs.microsoft.com/pt-br/dotnet/api/system.double?view=netframework-4.8
            // Mais sobre a classe Math em: https://docs.microsoft.com/pt-br/dotnet/api/system.math?view=netframework-4.8

            Console.WriteLine("Digite o raio de um círculo:");
            double r = double.Parse(Console.ReadLine());
            double c = 2 * Math.PI * r;
            double a = Math.PI * r * r;
            Console.WriteLine($"Circunferência = {c:0.00}");
            Console.WriteLine($"Área = {a:0.00}");
            Console.ReadKey();
        }
    }
}
