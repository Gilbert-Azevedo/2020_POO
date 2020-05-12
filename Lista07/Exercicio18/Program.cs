using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, é necessário atualizar a população dos países
            // de acordo com o valor inicial e a taxa de crescimento
            // Até que a população do primeiro país ultrapasse a do segundo
            // Sempre que a população for atualizada, é necessário incrementar
            // o contador de anos
            // Obs: a solução considera que a população pode ser um valor real
            double a = 5000000; // População do país A
            double b = 7000000; // População do país B
            int n = 0;          // Número de anos
            while (a <= b)      // Enquanto a população de A for menor ou igual a de B
            {
                // Atualiza a população dos países
                a = a * 1.03;  // 3% de crescimento
                b = b * 1.02;  // 2% de crescimento
                // Incremente o número de anos
                n++;
            }
            Console.WriteLine($"Número de anos = {n}");
            Console.ReadKey();
        }
    }
}
