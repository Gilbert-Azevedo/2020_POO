using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o horário no formato hh:mm");
            string s = Console.ReadLine();
            // Número de horas e minutos
            int h = int.Parse(s.Substring(0, 2));
            int m = int.Parse(s.Substring(3, 2));
            // O ponteiro dos minutos anda 360 graus a cada 60 minutos
            // pm é o ângulo do ponteiro dos minutos considerando 0 minutos como 0 graus
            // Se o número de minutos for 30, o ponteiro está na posição 180 graus
            double pm = m * 6;
            // O ponteiro das horas anda 360 graus a cada 12 horas
            // E ele anda também 30 graus a cada 60 minutos
            // ph é o ângulo do ponteiro das horas considerando 0 horas como 0 graus
            // Se forem 3 horas, o ponteiro das horas está na posição 90 graus
            // Se forem 3 horas e 30 minutos, o ponteiro está na posição 105 graus
            double ph = h * 30 + m * 0.5;
            // Calcula o resto da divisão por 360, caso o número de horas seja maior que 12
            ph = ph % 360;
            // O ângulo entre os ponteiros é dado pela diferença entre as posições
            // Se o ponteiro das horas estiver na frente, por exemplo, 3h, o ângulo
            // é ph - pm. Caso contrário, por exemplo, 3h30, o ângulo é pm - ph
            double angulo = ph > pm? ph - pm : pm - ph;
            // Se o ângulo for maior que 180, você obteve o maior ângulo, e não o menor
            if (angulo > 180) angulo = 360 - angulo;
            Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo} graus");
            Console.ReadKey();
        }
    }
}
