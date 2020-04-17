using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mais sobre IndexOf em:  https://docs.microsoft.com/pt-br/dotnet/api/system.string.indexof?view=netframework-4.8

            Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
            string s = Console.ReadLine();
            // Nesse caso é necessário encontrar o operador no texto. Isso pode ser
            // feito com o método IndexOf. Qdo o resultado de IndexOf for -1, o caractere
            // que está sendo procurado não foi encontrado. Caso contrário, o resultado
            // informa a posição do caractere no texto
            int p = s.IndexOf('+');          // Procura o + no texto
            if (p == -1) p = s.IndexOf('+'); // Se não encontrou, procura o -
            if (p == -1) p = s.IndexOf('*'); // Se não encontrou, procura o *
            if (p == -1) p = s.IndexOf('/'); // Se não encontrou, procura o /
            // Separa os operando no texto: o primeiro operando está antes do operador
            // iniciando na posição 0, com comprimento = p; o segundo, inicia na posição p + 1
            int x = int.Parse(s.Substring(0, p));  // Primeiro operando
            int y = int.Parse(s.Substring(p + 1)); // Segundo operando
            // Testa o operador na posição p e realiza a operação
            int z = 0;
            switch(s[p])
            {
                case '+': z = x + y; break;
                case '-': z = x - y; break;
                case '*': z = x * y; break;
                case '/': z = x / y; break;
            }
            Console.WriteLine($"O resultado da operação é {z}");
            Console.ReadKey();
        }
    }
}
