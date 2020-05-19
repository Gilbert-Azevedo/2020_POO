using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    // Nesse exemplo, a estrutura Data define um tipo com três campos, 
    // todos números inteiros: Dia, Mes e Ano.
    // Uma variável do tipo Data representa então um dia no tempo
    struct Data
    {
        public int Dia;
        public int Mes;
        public int Ano;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Esse exemplo é semelhante ao exercício 10 da lista 02
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string s = Console.ReadLine();
            // É possível obter dia, mes e ano com Split ou Substring
            string[] v = s.Split('/');
            Data data;
            data.Dia = int.Parse(v[0]);
            data.Mes = int.Parse(v[1]);
            data.Ano = int.Parse(v[2]);
            // Verifica se o ano é bissexto
            bool bissexto = (data.Ano % 4 == 0 && data.Ano % 100 != 0) || data.Ano % 400 == 0;
            // É necessário descobrir o número máximo de dias do mês da data
            int max = 31; // A maioria dos meses tem 31 dias
            // Verificação dos demais meses
            switch (data.Mes)
            {
                case 2: max = 28 + (bissexto ? 1 : 0); break; // Fevereiro tem 28 ou 29 dias
                case 4:
                case 6:
                case 9:
                case 11: max = 30; break; // Abril, junho, setembro e novembro tem 30 dias
            }
            // Verificação da data
            if (data.Dia >= 1 && data.Dia <= max && data.Mes >= 1 && data.Mes <= 12)
                Console.WriteLine("A data informada é válida");
            else
                Console.WriteLine("A data informada é inválida");
            Console.ReadKey();
        }
    }
}
