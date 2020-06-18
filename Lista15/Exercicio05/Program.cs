using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objeto Loja
            Console.WriteLine("Informe o nome da loja");
            Loja x = new Loja(Console.ReadLine());
            // Mostra um menu de opções
            Console.WriteLine("Selecione a opção: 1 - Inserir, 2 - Listar, 3 - Preço Max, 4 - Vender, 5 - Total, 0 - Fim");
            int op = int.Parse(Console.ReadLine());
            // Repete até o usuário selecionar 0 - Fim
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        // Dados do veículo
                        Console.WriteLine("Informe a placa do veículo");
                        string p = Console.ReadLine();
                        Console.WriteLine("Informe o fabricante");
                        string f = Console.ReadLine();
                        Console.WriteLine("Informe o modelo");
                        string m = Console.ReadLine();
                        Console.WriteLine("Informe o ano");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o preço");
                        decimal pr = decimal.Parse(Console.ReadLine());
                        // Nova veículo
                        Veiculo d = new Veiculo(p,f, m, a, pr);
                        // Insere o veículo na loja como disponível à venda
                        x.Inserir(d);
                        break;
                    case 2:
                        Console.WriteLine("\nVeículos cadastrados");
                        foreach (Veiculo w in x.Listar())
                            Console.WriteLine(w);
                        break;
                    case 3:
                        Console.WriteLine("Informe o preço máximo da busca");
                        decimal pmax = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("\nVeículos disponíveis até o valor");
                        foreach (Veiculo w in x.ListarValor(pmax))
                            Console.WriteLine(w);
                        break;
                    case 4:
                        Console.WriteLine("\nVeículos cadastrados");
                        Veiculo[] v = x.Listar();    
                        for(int k = 0; k < v.Length; k++)
                            Console.WriteLine($"{k} - {v[k]}");
                        Console.WriteLine("\nInforme o veículo a ser vendido");
                        int i = int.Parse(Console.ReadLine());
                        if (i >= 0 && i < v.Length)
                        {
                            v[i].Vender();
                            Console.WriteLine("Venda cadastrada");
                        }
                        break;
                    case 5:
                        Console.WriteLine($"\nTotal na Loja = {x.Total()}");
                        break;
                }
                Console.WriteLine("Selecione a opção: 1 - Inserir, 2 - Listar, 3 - Preço Max, 4 - Vender, 5 - Total, 0 - Fim");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
