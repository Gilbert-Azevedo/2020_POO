using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto com vários espaço desnecessários");
            string s = Console.ReadLine();
            // Chama o método que remove os espaços e mostra o resultado
            Console.WriteLine(RemoverEspacos(s));
            Console.ReadKey();
        }
        public static string RemoverEspacos(string texto)
        {
            // Remove espaços no início e final do texto
            texto = texto.Trim();
            // Divide o texto em palavras
            string[] s = texto.Split();
            // Inicia o resultado com um texto vazio
            string r = string.Empty;
            // Concatena todas as palavras não vazias encontradas
            foreach (string c in s)
                if (c != "") r += (c + " ");
            return r;
        }
    }

}
