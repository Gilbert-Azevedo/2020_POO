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
            // Dados do abastecimento
            Abastecimento d = new Abastecimento();
            Console.WriteLine("Informe o valor do litro de combustível");
            d.SetValorLitro(double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe o valor pago no abastecimento");
            d.SetValorPago(double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe a distância percorrida");
            d.SetKmRodados(double.Parse(Console.ReadLine()));
            // Calcula as médias e mostra o resultado
            Console.WriteLine($"O consumo médio do veículo foi {d.MediaKmLitro():0.0} km/l");
            Console.WriteLine($"O gasto médio de cada km foi {d.MediaReaisKm():0.00} reais");
            Console.ReadKey();
        }
    }
}
