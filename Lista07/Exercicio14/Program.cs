using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo é necessário testar os valores entre 1 e 1000
            // A solução não testa os centavos, mas a solução para os centavos
            // é análoga, bastando considerar os valores entre 1 e 99
            Console.WriteLine("Informe um valor inteiro até 1000");
            int i = int.Parse(Console.ReadLine());
            // Os valores 100 e 1000 precisam ser testados individualmente
            if (i == 100 || i == 1000)
            {
                if (i == 100) Console.WriteLine("Cem");
                if (i == 1000) Console.WriteLine("Mil");
            }
            else // Quando não for cem nem mil
            {
                int c = i / 100; // Calcula o número de centenas
                i = i % 100;     // Resto da divisão por cem, ou seja, entre 0 e 99
                int d = i / 10;  // Calcula o número de dezenas
                int u = i % 10;  // Calcula o número de unidades
                // Testa o número de centenas
                switch (c)
                {
                    case 1: Console.Write("Cento"); break;
                    case 2: Console.Write("Duzentos"); break;
                    case 3: Console.Write("Trezentos"); break;
                    case 4: Console.Write("Quatrocentos"); break;
                    case 5: Console.Write("Quinhentos"); break;
                    case 6: Console.Write("Seiscentos"); break;
                    case 7: Console.Write("Setecentos"); break;
                    case 8: Console.Write("Oitocentos"); break;
                    case 9: Console.Write("Novecentos"); break;
                }
                // Quando o resto for maior que 19, dá para testar as dezenas e unidades
                if (i > 19)
                {
                    if (c != 0 && (d != 0 || u != 0)) Console.Write(" e ");
                    switch (d)
                    {
                        case 2: Console.Write("Vinte"); break;
                        case 3: Console.Write("Trinta"); break;
                        case 4: Console.Write("Quarenta"); break;
                        case 5: Console.Write("Cinquenta"); break;
                        case 6: Console.Write("Sessenta"); break;
                        case 7: Console.Write("Setenta"); break;
                        case 8: Console.Write("Oitenta"); break;
                        case 9: Console.Write("Noventa"); break;
                    }
                    switch (u)
                    {
                        case 1: Console.WriteLine(" e Um"); break;
                        case 2: Console.WriteLine(" e Dois"); break;
                        case 3: Console.WriteLine(" e Três"); break;
                        case 4: Console.WriteLine(" e Quatro"); break;
                        case 5: Console.WriteLine(" e Cinco"); break;
                        case 6: Console.WriteLine(" e Seis"); break;
                        case 7: Console.WriteLine(" e Sete"); break;
                        case 8: Console.WriteLine(" e Oito"); break;
                        case 9: Console.WriteLine(" e Nove"); break;
                    }
                }
                else
                {
                    // De 1 a 19, tem que testar individualmente
                    if (c != 0 && (d != 0 || u != 0)) Console.Write(" e ");
                    switch (i)
                    {
                        case 1: Console.WriteLine("Um"); break;
                        case 2: Console.WriteLine("Dois"); break;
                        case 3: Console.WriteLine("Três"); break;
                        case 4: Console.WriteLine("Quatro"); break;
                        case 5: Console.WriteLine("Cinco"); break;
                        case 6: Console.WriteLine("Seis"); break;
                        case 7: Console.WriteLine("Sete"); break;
                        case 8: Console.WriteLine("Oito"); break;
                        case 9: Console.WriteLine("Nove"); break;
                        case 10: Console.WriteLine("Dez"); break;
                        case 11: Console.WriteLine("Onze"); break;
                        case 12: Console.WriteLine("Doze"); break;
                        case 13: Console.WriteLine("Treze"); break;
                        case 14: Console.WriteLine("Quatorze"); break;
                        case 15: Console.WriteLine("Quinze"); break;
                        case 16: Console.WriteLine("Dezesseis"); break;
                        case 17: Console.WriteLine("Dezessete"); break;
                        case 18: Console.WriteLine("Dezoito"); break;
                        case 19: Console.WriteLine("Dezenove"); break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
