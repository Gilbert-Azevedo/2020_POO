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
            Pessoa p = new Pessoa();
            Console.WriteLine("Digite seu nome");
            p.SetNome(Console.ReadLine());
            Console.WriteLine("Digite sua data de nascimento");
            p.SetNascimento(DateTime.Parse(Console.ReadLine()));
            Console.WriteLine($"{p.GetNome()}, você tem {p.Idade()} anos");
            Console.ReadKey();
        }
    }
}
