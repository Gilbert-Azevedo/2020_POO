using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            // Calcula o mmc entre os números
            int mmc = MMC(x, y);
            Console.WriteLine($"O MMC entre {x} e {y} é {mmc}");
            Console.ReadKey();
        }
        public static int MMC(int x, int y)
        {
            // Semelhante ao exercício 20 da lista 07
            // Como o algoritmo de Euclides altera o valor dos números x e y,
            // os valores originais são copiados nas variáveis a e b
            int a = x; int b = y;
            // O algoritmo executa até encontrar um resto 0 na divisão entre x e y
            // x é o dividendo e y, o divisor
            int r = x % y;
            while (r != 0)
            {
                // Enquanto o resto não for zero, o dividendo recebe o divisor
                // e o divisor recebe o resto
                x = y;
                y = r;
                // Um novo resto é calculado
                r = x % y;
            }
            return a * b / y;
        }
    }
}
