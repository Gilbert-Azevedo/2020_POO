using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo é necessário dividir sucessivamente o valor da entrada (x) por 10
            // até chegar em zero. Também é necessário, em cada passo, obter o resto (r)
            // da divisão de x por 10. O resto é usado para gerar o novo número (n).
            Console.WriteLine("Informe um valor inteiro");
            int x = int.Parse(Console.ReadLine());
            // Valor inicial do novo número
            int n = 0;
            while (x != 0)
            {
                int r = x % 10; // O resto da divisão por 10 é o algarismo da casa da unidade de x
                n = n * 10 + r; // Multiplica o novo número por 10 e soma com o resto
                x = x / 10;     // Atualiza o valor de entrada x
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
