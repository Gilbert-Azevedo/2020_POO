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
            // Instancia o vetor
            Aluno[] v = new Aluno[10];
            // Entrada dos elementos
            for (int i = 0; i < 10; i++)
            {
                // Instancia o aluno
                v[i] = new Aluno();
                Console.Write($"Informe o nome do {i+1}º aluno: ");
                v[i].SetNome(Console.ReadLine());
                Console.Write($"Informe a média: ");
                v[i].SetMedia(double.Parse(Console.ReadLine()));
            }
            // Resultado
            // Alunos com média maior ou igual a seis
            Console.WriteLine("Alunos com média maior ou igual a seis");
            for (int i = 0; i < 10; i++)
                if (v[i].GetMedia() >= 6)
                    Console.WriteLine($"Aluno: {v[i].GetNome()}, Média: {v[i].GetMedia()}");
            Console.WriteLine("\nAlunos com média menor que seis");
            for (int i = 0; i < 10; i++)
                if (v[i].GetMedia() < 6)
                    Console.WriteLine($"Aluno: {v[i].GetNome()}, Média: {v[i].GetMedia()}");
            Console.ReadKey();
        }
    }
}
