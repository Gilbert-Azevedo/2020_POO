using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Or sorteios serão referenciados com uma referência para a interface
            // ISorteio
            ISorteio x;

            Console.WriteLine("Selecione: 1 - Mega, 2 - Bingo");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                // Instancia um sorteio mega
                x = new Mega();
            }
            else
            {
                // Instancia um bingo
                Console.WriteLine("Informe o número de bolas");
                x = new Bingo(int.Parse(Console.ReadLine()));
            }

            // Mostra 10 elementos do bingo
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
                Console.WriteLine(x.Sortear());
 
            Console.ReadKey();
        }
    }
}
