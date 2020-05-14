using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            // Os parâmetros são passados por referência para que as alterações
            // realizadas dentro do método Ordenar sejam refletidas no método Main
            // Ordenando em ordem crescente
            Ordenar(true, ref a, ref b, ref c);
            Console.WriteLine($"Ordem Crescente  : {a} {b} {c}");
            // Ordenando em ordem decrescente
            Ordenar(false, ref a, ref b, ref c);
            Console.WriteLine($"Ordem Decrescente: {a} {b} {c}");
            Console.ReadKey();
        }
        static void Ordenar(bool crescente, ref int a, ref int b, ref int c)
        {
            // Exemplo análogo ao exercício 15 da lista 02
            // Se a ordem for crescente, a comparação para trocas as posições dos 
            // elementos é feita com o operador >, caso contrário, com o operador <
            int x;
            if (crescente)
            {
                // Compara o primeiro valor (a) com o segundo (b)
                if (a > b) { x = a; a = b; b = x; }
                // Compara o primeiro valor (a) com o terceiro (c)
                if (a > c) { x = a; a = c; c = x; }
                // Compara o segundo valor (b) com o terceiro (c)
                if (b > c) { x = b; b = c; c = x; }
            }
            else
            {
                // Compara o primeiro valor (a) com o segundo (b)
                if (a < b) { x = a; a = b; b = x; }
                // Compara o primeiro valor (a) com o terceiro (c)
                if (a < c) { x = a; a = c; c = x; }
                // Compara o segundo valor (b) com o terceiro (c)
                if (b < c) { x = b; b = c; c = x; }
            }
        }
    }
}
