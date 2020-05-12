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
            Console.WriteLine("Informe um valor real");
            double x = double.Parse(Console.ReadLine());
            // Chama o método que retorna o menor inteiro >= x
            int m = MenorInteiro(x);
            Console.WriteLine($"Menor inteiro >= {x} = {m}");
            // Esse método é utilizado da solução de vários problemas e 
            // está disponível na classe Math do Framework
            m = (int) Math.Ceiling(x);
            Console.WriteLine($"Menor inteiro >= {x} = {m}");
            Console.ReadKey();
        }
        public static int MenorInteiro(double x)
        {
            // Converte o número em inteiro
            int i = (int)x;
            // Se os valores forem iguais, retonra o valor inteiro
            if (i == x) return i;
            // Se i for menor, retorna seu sucessor que é o primeiro inteiro maior que x
            return i + 1;
        }
    }
}
