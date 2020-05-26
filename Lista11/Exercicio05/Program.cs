using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema c = new Cinema();
            // Dados para cálculo da entrada
            Console.WriteLine("Informe o dia do cimema: Dom, Seg, Ter, Qua, Qui, Sex ou Sab");
            c.SetDia(Console.ReadLine());
            Console.WriteLine("Informe o horário");
            c.SetHorario(int.Parse(Console.ReadLine()));
            // Resultado
            Console.WriteLine($"Dia = {c.GetDia()} - Horário = {c.GetHorario()}");
            Console.WriteLine($"Inteira = {c.Inteira():c2} - Meia = {c.Meia():c2}");
            Console.ReadKey();
        }
    }
}
