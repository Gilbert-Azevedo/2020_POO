using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            // As sequências serão referenciadas com uma referência para a interface
            // ISequencia
            ISequencia x;

            Console.WriteLine("Selecione: 1 - Fibonacci, 2 - Progressão Aritmética");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                // Instancia uma sequencia de Fibonacci
                x = new Fibonacci();
            }
            else
            {
                // Instancia uma PA
                Console.WriteLine("Informe o primeiro elemento e razão da progressão (inteiros)");
                x = new PA(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }

            // Mostra 10 elementos da sequência
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(x.Proximo());

            // Reinicia e mostra novamente
            x.Iniciar();
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(x.Proximo());

            Console.ReadKey();
        }
    }
}
