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
            Console.WriteLine("Informe o mês");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano");
            int a = int.Parse(Console.ReadLine());
            // Chama o método para encontrar a data do último dia do mês desse ano
            Console.WriteLine(UltimoDia(m, a));
            Console.ReadKey();
        }
        public static string UltimoDia(int mes, int ano)
        {
            // A solução é semelhante ao exercício 13 da lista 07
            // É necessário encontrar o maior dia do mês e isso depende do mês e do ano
            // Verifica se o ano é bissexto
            bool bissexto = (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
            // É necessário descobrir o número máximo de dias do mês da data
            int max = 31; // A maioria dos meses tem 31 dias
            // Verificação dos demais meses
            switch (mes)
            {
                case 2: max = 28 + (bissexto ? 1 : 0); break; // Fevereiro tem 28 ou 29 dias
                case 4:
                case 6:
                case 9:
                case 11: max = 30; break; // Abril, junho, setembro e novembro tem 30 dias
            }
            // Data com o maior dia encontrado
            string data = string.Format($"{max:00}/{mes:00}/{ano:0000}");
            return data;
        }
    }
}
