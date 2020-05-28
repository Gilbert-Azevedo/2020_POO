using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Referência para o objeto retângulo
            Retangulo x;
            // Dados de base e altura do retângulo
            Console.WriteLine("Informe a base do retângulo");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do retângulo");
            double h = double.Parse(Console.ReadLine());
            // Instancia a classe, passando os dados para o novo objeto chamando
            // o construtor da classe
            x = new Retangulo(b, h);
            // Mostra dados do objeto. Quando o objeto é apresentado, o método ToString
            // da classe é chamado
            Console.WriteLine(x);
            // Realiza as outras operações do objeto
            Console.WriteLine($"Área = {x.CalcArea()}");
            Console.WriteLine($"Diagonal = {x.CalcDiagonal()}");
            Console.ReadKey();
        }
    }
}
