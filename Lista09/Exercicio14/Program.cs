using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome");
            string s = Console.ReadLine();
            // Chama o método de formatação e mostra o resultado
            Console.WriteLine(FormatarNome(s));
            Console.ReadKey();
        }
        public static string FormatarNome(string nome)
        {
            // Alguns passos serão necessários para formatar o nome
            // Passo 1. Passar todo o texto para minúsculo
            nome = nome.ToLower();
            // Passo 2. Separar as palavras do texto
            string[] v = nome.Split();
            // Passo 3. Passar a inicial das palavras para maiúsculo, tratando
            // as exceções listadas no exercício
            for (int i = 0; i < v.Length; i++)
            {
                switch(v[i])
                {
                    // e, da, das, de, do, dos não são alterados
                    case "e":
                    case "da":
                    case "das":
                    case "de":
                    case "do":
                    case "dos": break;
                    // Demais palavras em a primeira letra em maiúsculo
                    default:
                        string s = v[i];
                        s = s[0].ToString().ToUpper() + s.Substring(1);
                        v[i] = s;
                        break;
                }
            }
            // Passo 4. Concatena as palavras
            string r = string.Empty;
            for (int i = 0; i < v.Length; i++)
                r += (v[i] + " ");
            return r;
        }
    }
}
