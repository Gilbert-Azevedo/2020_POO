using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    struct Data
    {
        public int Dia;
        public int Mes;
        public int Ano;
        public static bool Bissexto(int ano)
        {
            // Método auxiliar que retorna verdadeiro quando o ano é bissexto
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }
        public static int DiaAno(Data x)
        {
            // Método auxiliar que calcula o número de dias passados em um determinado
            // um ano, desde 01/01 deste ano até a data informada em x 
            // Dias passados dentro do mês
            int t = x.Dia; 
            // Para cada mês do ano que já encerrou, soma o número de dias passados
            // destes meses
            for (int m = 1; m < x.Mes; m++)
                switch (m)
                {
                    case 2: t += Bissexto(x.Ano) ? 29 : 28; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: t += 30; break;
                    default: t += 31; break;
                }
            return t;
        }
        public static int NumeroDias(Data d1, Data d2)
        {
            // Verifica se as datas estão no mesmo ano
            // Se estão, basta calcular a diferença entre o dia do ano das duas datas
            if (d1.Ano == d2.Ano) return DiaAno(d2) - DiaAno(d1);
            // Se chegar aqui, é porque as datas estão em anos diferentes
            // Número total de dias do ano da data d1
            int t = 365 + (Bissexto(d1.Ano) ? 1 : 0);
            // Calcula o número de dias desde a data d1 até o final do ano da data d1
            t -= DiaAno(d1);
            // Soma os dias passados desde 01/01 do ano de d2 até a data d2
            t += DiaAno(d2);
            // Soma os anos completos entre d1 e d2
            for (int ano = d1.Ano + 1; ano < d2.Ano; ano++)
                t += (365 + (Bissexto(ano) ? 1 : 0));
            return t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo é necessário calcular o número de dias entre duas datas
            // A solução apresentada soma 3 valores:
            // O número de dias que faltam para completar o ano da primeira data
            // O número de dias que já passaram desde o primeiro dia do ano da segunda data
            // O número total de dias dos anos completos entre as duas datas, excetuando
            // o ano da primeira data e o ano da segunda data
            Console.WriteLine("Digite a primeira data no formato dd/mm/aaaa");
            string s = Console.ReadLine();
            // É possível obter dia, mes e ano com Split ou Substring
            string[] v = s.Split('/');
            Data d1;
            d1.Dia = int.Parse(v[0]);
            d1.Mes = int.Parse(v[1]);
            d1.Ano = int.Parse(v[2]);

            Console.WriteLine("Digite a segunda no formato dd/mm/aaaa");
            s = Console.ReadLine();
            // É possível obter dia, mes e ano com Split ou Substring
            v = s.Split('/');
            Data d2;
            d2.Dia = int.Parse(v[0]);
            d2.Mes = int.Parse(v[1]);
            d2.Ano = int.Parse(v[2]);

            // Obtém o número de dias entre x e y
            int t = Data.NumeroDias(d1, d2);
            Console.Write($"{t} dia(s) entre ");
            Console.Write($"{d1.Dia:00}/{d1.Mes:00}/{d1.Ano:0000} e ");
            Console.Write($"{d2.Dia:00}/{d2.Mes:00}/{d2.Ano:0000}\n");
            Console.ReadKey();
        }
    }
}
