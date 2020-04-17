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
            // Mais sobre operador condicional em: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/conditional-operator

            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string s = Console.ReadLine();
            // É possível obter dia, mes e ano com Split ou Substring
            string[] v = s.Split('/');
            int d = int.Parse(v[0]);
            int m = int.Parse(v[1]);
            int a = int.Parse(v[2]);
            // Verifica se o ano é bissexto
            bool bissexto = (a % 4 == 0 && a % 100 != 0) || a % 400 == 0;
            // É necessário descobrir o número máximo de dias do mês da data
            int max = 31; // A maioria dos meses tem 31 dias
            // Verificação dos demais meses
            switch(m)
            {
                case 2: max = 28 + (bissexto ? 1 : 0); break; // Fevereiro tem 28 ou 29 dias
                case 4:
                case 6:
                case 9:
                case 11: max = 30; break; // Abril, junho, setembro e novembro tem 30 dias
            }
            // Verificação da data
            if (d >= 1 && d <= max && m >= 1 && m <= 12 && a >= 1900 && a <= 2100)
                Console.WriteLine("A data informada é válida");
            else
                Console.WriteLine("A data informada é inválida");
            Console.ReadKey();
        }
    }
}
