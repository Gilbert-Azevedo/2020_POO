using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Semelhante ao Exercício 15 da Lista 06
            Console.WriteLine("Digite uma frase:");
            string s = Console.ReadLine();
            // Chama o método que calcula e retorna a senha
            string senha = Senha(s);
            Console.WriteLine(senha);
            Console.ReadKey();
        }
        public static string Senha(string texto)
        {
            // Nesse exemplo, é necessário dividir a frase num vetor de palavras. Isso
            // pode ser feito com Split. 
            // Depois o tamanho de cada palavra deve ser convertido para texto e 
            // concatenado na resposta r
            string[] v = texto.Split();
            string r = string.Empty;
            // Percorre o vetor de palavras. v.Length é o número de palavras
            for (int k = 0; k < v.Length; k++)
            {
                // Cada palavra da frase
                string p = v[k];
                // Concatena o tamanho da palavra na resposta
                r += p.Length.ToString();
            }
            return r;
        }
    }
}
