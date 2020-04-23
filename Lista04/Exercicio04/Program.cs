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
            Console.WriteLine("Informe o nome da primeira pessoa");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento");
            string data1 = Console.ReadLine();
            Console.WriteLine("Informe o nome da segunda pessoa");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento");
            string data2 = Console.ReadLine();
            // Compara as datas
            if (data1 == data2)
                Console.WriteLine($"{nome1} e {nome2} têm a mesma idade");
            else
            {
                // Separa as datas em dia, mês e ano
                string[] v1 = data1.Split('/');
                int d1 = int.Parse(v1[0]); // dia 
                int m1 = int.Parse(v1[1]); // mês
                int a1 = int.Parse(v1[2]); // ano
                string[] v2 = data2.Split('/');
                int d2 = int.Parse(v2[0]); // dia 
                int m2 = int.Parse(v2[1]); // mês
                int a2 = int.Parse(v2[2]); // ano
                // Verifica se a data1 é mais antiga que a data2
                if ((a1 < a2) || (a1 == a2 && m1 < m2) || 
                    (a1 == a2 && m1 == m2 && d1 < d2) )
                    Console.WriteLine($"{nome1} é mais velho(a) que {nome2}");
                else
                    Console.WriteLine($"{nome2} é mais velho(a) que {nome1}");
            }
            Console.ReadKey();
        }
    }
}
