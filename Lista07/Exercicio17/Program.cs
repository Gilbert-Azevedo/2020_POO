using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Neste exemplo, é necessário fazer uma repetição de 0 a 120, 
            // variando de 10 em 10. Esses são os valores da temperatura em Celsius
            // Para cada valor, calcula o equivalente em Fahrenheit
            for (int c = 0; c <= 120; c += 10)
            {
                double f = 9.0 / 5 * c + 32;
                Console.WriteLine($"{c}ºC = {f}ºF");
            }
            Console.ReadKey();
        }
    }
}
