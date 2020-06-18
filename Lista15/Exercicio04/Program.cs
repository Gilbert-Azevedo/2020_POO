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
            // Objeto Histórico
            Historico x = new Historico();
            // Mostra um menu de opções
            Console.WriteLine("Selecione a opção: 1 - Inserir, 2 - Listar, 3 - IRA, 0 - Fim");
            int op = int.Parse(Console.ReadLine());
            // Repete até o usuário selecionar 0 - Fim
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        // Dados da disciplina
                        Console.WriteLine("Informe o nome da disciplina");
                        string n = Console.ReadLine();
                        Console.WriteLine("Informe o semestre");
                        string s = Console.ReadLine();
                        Console.WriteLine("Informe a média");
                        int m = int.Parse(Console.ReadLine());
                        // Nova disciplina
                        Disciplina d = new Disciplina(n, s, m);
                        // Insere a disciplina no histórico 
                        x.Inserir(d);
                        break;
                    case 2:
                        Console.WriteLine("\nDisciplinas cadastradas");
                        // Recupera o vetor com as disciplinas e mostra cada uma
                        foreach (Disciplina disc in x.Listar())
                            Console.WriteLine(disc);
                        break;
                    case 3:
                        Console.WriteLine($"\nIRA = {x.CalcularIRA()}");
                        break;
                }
                Console.WriteLine("Selecione a opção: 1 - Inserir, 2 - Listar, 3 - IRA, 0 - Fim");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
