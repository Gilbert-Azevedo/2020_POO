using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    struct Data
    {
        public int Dia;
        public int Mes;
        public int Ano;
        public static Data UltimoDia(int mes, int ano)
        {
            // Esse exemplo é semelhante ao exercício 15 da lista 09
            // A diferença está apenas no retorno do método. Nesse caso,
            // uma variável da estrutura Data
            // O método UltimoDia poderia ficar dentro da classe Program também

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
            Data data;
            data.Dia = max;
            data.Mes = mes;
            data.Ano = ano;
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o mês");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano");
            int a = int.Parse(Console.ReadLine());
            // Chama o método para encontrar a data do último dia do mês desse ano
            Data data = Data.UltimoDia(m, a);
            Console.WriteLine($"{data.Dia:00}/{data.Mes:00}/{data.Ano:0000}");
            Console.ReadKey();
        }
    }
}
