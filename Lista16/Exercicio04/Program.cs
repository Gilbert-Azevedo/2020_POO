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
            // Instancia 3 países
            Pais a = new Pais("Aaaaaa", 10, 8, 6);
            Pais b = new Pais("Bbbbbb", 10, 8, 7);
            Pais c = new Pais("Cccccc", 10, 8, 6);
            // Instancia o quadro de medalha e insere os países
            QuadroMedalhas q = new QuadroMedalhas();
            // Insere os países no quadro
            q.Inserir(a);
            q.Inserir(b);
            q.Inserir(c);
            // Mostra os países no quadro. Bbbbbb deve aparecer em primeiro por
            // ter mais medalhas de bronze, seguido de Aaaaaa que possui mesma
            // quantidade de medalhas que Cccccc. Nesse caso, a listagem mostra
            // em ordem alfabética
            foreach (Pais p in q.Listar())
                Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
