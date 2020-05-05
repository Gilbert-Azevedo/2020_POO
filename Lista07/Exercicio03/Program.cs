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
            // Nesse exemplo, é necessário encontrar os operandos para efetuar a soma
            // Isso pode ser feito com o Split usando o '+' como separador
            Console.WriteLine("Digite a operação no formato op1+op2:");
            string s = Console.ReadLine();
            string[] v = s.Split('+');
            // Primeiro operando
            int x = int.Parse(v[0]);
            // Segundo operando
            int y = int.Parse(v[1]);
            // Resultado
            Console.WriteLine($"Soma = {x + y}");
            Console.ReadKey();
        }
    }
}
