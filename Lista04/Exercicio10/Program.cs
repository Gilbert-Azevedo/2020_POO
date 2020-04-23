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
            Console.WriteLine("Informe o valor unitário do produto");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade comprada");
            int q = int.Parse(Console.ReadLine());
            // Verifica a quantidade comprada para aplicar o desconto
            double total = 0;
            if (q <= 10)
            {
                // Nessa quantidade, o desconto é de 5%, ou seja, o produto
                // sai por 95% do seu valor
                total = q * 0.95 * p;
            }
            if (q > 10 && q <= 50)
            {
                // Nessa quantidade, o desconto de 5% é para as 10 primeiras unidades
                total = 10 * 0.95 * p;
                // As unidades restantes terão desconto de 10% (produto por 90% do valor)
                q = q - 10;
                total += (q * 0.9 * p);
            }
            if (q > 50)
            {
                // Nessa quantidade, o desconto de 5% é para as 10 primeiras unidades
                total = 10 * 0.95 * p;
                // E o desconto de 10% nas quarenta unidades seguintes
                total += (40 * 0.9 * p);
                // As unidades restantes terão desconto de 20% (produto por 80% do valor)
                q = q - 50;
                total += (q * 0.8 * p);
            }
            Console.WriteLine($"O total a ser pago é {total:c2}");
            Console.ReadKey();
        }
    }
}
