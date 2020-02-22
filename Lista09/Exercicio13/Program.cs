using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        public static string RemoverEspacos(string texto)
        {
            texto = texto.Trim();
            string[] s = texto.Split(' ');
            string r = string.Empty;
            foreach (string c in s)
                if (c != "") r += (c + " ");
            return r;
        }
        static void Main(string[] args)
        {
            string s = "   William    Henry    Gates    III    ";
            Console.WriteLine(RemoverEspacos(s));
            Console.ReadKey();

        }
    }

}
