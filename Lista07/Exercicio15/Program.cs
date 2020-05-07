using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esse exemplo é semelhante ao exercício 09 da Lista 04
            // A diferença é que os elementos são strings
            // Nesse caso, não é possível comparar as strings com < e >
            // A comparação é feita com o método CompareTo
            // Para comparar de s1 > s2, utilize s1.CompareTo(s2) == 1
            // Para comparar de s1 < s2, utilize s1.CompareTo(s2) == -1

            Console.WriteLine("Informe os quatro nomes");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            // Como são apenas 4 valores, a forma mais simples é ordenar os números
            // e isso pode ser feito utilizando o algoritmo Seleciotion Sort
            // de forma análoga ao Exercício 15 da Lista 2
            // Neste caso, é necessário testar todas as combinações de 2 números:
            // ab, ac, ad, bc, bd, cd
            string x;
            if (a.CompareTo(b) == 1) { x = a; a = b; b = x; }
            if (a.CompareTo(c) == 1) { x = a; a = c; c = x; }
            if (a.CompareTo(d) == 1) { x = a; a = d; d = x; }
            if (b.CompareTo(c) == 1) { x = b; b = c; c = x; }
            if (b.CompareTo(d) == 1) { x = b; b = d; d = x; }
            if (c.CompareTo(d) == 1) { x = c; c = d; d = x; }
            // Os nomes estão ordenados em ordem crescente
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
