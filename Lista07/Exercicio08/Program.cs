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
            // Mais um exemplo que pode ser resolvido com Split para separar os operadores
            // da operação
            Console.WriteLine("Digite três valores reais separados por ponto e vírgulas:");
            string s = Console.ReadLine();
            string[] v = s.Split(';');
            // Converte as strings em números
            double x = double.Parse(v[0]);
            double y = double.Parse(v[1]);
            double z = double.Parse(v[2]);
            Console.WriteLine($"A soma entre os valores é {x + y + z}");
            Console.ReadKey();
        }
    }
}
