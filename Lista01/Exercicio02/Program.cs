using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            // O tipo int representa um número inteiro
            // O método Parse faz a conversão de um texto em um número inteiro

            // Mais sobre números inteiros em: https://docs.microsoft.com/pt-br/dotnet/api/system.int32?view=netframework-4.8

            Console.WriteLine("Digite as notas dos dois bimestres da disciplina:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int m = (2 * n1 + 3 * n2) / 5;
            Console.WriteLine($"Média parcial = {m}");
            Console.ReadKey();
        }
    }
}
