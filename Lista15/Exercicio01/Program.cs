using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia a progressão
            PA x = new PA();
            // Dados da progressão
            Console.WriteLine("Informe o primeiro elemento da progressão");
            x.SetPrimeiroElemento(double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe a razão");
            x.SetRazao(double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe o número de elementos");
            int n = int.Parse(Console.ReadLine());
            // Mostra os elementos da PA
            Console.WriteLine("Elementos da Progressão Aritmética");
            // Recupera os elementos da progressão
            double[] elems = x.GetElementos(n);
            foreach (double d in elems)
                Console.WriteLine(d);
            Console.WriteLine($"Soma dos elementos = {x.GetSoma(n)}");
            Console.ReadKey();
        }
    }
}
