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
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine();
            // Nesse exemplo, a repetição é feita enquanto houver espaços
            // separando as palavras da frase 
            // É possível verificar se há espaço, com o método IndexOf
            int p = s.IndexOf(' ');
            while (p != -1) // Um espaço foi encontrado
            {
                // Mostra a frase
                Console.WriteLine(s);
                // Remove a primeira palavra da frase, recuperando a própria frase
                // a partir da posição da segunda palavra
                s = s.Substring(p + 1);
                // Procura novamente um espaço, para verificar se a repetição vai
                // ser realizada novamente
                p = s.IndexOf(' ');
            }
            // Mostra a última palavra da frase quando não houver mais nenhum espaço
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
