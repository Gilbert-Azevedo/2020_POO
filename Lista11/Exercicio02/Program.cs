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
            Disciplina x = new Disciplina();
            Console.WriteLine("Digite o nome da disciplina");
            x.SetNome(Console.ReadLine());
            Console.WriteLine("Digite a nota do 1º bimestre");
            x.SetNota1(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a nota do 2º bimestre");
            x.SetNota2(int.Parse(Console.ReadLine()));
            if (x.CalcMedia() < 60)
            {
                Console.WriteLine("Digite a nota da prova final");
                x.SetNotaF(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Sua média foi {x.CalcMedia()}");
            Console.ReadKey();
        }
    }
}
