using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine(); 
            // Nesse exemplo, basta percorrer a string do início ao fim (Length-1)
            // e verificar cada caractere
            // Para cada vogal, é necessário um contador
            int a = 0, e = 0, i = 0, o = 0, u = 0;
            // Passa a frase para minúsculo para não precisar testar maiúsculos e minúsculos
            s = s.ToLower();
            // Percorre os caracteres
            for (int k = 0; k < s.Length; k++)
                switch(s[k])
                {
                    case 'a': a++; break; // Incremente se for cada uma das vogais
                    case 'e': e++; break;
                    case 'i': i++; break;
                    case 'o': o++; break;
                    case 'u': u++; break;
                }
            Console.WriteLine($"A - {a}");
            Console.WriteLine($"E - {e}");
            Console.WriteLine($"I - {i}");
            Console.WriteLine($"O - {o}");
            Console.WriteLine($"U - {u}");
            Console.ReadKey();
        }
    }
}
