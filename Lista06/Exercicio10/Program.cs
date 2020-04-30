using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine(); 
            // Nesse exemplo, é necessário fazer a repetição de acordo com o número
            // de caracteres da frase: Length
            // Além disso, em cada iteração, passa o primeiro caractere da frase para
            // o final
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[0];             // Primeiro caractere
                string r = s.Substring(1); // Frase sem o primeiro caractere
                s = r + c;                 // Atualiza a frase para o novo valor
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
