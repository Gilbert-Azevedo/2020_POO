using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse exemplo, tem que ler as notas das disciplinas e calcular a média
            // ponderada. Vou considerar a média do IF
            Console.WriteLine("Digite a nota do primeiro bimestre");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo bimestre");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceiro bimestre");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do quarto bimestre");
            int n4 = int.Parse(Console.ReadLine());
            // Cálculo da média
            int m = (n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3) / 10;
            // Verifica se ficou em prova final
            if (m < 60)
            {
                Console.WriteLine("Você ficou em prova final");
                Console.WriteLine("Digite a nota da prova final");
                int nf = int.Parse(Console.ReadLine());
                // Atualiza a média
                m = (m + nf) / 2;
            }
            // Verifica se o aluno foi aprovado
            if (m >= 60) Console.WriteLine("Você foi aprovado");
            else Console.WriteLine("Você foi reprovado");
            Console.ReadKey();
        }
    }
}
