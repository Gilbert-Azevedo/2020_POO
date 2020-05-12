using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            // c1 a c4 são os candidatos, b brancos, n nulos
            // x é o voto, t total de votos
            int x, t, c1 = 0, c2 = 0, c3 = 0, c4 = 0, b = 0, n = 0;
            do
            {
                Console.WriteLine("0-Fim, 1-C1, 2-C2, 3-C3, 4-C4, 5-Branco, 6-Nulo");
                x = int.Parse(Console.ReadLine());
                switch(x)
                {
                    case 1: c1++; break; // Incrementa o contador de acordo com a opção
                    case 2: c2++; break;
                    case 3: c3++; break;
                    case 4: c4++; break;
                    case 5: b++; break;
                    case 6: n++; break;
                }

            } while (x != 0);
            // Total de votos
            t = c1 + c2 + c3 + c4 + b + n;
            // Percentual de votos de cada candidato
            Console.WriteLine($"C1 teve {c1} votos = {100.0 * c1 / t:0.0}%");
            Console.WriteLine($"C2 teve {c2} votos = {100.0 * c2 / t:0.0}%");
            Console.WriteLine($"C3 teve {c3} votos = {100.0 * c3 / t:0.0}%");
            Console.WriteLine($"C4 teve {c4} votos = {100.0 * c4 / t:0.0}%");
            Console.WriteLine($"Votos brancos {b} = {100.0 * b / t:0.0}%");
            Console.WriteLine($"Votos nulos   {n} = {100.0 * n / t:0.0}%");
            // Verifica o vencedor
            int m = c1; int g = 1;          // Vencedor é c1
            if (c2 > m) { m = c2; g = 2; }  // Se c2 teve mais votos, vendedor é c2
            if (c3 > m) { m = c3; g = 3; }  // Se c3 teve mais votos, vendedor é c3
            if (c4 > m) { m = c4; g = 4; }  // Se c4 teve mais votos, vendedor é c4
            if (g == 1) Console.WriteLine("C1 ganhou");
            if (g == 2) Console.WriteLine("C2 ganhou");
            if (g == 3) Console.WriteLine("C3 ganhou");
            if (g == 4) Console.WriteLine("C4 ganhou");
            Console.ReadKey();
        }
    }
}
