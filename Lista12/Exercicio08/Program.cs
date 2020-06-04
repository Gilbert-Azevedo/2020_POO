using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Referência para o objeto 
            Pessoa x;
            // Instancia o objeto
            x = new Pessoa();
            // Dados do objeto
            Console.WriteLine("Informe o nome");
            x.SetNome(Console.ReadLine());
            Console.WriteLine("Informe a data de nascimento \"dd/mm/aaaa\"");
            x.SetNascimento(DateTime.Parse(Console.ReadLine()));
            // Resultado
            Console.WriteLine($"{x.GetNome()} tem {x.Idade()} ano(s)");
            Console.ReadKey();
        }
    }
}
