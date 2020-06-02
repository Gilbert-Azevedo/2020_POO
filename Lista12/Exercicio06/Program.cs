using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Referência para o objeto 
            Conversor x;
            // Instancia o objeto
            x = new Conversor();
            // Dados do objeto
            Console.WriteLine("Informe um inteiro para converter");
            x.SetNum(int.Parse(Console.ReadLine()));
            // Resultado
            Console.WriteLine($"Valor em binário = {x.Binario()}");
            Console.ReadKey();
        }
    }
}
