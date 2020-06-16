using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objeto Agenda
            Agenda ag = new Agenda();
            // Mostra um menu de opções
            Console.WriteLine("Selecione a opção: 1 - Inserir, 2 - Listar, 0 - Fim");
            int op = int.Parse(Console.ReadLine());
            // Repete até o usuário selecionar 0 - Fim
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        // Dados do compromisso
                        Console.WriteLine("Informe o assunto da reunião");
                        string a = Console.ReadLine();
                        Console.WriteLine("Informe a data da reunião no formato dd/mm/aaaa");
                        DateTime d = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o local da reunião");
                        string l = Console.ReadLine();
                        // Novo compromisso
                        Compromisso c = new Compromisso(a, d, l);
                        // Insere o compromisso na agenda
                        ag.Inserir(c);
                        break;
                    case 2:
                        Console.WriteLine("\nCompromissos cadastrados");
                        // Recupera o vetor com os compromissos e mostra cada um
                        foreach (Compromisso x in ag.Listar())
                            Console.WriteLine(x);
                        break;
                }
                Console.WriteLine("\nSelecione a opção: 1 - Inserir, 2 - Listar, 0 - Fim");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
