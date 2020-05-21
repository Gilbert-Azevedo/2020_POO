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
            Disciplina d = new Disciplina();
            Console.WriteLine("Informe o nome da disciplina");
            d.SetNome(Console.ReadLine());
            Console.WriteLine("Informe a nota do 1º bimestre");
            d.SetNota1(int.Parse(Console.ReadLine()));
            Console.WriteLine("Informe a nota do 2º bimestre");
            d.SetNota2(int.Parse(Console.ReadLine()));
            // Cálcula a média para verificar se houve prova final
            if (d.CalcMedia() < 60)
            {
                Console.WriteLine("Informe a nota da prova final");
                d.SetNotaF(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Sua média na disciplina foi {d.CalcMedia()}");
            Console.ReadKey();
        }
    }
}
