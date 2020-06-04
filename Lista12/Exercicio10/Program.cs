using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia o objeto da classe Fibonacci e mostra os 10 primeiros
            // elementos da sequencia
            Fibonacci f = new Fibonacci();
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());

            // Reinicia a sequencia
            f.Iniciar();

            // Mostra novamente
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());
            Console.WriteLine(f.Proximo());

            Console.ReadKey();
        }
    }
}
