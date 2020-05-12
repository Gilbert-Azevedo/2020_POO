using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o início do intervalo");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o fim do intervalo");
            int y = int.Parse(Console.ReadLine());
            // Chama o método que calcula a soma
            int s = Soma(x, y);
            Console.WriteLine($"A soma dos elementos no intervalo é {s}");
            Console.ReadKey();
        }
        public static int Soma(int inicio, int fim)
        {
            // A soma dos elementos inteiros subsequentes em um intervalo fechado
            // pode ser obtida pela fórmula de soma dos elementos de uma PA
            // Progressão Aritmética
            // Número de termos no intervalo
            int n = fim - inicio + 1;
            return (inicio + fim) * n / 2;
        }
    }
}
