using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // As disciplinas serão referenciadas com uma referência para a interface
            // IMedia
            IMedia x;

            Console.WriteLine("Selecione: 1 - Disciplina Anual, 2 - Disciplina Semestral");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                // Instancia uma disciplina anual
                Console.WriteLine("Informe as notas dos 4 bimestres e prova final");
                x = new DisciplinaAnual(
                    int.Parse(Console.ReadLine()),  // Nota 1º bimestre
                    int.Parse(Console.ReadLine()),  // Nota 2º bimestre
                    int.Parse(Console.ReadLine()),  // Nota 3º bimestre
                    int.Parse(Console.ReadLine()),  // Nota 4º bimestre
                    int.Parse(Console.ReadLine())); // Nota prova final
            }
            else
            {
                // Instancia uma disciplina semestral
                Console.WriteLine("Informe as notas dos 2 bimestres e prova final");
                x = new DisciplinaSemestral(
                    int.Parse(Console.ReadLine()),  // Nota 1º bimestre
                    int.Parse(Console.ReadLine()),  // Nota 2º bimestre
                    int.Parse(Console.ReadLine())); // Nota prova final
            }

            // Calcula a média da disciplina e informa
            Console.WriteLine($"Média = {x.GetMedia()}");
            Console.ReadKey();
        }
    }
}
