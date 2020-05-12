using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor inteiro");
            int n = int.Parse(Console.ReadLine());
            // O método requer a passagem de duas variáveis para os parâmetros de saída
            // Essas variáveis precisam ser declaradas e vão retornar com os 
            // valores atribuídos dentro do método
            int a, b;
            // A palavra reservada out deve ser utilizada também na chamada do método
            AntecessorSucessor(n, out a, out b);
            Console.WriteLine($"Valor informado = {n}");
            Console.WriteLine($"Antecessor = {a}");
            Console.WriteLine($"Sucessor   = {b}");
            Console.ReadKey();
        }
        public static void AntecessorSucessor(int x, out int antecessor, out int sucessor)
        {
            // Neste exemplo, o método retorna os valores nos parâmetros de saída
            // sinalizados com out
            // Não é neessário usar o return em métodos void
            antecessor = x - 1;
            sucessor = x + 1;
        }
    }
}
