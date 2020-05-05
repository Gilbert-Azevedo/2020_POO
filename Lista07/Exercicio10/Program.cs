using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, o tempo de viagem em horas é obtido pelo quociente entre
            // a distância e a velocidade
            // Depois, é necessário converter o tempo em horas para horas e minutos
            Console.WriteLine("Digite a cidade de origem");
            string s = Console.ReadLine();
            Console.WriteLine("Digite a cidade de destino");
            string r = Console.ReadLine();
            Console.WriteLine("Digite a distância percorrida em quilômetros");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média em km/h:");
            double v = double.Parse(Console.ReadLine());
            // Tempo de viagem em horas
            double tempo = d / v;
            // O número de horas é a parte inteiro do tempo
            int horas = (int)tempo;
            // O número de minutos é a parte decimal do tempo x 60
            double minutos = (tempo - horas) * 60;
            // Resultado
            Console.WriteLine($"O tempo estimado de viagem entre {s} e {r} é de {horas} horas e {minutos} minutos.");
            Console.ReadKey();
        }
    }
}
