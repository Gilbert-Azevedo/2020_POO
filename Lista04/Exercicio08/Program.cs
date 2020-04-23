using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Digite um horário");
            string s = Console.ReadLine();
            // Nesse caso, é necessário obter o número de horas e minutos e, depois,
            // verificar os limites
            string[] v = s.Split(':');
            int h = int.Parse(v[0]);
            int m = int.Parse(v[1]);
            // Verificação dos limites
            if (h >= 0 && h <= 23 && m >= 0 && m <= 59)
                Console.WriteLine("O horário informado é válido");
            else
                Console.WriteLine("O horário informado é inválido");
            Console.ReadKey();

        }
    }
}
