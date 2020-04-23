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
            Console.WriteLine("Informe o primeiro horário");
            string hr1 = Console.ReadLine();
            Console.WriteLine("Informe o segundo horário");
            string hr2 = Console.ReadLine();
            // Calcula o total de minutos a partir de 0h (min1, min2)
            int min1 = 0, min2 = 0;
            // Total de munitos do primeiro horário
            switch (hr1)
            {
                case "12:00 AM": min1 = 0; break;
                case "12:00 PM": min1 = 12 * 60; break;
                default:
                    // Número de horas e minutos
                    int h = int.Parse(hr1.Substring(0, 2));
                    int m = int.Parse(hr1.Substring(3, 2));
                    min1 = h * 12 + m;
                    // Verifica se passou de meio dia
                    if (hr1.Substring(6, 2) == "PM") min1 += (12 * 60);
                    break;
            }
            // Total de munitos do segundo horário
            switch (hr2)
            {
                case "12:00 AM": min2 = 0; break;
                case "12:00 PM": min2 = 12 * 60; break;
                default:
                    // Número de horas e minutos
                    int h = int.Parse(hr2.Substring(0, 2));
                    int m = int.Parse(hr2.Substring(3, 2));
                    min2 = h * 12 + m;
                    // Verifica se passou de meio dia
                    if (hr2.Substring(6, 2) == "PM") min2 += (12 * 60);
                    break;
            }
            // Compara os minutos
            if (min1 == min2)
                Console.WriteLine("Os horários são iguais");
            else if (min1 > min2)
                Console.WriteLine($"O maior horário é {hr1}");
            else
                Console.WriteLine($"O maior horário é {hr2}");
            Console.ReadKey();
        }
    }
}
