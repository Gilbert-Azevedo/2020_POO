using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Cinema
    {
        // Atributos - É possível atribuir valores iniciais para os parâmetros
        // conforme mostrado abaixo
        private string dia = "Dom";  
        private int horario = 17;
        // Métodos Acessores
        public void SetDia(string dia)
        {
            // Valores válidos para dia são: Dom, Seg, Ter, Qua, Qui, Sex, Sab
            if (dia == "Dom" || dia == "Seg" || dia == "Ter" || dia == "Qua" ||
                dia == "Qui" || dia == "Sex" || dia == "Sab")
                this.dia = dia;
        }
        public string GetDia()
        {
            return dia;
        }
        public void SetHorario(int horario)
        {
            // Valores válidos para horário são: 0 a 23
            if (horario >= 0 && horario <= 23) this.horario = horario;
        }
        public int GetHorario()
        {
            return horario;
        }
        // Métodos de cálculo doe valor da entrada
        public double Inteira()
        {
            // Verifica se o dia é quarta-feira
            if (dia == "Qua") return 8;
            // Dia é segunda, terça ou quinta
            double p = 16;
            // Verifica se o dia é sexta, sábado ou domingo
            if (dia == "Sex" || dia == "Sab" || dia == "Dom") p = 20;
            // Verifica os horários de acréscimo
            if (horario == 0 || (horario >= 17 && horario <= 23)) p = p * 1.5;
            return p;
        }
        public double Meia()
        {
            // Verifica se o dia é quarta-feira
            if (dia == "Qua") return 8;
            // Senão, o valor é metade da inteira
            return Inteira() / 2;
        }
    }
}
