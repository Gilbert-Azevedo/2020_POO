using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois valores reais");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            // Se o método estiver na própria classe, não é necessário informar
            // o nome da classe antes do nome do método
            double c = Maior(a, b);
            Console.WriteLine($"O maior valor é {c}");
            // Métodos em outras classes precisam ser chamados informando o nome
            // da classe
            double d = Matematica.Maior(a, b);
            Console.WriteLine($"O maior valor é {d}");
            // Se o método não for estático, é necessário instanciar a classe e chamar
            // o método com a instância (instância = objeto)
            Matematica m = new Matematica();
            double e = m.Menor(a, b);
            Console.WriteLine($"O menor valor é {e}");
            Console.ReadKey();
        }
        public static double Maior(double x, double y)
        {
            // Retorna x, se x for maior que y; caso contrário, retorna y
            return x > y ? x : y;
        }
    }
    class Matematica
    {
        public static double Maior(double x, double y)
        {
            // Método estático é chamado com a classe
            // Retorna x, se x for maior que y; caso contrário, retorna y
            return x > y ? x : y;
        }
        public double Menor(double x, double y)
        {
            // Método não estático é chamado com o objeto
            // Retorna x, se x for menor que y; caso contrário, retorna y
            return x < y ? x : y;
        }
    }
}
