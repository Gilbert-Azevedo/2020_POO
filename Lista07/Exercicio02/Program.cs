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
            // Nesse exemplo, é necessário calcular o consumo médio em km/litro
            // e o custo médio em R$/km
            Console.WriteLine("Digite o valor gasto com o combustível em reais:");
            double precoTotal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do litro do combustível em reais:");
            double precoLitro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a distância percorrida em quilômetros");
            double distancia = double.Parse(Console.ReadLine());
            // Número de litros
            double numLitros = precoTotal / precoLitro;
            // Consumo médio em km / litro
            Console.WriteLine($"O consumo médio é de {distancia/numLitros:0.00} Km por litro");
            // Valor gasto por km percorrido
            Console.WriteLine($"O gasto por Km percorrido é {precoTotal/distancia:c2}");
            Console.ReadKey();
        }
    }
}
