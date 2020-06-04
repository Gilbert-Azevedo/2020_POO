using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Data
    {
        // Atributos. Inicia a data em 1/1/1
        private int dia = 1, mes = 1, ano = 1;
        // Método privado
        // Nesse exemplo um método privado vai testar se o valor informado para 
        // uma data é válido. Esse método é usado pelo construtor e pelo método
        // set, mas não pode ser chamado de fora da classe
        private bool validaData(int d, int m, int a)
        {
            // Verifica se o ano é bissexto
            bool bissexto = (a % 4 == 0 && a % 100 != 0) || a % 400 == 0;
            // É necessário descobrir o número máximo de dias do mês da data
            int max = 31; // A maioria dos meses tem 31 dias
            // Verificação dos demais meses
            switch (m)
            {
                case 2: max = 28 + (bissexto ? 1 : 0); break; // Fevereiro tem 28 ou 29 dias
                case 4:
                case 6:
                case 9:
                case 11: max = 30; break; // Abril, junho, setembro e novembro tem 30 dias
            }
            // Verificação da data. Considera anos entre 1 e 2100
            return d >= 1 && d <= max && m >= 1 && m <= 12 && a >= 1 && a <= 2100;
        }
        // Construtor
        public Data(int d, int m, int a)
        {
            // Valida a data que está para ser armazenada
            if (validaData(d,m,a))
            {
                dia = d;
                mes = m;
                ano = a;
            }
        }
        // Métodos de acesso
        public void SetData(int d, int m, int a)
        {
            // Valida a data que está para ser armazenada
            if (validaData(d, m, a))
            {
                dia = d;
                mes = m;
                ano = a;
            }
        }
        public int GetDia()
        {
            return dia;
        }
        public int GetMes()
        {
            return mes;
        }
        public int GetAno()
        {
            return ano;
        }
        // Redefinição do método ToString
        public override string ToString()
        {
            return $"{dia:00}/{mes:00}/{ano:0000}";
        }
    }
}
