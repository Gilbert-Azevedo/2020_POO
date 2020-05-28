using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Referência para o objeto Esfera
            Esfera x;
            // Instancia a classe
            x = new Esfera();
            // Define valor do atributo
            Console.WriteLine("Informe o raio da esfera");
            x.SetRaio(double.Parse(Console.ReadLine()));
            // Mostra dados do objeto
            Console.WriteLine($"Raio da esfera = {x.GetRaio()}");
            // Realiza as outras operações do objeto
            Console.WriteLine($"Área da esfera = {x.CalcArea()}");
            Console.WriteLine($"Volume da esfera = {x.CalcVolume()}");
            Console.ReadKey();
        }
    }
}
