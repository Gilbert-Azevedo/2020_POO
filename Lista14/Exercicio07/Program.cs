using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
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
                Console.Write($"Informe o nome do {i + 1}º aluno: ");
                v[i].SetNome(Console.ReadLine());
                Console.Write($"Informe a média: ");
                v[i].SetMedia(double.Parse(Console.ReadLine()));
            }
            // Ordenação pelo nome do aluno
            // O método Sort poderia ser usado mas seria necessário a utilização
            // do conceito de Interface. Portanto, a ordenação será feita pelo
            // método selection sort
            for (int i = 0; i < 9; i++)
                for (int j = i + 1; j < 10; j++)
                    if (v[i].GetNome().CompareTo(v[j].GetNome()) == 1)
                    {
                        Aluno aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            // Resultado
            Console.WriteLine("Relação de alunos ordenada");
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Aluno: {v[i].GetNome()}, Média: {v[i].GetMedia()}");
            Console.ReadKey();
        }
    }
}
