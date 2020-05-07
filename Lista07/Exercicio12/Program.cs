using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, basta ler a placa do veículo e testar o último caractere
            Console.WriteLine("Informe a placa do veículo");
            string s = Console.ReadLine();
            // Último caractere
            char c = s[s.Length - 1];
            // Testa o caractere
            switch (c)
            {
                case '1':
                case '2': Console.WriteLine("Fevereiro"); break;
                case '3':
                case '4': Console.WriteLine("Março"); break;
                case '5':
                case '6': Console.WriteLine("Abril"); break;
                case '7':
                case '8': Console.WriteLine("Maio"); break;
                case '9':
                case '0': Console.WriteLine("Junho"); break;
            }
            Console.ReadKey();
        }
    }
}
