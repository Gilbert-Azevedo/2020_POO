using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores inteiros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            // A melhor forma de recuperar o menor valor é armazenar em uma variável auxiliar
            // o primeiro valor e comparar os valores seguintes, um a um, atualizando
            // essa variável, caso um número menor seja encontrado
            int x = a;        // a é o menor valor inicialmente, sendo armazenado em x
            if (b < x) x = b; // x é atualizado se o valor de b é menor
            if (c < x) x = c; // x é atualizado se o valor de c é menor
            // Depois que todos os valores são testados, a variável auxiliar tem o menor número
            // O mesmo algoritmo é usado para recuperar o maior valor, mudando o teste
            int y = a;        // a é o maior valor inicialmente, sendo armazenado em y
            if (b > y) y = b; // y é atualizado se o valor de b é maior
            if (c > y) y = c; // y é atualizado se o valor de c é maior
            // Cálculo do total
            int t = x + y;
            Console.WriteLine($"A soma do maior com o menor número é {t}");
            Console.ReadKey();
        }
    }
}
