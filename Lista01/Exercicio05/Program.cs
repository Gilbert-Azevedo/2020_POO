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
            Console.WriteLine("Digite sua data de nascimento:");
            string s = Console.ReadLine();
            string[] x = s.Split('/');
            int a = int.Parse(x[2]);
            int ano = int.Parse(s.Substring(6));
            int mes = int.Parse(s.Substring(3, 2));
            int dia = int.Parse(s.Substring(0, 2));
            Console.WriteLine($"Em 31/12/2020 você terá {2020 - a} anos");

            DateTime d = DateTime.Parse(s);
            Console.WriteLine($"Em 31/12/2020 você terá {2020 - d.Year} anos");
            Console.WriteLine(d.ToString("dddd"));
            Console.WriteLine(d.ToString("d/MM/yyyy"));
            Console.WriteLine(d.ToString("dd/MMM/yyyy"));
            Console.WriteLine(d.ToString("ddd/MMMM/yyyy"));
            Console.WriteLine(d.DayOfYear);
            Console.WriteLine(d.AddDays(1));
            Console.WriteLine(d.AddMonths(1));
            Console.ReadKey();
        }
    }
}
