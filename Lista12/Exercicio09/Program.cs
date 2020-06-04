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
            // Exemplo de cálculo com dois intervalos
            Intervalo a = new Intervalo();
            a.SetIntervalo(2, 30, 0);  // Duas horas e trinta minutos
            Intervalo b = new Intervalo();
            b.SetIntervalo(0, 35, 10); // Trinta e cinco minutos e dez segundos

            // Soma dos intervalos
            Intervalo c = a.Somar(b);

            // Diferença dos intervalos
            Intervalo d = a.Subtrair(b);

            // Resultados
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine($"{a} - {b} = {d}");
            Console.ReadKey();
        }
    }
}
