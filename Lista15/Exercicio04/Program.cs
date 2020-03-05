using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplina x = new Disciplina("Poo", "2020.1", 80);
            Console.WriteLine(x);
            Historico h = new Historico("Aluno");
            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
}
