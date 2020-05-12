using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string s = Console.ReadLine();
            Console.WriteLine("Digite a posição da palavra a ser encontrada");
            int p = int.Parse(Console.ReadLine());
            // Chama o método que retorna a palavra na posição informada
            string r = Palavra(s, p);
            Console.WriteLine(r);
            Console.ReadKey();
        }
        public static string Palavra(string texto, int pos)
        {
            // Nesse exemplo, pode ser utilizado o Split ou IndexOf
            // A solução com Split é mais simples
            string[] v = texto.Split();
            // Verifica se existe palavra na posição pos e retorna
            if (pos < v.Length) return v[pos];
            // Retorna vazio caso a posição seja inválida
            return string.Empty;
        }
    }
}
