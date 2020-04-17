using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{

    // Enumeração com nomes dos meses
    enum mes
    {
        janeiro = 1, fevereiro, março, abril, maio, junho, julho, agosto,
        setembro, outubro, novembro, dezembro
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string s = Console.ReadLine();
            // É possível obter dia, mes e ano com Split ou Substring
            string[] v = s.Split('/');
            int d = int.Parse(v[0]);
            int m = int.Parse(v[1]);
            int a = int.Parse(v[2]);
            // Converte o inteiro m com o número do mês para a variável do tipo mes
            mes x = (mes)m;
            Console.WriteLine($"A data é {d:00} de {x.ToString()} de {a:0000}");
            Console.ReadKey();
        }
    }
}
