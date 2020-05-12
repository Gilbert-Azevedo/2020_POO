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
            // Mais sobre o algoritmo de Euclides: https://pt.wikipedia.org/wiki/Algoritmo_de_Euclides

            // Nesse exemplo, o algoritmo de Euclides é usado para calcular o mdc
            // entre os dois valores
            // O mmc é calculado pela equação: mdc(x,y) * mmc(x,y) = x * y

            Console.WriteLine("Digite dois valores inteiros");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            // Como o algoritmo de Euclides altera o valor dos números x e y,
            // os valores originais são copiados nas variáveis a e b
            int a = x; int b = y;
            // O algoritmo executa até encontrar um resto 0 na divisão entre x e y
            // x é o dividendo e y, o divisor
            int r = x % y;
            while (r != 0) { 
                // Enquanto o resto não for zero, o dividendo recebe o divisor
                // e o divisor recebe o resto
                x = y; 
                y = r;
                // Um novo resto é calculado
                r = x % y;
            } 
            // O mdc é o último divisor
            Console.WriteLine($"MDC = {y}");
            // O mmc é obtido a partir do mdc e do produto
            Console.WriteLine($"MMC = {a*b/y}");
            Console.ReadKey();
        }
    }
}
