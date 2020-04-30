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
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine(); 
            // Nesse exemplo, é necessário testar cada caractere para saber se é um
            // algarismo. Se for, converte para inteiro e efetua a soma na variável
            // auxiliar total
            int total = 0;
            for(int i = 0; i < s.Length; i++)
            {
                // Recupera cada caractere da string
                char c = s[i];
                // Teste se é algum algarismo
                if (c >= '1' && c <= '9')
                    // Soma o algarismo
                    total += int.Parse(c.ToString());
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
