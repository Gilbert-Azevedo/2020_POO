using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Intervalo
    {
        // Atributos
        private int hora, minuto, segundo;
        // Métodos de acesso
        public void SetIntervalo(int h, int m, int s)
        {
            // Armazena apenas se nenhum valor for negativo
            if (h >= 0 && m >= 0 && s >= 0)
            {
                hora = h;
                minuto = m;
                segundo = s;
            }
        }
        public void GetIntervalo(out int h, out int m, out int s)
        {
            // Retorna os atributos usando parâmetros de saída
            h = this.hora;
            m = this.minuto;
            s = this.segundo;
        }
        // Métodos de cálculo
        public Intervalo Somar(Intervalo x)
        {
            // Nesse método dois intervalos são somados: o intervalo que chama
            // o método referenciado por this e o passado no parâmetro x
            int h = this.hora + x.hora;
            int m = this.minuto + x.minuto;
            int s = this.segundo + x.segundo;
            // Verifica se o total de segundos passou de 60
            if (s > 60) { s -= 60; m++; }
            // Verifica se o toral de minutos passou de 60
            if (m > 60) { m -= 60; h++; }
            // Instancia um novo intervalo com a soma das duas parcelas e retorna
            // como resultado
            Intervalo novo = new Intervalo();
            novo.SetIntervalo(h, m, s);
            return novo;
        }
        public Intervalo Subtrair(Intervalo x)
        {
            // Nesse método dois intervalos são subtraídos, mas apenas se o primeiro
            // for maior que o segundo, senão retorna null
            // Total de segundos do intervalo this
            int ts1 = this.hora * 3600 + this.minuto * 60 + this.segundo;
            // Total de segundos do intervalo x
            int ts2 = x.hora * 3600 + x.minuto * 60 + x.segundo;
            if (ts1 < ts2) return null;
            // Diferença entre os intervalos em segundos
            int dif = ts1 - ts2;
            // Total de horas da diferença
            int h = dif / 3600;
            // Total de minutos da diferença
            dif = dif % 3600;
            int m = dif / 60;
            // Total de segundos da diferença
            int s = dif % 60;
            // Instancia um novo intervalo com a diferença das duas parcelas e retorna
            // como resultado
            Intervalo novo = new Intervalo();
            novo.SetIntervalo(h, m, s);
            return novo;
        }
        // Redefinição do método ToString
        public override string ToString()
        {
            return $"{hora:00}:{minuto:00}:{segundo:00}";
        }
    }
}
