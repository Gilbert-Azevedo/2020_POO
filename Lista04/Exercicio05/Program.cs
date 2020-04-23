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
            Console.WriteLine("Informe o dia da semana");
            string d = Console.ReadLine();
            Console.WriteLine("Informe a hora inicial do filme");
            int h = int.Parse(Console.ReadLine());
            double valor = 10;
            // Verifica o dia da semana. Passa para minúsculo e tem que digitar com 
            // as letras testadas
            switch (d.ToLower())
            {
                case "segunda":
                case "terça":
                case "quarta": valor -= 2; break;
                case "sexta":
                case "sábado": valor += 5; break;
            }
            // Verifica o horário
            if (h < 17) valor -= 2;
            Console.WriteLine($"O valor da entrada é {valor:c2}");
            Console.ReadKey();
        }
    }
}
