using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // A classe Console é utilizada para as operações básicas 
            // de entrada e saída
            // O método WriteLine é usado para mostrar dados na saída padrão
            // O método ReadLine é usado para ler um texto da entrada padrão
            // O método ReadKey é usado para ler um caractere. No exemplo,
            // pausa a execução do programa impedindo a janela de saída ser fechada
            // O tipo string representa um texto

            // Mais sobre Console em: https://docs.microsoft.com/pt-br/dotnet/api/system.console?view=netframework-4.8
            // Mais sobre string em: https://docs.microsoft.com/pt-br/dotnet/api/system.string?view=netframework-4.8

            Console.WriteLine("Digite seu nome:");
            string s = Console.ReadLine();
            Console.WriteLine($"Bem-vindo ao C#, {s}");
            Console.ReadKey();
        }
    }
}
