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
            Console.WriteLine("Digite a data do aniversário");
            string s = Console.ReadLine();
            // Obtém o dia e o mês da data
            int d = int.Parse(s.Substring(0, 2));
            int m = int.Parse(s.Substring(3, 2));
            // Calcula o maior dia possível do mês
            int max = 31;
            switch (m)
            {
                case 2: max = 29; break;
                case 4:
                case 6:
                case 9:
                case 11: max = 30; break;
            }
            // Verifica o dia e o mês
            if (d >= 1 && d <= max && m >= 1 && m <= 12)
                Console.WriteLine("A data informada é válida");
            else
                Console.WriteLine("A data informada é inválida");
            Console.ReadKey();
        }
    }
}
