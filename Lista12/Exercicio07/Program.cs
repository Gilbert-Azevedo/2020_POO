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
            // Referência para o objeto 
            Data x;
            // Dados do objeto
            Console.WriteLine("Informe o dia");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o mês");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano");
            int a = int.Parse(Console.ReadLine());
            // Instancia o objeto. Se os dados correspondem a uma data válida
            // eles são armazenados pelo construtor
            x = new Data(d, m, a);
            // Mostra os dados armazenados
            Console.WriteLine($"Dia = {x.GetDia()}");
            Console.WriteLine($"Mês = {x.GetMes()}");
            Console.WriteLine($"Ano = {x.GetAno()}");
            Console.WriteLine($"Data = {x}");
            Console.ReadKey();
        }
    }
}
