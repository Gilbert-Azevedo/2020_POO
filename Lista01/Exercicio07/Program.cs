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
            // O método Split é usado para dividir um texto de acordo com um separador
            // No exemplo, o separador é o caractere ',' do valor
            // O primeiro elemento tem o número de reais
            // O segundo elemento tem o número de centavos

            Console.WriteLine("Digite um valor monetário:");
            string s = Console.ReadLine();
            string[] v = s.Split(',');
            Console.WriteLine($"{v[0]} reais e {v[1]} centavos");
            Console.ReadKey();
        }
    }
}
