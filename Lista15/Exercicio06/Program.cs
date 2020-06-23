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
            // Objeto empresa
            Empresa x = new Empresa();
            // Mostra um menu de opções
            Console.WriteLine("Selecione a opção: 1 - Inserir, 2 - Listar, 3 - Sócio, 0 - Fim");
            int op = int.Parse(Console.ReadLine());
            // Repete até o usuário selecionar 0 - Fim
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        // Dados do cliente
                        Console.WriteLine("Informe o nome do cliente");
                        string n = Console.ReadLine();
                        Console.WriteLine("Informe o cpf");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Informe o limite");
                        decimal l = decimal.Parse(Console.ReadLine());
                        // Novo cliente
                        Cliente c = new Cliente(n, cpf, l);
                        // Insere o cliente na empresa 
                        x.Inserir(c);
                        break;
                    case 2:
                        Console.WriteLine("\nClientes cadastrados");
                        // Recupera o vetor com os clientes e mostra cada um
                        foreach (Cliente s in x.Listar())
                            Console.WriteLine(s);
                        break;
                    case 3:
                        Console.WriteLine("\nClientes cadastrados");
                        Cliente[] cs = x.Listar();
                        for (int k = 0; k < cs.Length; k++)
                            Console.WriteLine($"{k} - {cs[k]}");
                        Console.WriteLine("\nInforme os clientes a se associarem");
                        int i = int.Parse(Console.ReadLine());
                        int j = int.Parse(Console.ReadLine());
                        if (i >= 0 && j >= 0 && i < cs.Length && j < cs.Length)
                        {
                            // Associa os clientes i e j
                            cs[i].SetSocio(cs[j]);
                            Console.WriteLine("Sociedade cadastrada");
                        }
                        break;
                }
                Console.WriteLine("Selecione a opção: 1 - Inserir, 2 - Listar, 3 - Sócio, 0 - Fim");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
