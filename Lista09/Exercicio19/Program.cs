using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distância percorrida em km");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tempo gasto no formato hh:mm:ss");
            string t = Console.ReadLine();
            // Calcula e mostra a velocidade
            double v = VelocidadeMedia(d, t);
            Console.WriteLine($"A velocidade média foi {v} km/h");
            Console.ReadKey();
        }
        public static double VelocidadeMedia(double distancia, string tempo)
        {
            // Nesse exemplo é necessário converter o tempo do formato texto para
            // o valor em horas
            string[] v = tempo.Split(':');
            int h = int.Parse(v[0]); // número de horas
            int m = int.Parse(v[1]); // número de minutos
            int s = int.Parse(v[2]); // número de segundos
            // Tempo em horas
            double horas = h + m / 60.0 + s / 3600.0;
            // Velocidade média
            return distancia / horas;
        }
    }
}
