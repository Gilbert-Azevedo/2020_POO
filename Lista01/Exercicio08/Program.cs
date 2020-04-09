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
            // Esse exercício é o Problema do Troco. Ele pode ser resolvido
            // dividindo o valor sucessivamente pelos valores das cédulas,
            // em ordem crescente de valor
            // Quando a quantidade de cédulas de um valor é calculada, o resto 
            // da divisão indica o valor que ainda resta a ser obtido
            
            Console.WriteLine("Digite um valor monetário inteiro");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine($"{valor / 100} cédula(s) de 100 reais");
            valor %= 100;
            Console.WriteLine($"{valor / 50} cédula(s) de 50 reais");
            valor %= 50;
            Console.WriteLine($"{valor / 20} cédula(s) de 20 reais");
            valor %= 20;
            Console.WriteLine($"{valor / 10} cédula(s) de 10 reais");
            valor %= 10;
            Console.WriteLine($"{valor / 5} cédula(s) de 5 reais");
            valor %= 5;
            Console.WriteLine($"{valor / 2} cédula(s) de 2 reais");
            valor %= 2;
            Console.WriteLine($"{valor} moeda(s) de 1 real");
            Console.ReadKey();
        }
    }
}
