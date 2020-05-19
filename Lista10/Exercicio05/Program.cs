using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    // A estrutura Fração representa um número racional: numerador e denominador
    // inteiros
    struct Fracao
    {
        public int Num;
        public int Den;
        public static Fracao Somar(Fracao x, Fracao y)
        {
            // A soma da fração considerou o denominador do resultado como
            // o produto entre os denominadores das parcelas
            Fracao z;
            z.Num = x.Num * y.Den + y.Num * x.Den;
            z.Den = x.Den * y.Den;
            return z;
        }
        public static Fracao Subtrair(Fracao x, Fracao y)
        {
            // A subtração da fração considerou o denominador do resultado como
            // o produto entre os denominadores das parcelas
            Fracao z;
            z.Num = x.Num * y.Den - y.Num * x.Den;
            z.Den = x.Den * y.Den;
            return z;
        }
        public static Fracao Multiplicar(Fracao x, Fracao y)
        {
            // Multiplicação das frações
            Fracao z;
            z.Num = x.Num * y.Num;
            z.Den = x.Den * y.Den;
            return z;
        }
        public static Fracao Dividir(Fracao x, Fracao y)
        {
            // Divisão das frações
            Fracao z;
            z.Num = x.Num * y.Den;
            z.Den = x.Den * y.Num;
            return z;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Fracao x, y;
            Console.WriteLine("Informe o numerador da primeira fração");
            x.Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o denominador da primeira fração");
            x.Den = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numerador da segunda fração");
            y.Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o denominador da segunda fração");
            y.Den = int.Parse(Console.ReadLine());

            Fracao a = Fracao.Somar(x, y);       
            Fracao b = Fracao.Subtrair(x, y);    
            Fracao c = Fracao.Multiplicar(x, y); 
            Fracao d = Fracao.Dividir(x, y);     

            Console.WriteLine($"{x.Num}/{x.Den} + {y.Num}/{y.Den} = {a.Num}/{a.Den}");
            Console.WriteLine($"{x.Num}/{x.Den} - {y.Num}/{y.Den} = {b.Num}/{b.Den}");
            Console.WriteLine($"{x.Num}/{x.Den} * {y.Num}/{y.Den} = {c.Num}/{c.Den}");
            Console.WriteLine($"{x.Num}/{x.Den} / {y.Num}/{y.Den} = {d.Num}/{d.Den}");
            Console.ReadLine();
        }
    }
}
