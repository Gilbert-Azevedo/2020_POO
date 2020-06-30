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
            // Instancia 4 candidatos
            Candidato a = new Candidato("Aaaaaa", DateTime.Parse("01/01/2001"), 80);
            Candidato b = new Candidato("Bbbbbb", DateTime.Parse("01/01/2002"), 80);
            Candidato c = new Candidato("Cccccc", DateTime.Parse("01/01/2000"), 90);
            Candidato d = new Candidato("Dddddd", DateTime.Parse("01/01/2004"), 50);
            // Instancia concurso e insere os candidatos
            Concurso q = new Concurso();
            // Insere os candidatos no concurso
            q.Inserir(a);
            q.Inserir(b);
            q.Inserir(c);
            q.Inserir(d);
            // Mostra os candidatos ordenados por pontos e idade
            foreach (Candidato p in q.Listar()) Console.WriteLine(p);
            // Mostra os candidatos classificados
            Console.WriteLine();
            foreach (Candidato p in q.Classificados()) Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
