using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro horário no formato hh:mm");
            string x = Console.ReadLine();
            Console.WriteLine("Digite o segundo horário no formato hh:mm");
            string y = Console.ReadLine();
            // O número de horas e minutos de cada horário pode ser obtido com Split
            // ou Substring
            // Número de horas e minutos do primeiro horário
            // O número de horas inicia na posiçao 0      hh:mm
            // O número de minutos inicia na posição 3    01234
            // O comprimento de cada valor é de 2 caracteres
            int h1 = int.Parse(x.Substring(0, 2));
            int m1 = int.Parse(x.Substring(3, 2));
            // Número de horas e minutos do primeiro horário
            int h2 = int.Parse(y.Substring(0, 2));
            int m2 = int.Parse(y.Substring(3, 2));
            // Total de horas e minutos
            int h = h1 + h2;
            int m = m1 + m2;
            // Verifica se o número de minutos passou de 60
            if (m > 60)
            {
                m -= 60;  // Diminui 60 minutos
                h++;      // Soma uma hora
            }
            Console.WriteLine($"Total de horas = {h:00}:{m:00}");
            Console.ReadKey();
        }
    }
}
