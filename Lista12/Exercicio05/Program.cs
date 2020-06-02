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
            // Referência para o objeto 
            EquacaoIIGrau x;
            double a, b, c, x1, x2;
            // Instancia o objeto
            x = new EquacaoIIGrau();
            // Dados do objeto
            Console.WriteLine("Informe os coeficientes a, b, e c");
            x.SetABC(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()));
            // Dados da equação
            x.GetABC(out a, out b, out c);
            Console.WriteLine($"a = {a} b = {b} c = {c}");
            // Realiza as outras operações do objeto
            if (x.RaizesReais())
            {
                x.X1(out x1);
                x.X2(out x2);
                Console.WriteLine($"X1 = {x1}");
                Console.WriteLine($"X2 = {x2}");
            }
            else
                Console.WriteLine("A equação não tem raízes reais");
            Console.ReadKey();
        }
    }
}
