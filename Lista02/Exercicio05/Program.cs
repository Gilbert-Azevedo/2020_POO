using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mais sobre switch em: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/switch
            // Mais sobre enumerações em: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/enum

            Console.WriteLine("Informe o número do mês");
            int m = int.Parse(Console.ReadLine());
            // Solução 1 - usando switch ou if para testar cada mês
            // Neste caso, como é necessário testar 12 valores diferentes de uma
            // única variável, é interessante usar o switch
            switch (m)
            {
                case 1: Console.WriteLine("O mês de janeiro é do primeiro trimestre do ano"); break;
                case 2: Console.WriteLine("O mês de fevereiro é do primeiro trimestre do ano"); break;
                case 3: Console.WriteLine("O mês de março é do primeiro trimestre do ano"); break;
                case 4: Console.WriteLine("O mês de abril é do segundo trimestre do ano"); break;
                case 5: Console.WriteLine("O mês de maio é do segundo trimestre do ano"); break;
                case 6: Console.WriteLine("O mês de junho é do segundo trimestre do ano"); break;
                case 7: Console.WriteLine("O mês de julho é do terceiro trimestre do ano"); break;
                case 8: Console.WriteLine("O mês de agosto é do terceiro trimestre do ano"); break;
                case 9: Console.WriteLine("O mês de setembro é do terceiro trimestre do ano"); break;
                case 10: Console.WriteLine("O mês de outubro é do quarto trimestre do ano"); break;
                case 11: Console.WriteLine("O mês de novembro é do quarto trimestre do ano"); break;
                case 12: Console.WriteLine("O mês de dezembro é do quarto trimestre do ano"); break;
            }

            // Solução 2 - usando as enumerações mês e trimestre definidas abaixo
            // Converte o inteiro m com o número do mês para a variável do tipo mes
            mes x = (mes)m;
            // Calcula o trimestre e converte a variável para o tipo trimestre
            trimestre y = (trimestre)((m - 1) / 3);
            Console.WriteLine($"O mês de {x.ToString()} é do {y.ToString()} trimestre do ano");
            Console.ReadKey();
        }
    }

    // Enumerações mês e trimestre utilizadas na solução 2
    enum mes
    {
        janeiro = 1, fevereiro, março, abril, maio, junho, julho, agosto,
        setembro, outubro, novembro, dezembro
    }
    enum trimestre { primeiro = 0, segundo, terceiro, quarto }
}
