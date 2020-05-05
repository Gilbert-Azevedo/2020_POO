using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, é necessário encontrar os operandos para efetuar o produto
            // Isso pode ser feito com o Split usando a vírgula como separador
            Console.WriteLine("Digite três valores separados por vírgulas:");
            string s = Console.ReadLine();
            string[] v = s.Split(',');
            // Primeiro operando
            int x = int.Parse(v[0]);
            // Segundo operando
            int y = int.Parse(v[1]);
            // Terceiro operando
            int z = int.Parse(v[2]);
            // Resultado
            Console.WriteLine($"O produto entre os valores é {x * y * z}");
            Console.ReadKey();
        }
    }
}
