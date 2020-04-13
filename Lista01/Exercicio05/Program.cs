using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            // O método Split é usado para dividir um texto de acordo com um separador
            // No exemplo, o separador é o caractere '/' da data
            // O resultado do Split é um vetor de strings em que cada
            // elemento é acessado com um índice que inicia em zero
            // O método Substring é usado para recuperar parte de um texto

            // Mais sobre Split em: https://docs.microsoft.com/pt-br/dotnet/api/system.string.split?view=netframework-4.8
            // Mais sobre Substring em: https://docs.microsoft.com/pt-br/dotnet/api/system.string.substring?view=netframework-4.8

            Console.WriteLine("Digite sua data de nascimento:");
            string s = Console.ReadLine();
            string[] x = s.Split('/');
            // O terceiro elemento possui o valor do ano necessário para o cálculo do exercício  
            // int d = int.Parse(x[0]); // dia - não necessário no exemplo
            // int m = int.Parse(x[1]); // mês - não necessário no exemplo
            int a = int.Parse(x[2]); // ano
            // Como recuperar dia, mês e ano com Substring
            // int d = int.Parse(s.Substring(0, 2));
            // int m = int.Parse(s.Substring(3, 2));
            // int a = int.Parse(s.Substring(6));
            Console.WriteLine($"Em 31/12/2020 você terá {2020 - a} anos");
            Console.ReadKey();
        }
    }
}
