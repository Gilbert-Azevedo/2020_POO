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
            Console.WriteLine("Digite seu nome");
            Historico h = new Historico(Console.ReadLine());

            int op = 1;
            while (op != 0) {
                Console.WriteLine("1-Inserir, 2-Listar, 3-IRA, 0-Fim");
                op = int.Parse(Console.ReadLine());
                switch(op) {
                    case 1:
                        Console.WriteLine("Digite Nome, Semestre e Média");
                        Disciplina x = new Disciplina(
                            Console.ReadLine(),
                            Console.ReadLine(),
                            int.Parse(Console.ReadLine()));
                        h.Inserir(x);
                        break;
                    case 2:
                        Console.WriteLine(h);
                        foreach (Disciplina d in h.Listar())
                            Console.WriteLine(d);
                        break;
                    case 3:
                        Console.WriteLine($"IRA = {h.CalcularIRA()}");
                        break;
                }
            }
        }
    }
}
