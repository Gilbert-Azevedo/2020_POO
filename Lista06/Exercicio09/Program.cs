using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine(); 
            // Nesse exemplo, é necessário fazer a repetição de acordo com o número
            // de caracteres da frase: Length, mostrando também o contador da repetição 
            for (int i = 1; i <= s.Length; i++)
                Console.WriteLine($"{i} - {s}");
            Console.ReadKey();
        }
    }
}
