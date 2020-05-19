using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    // Uma estrutura define um novo tipo de variável. 
    // Nesse exemplo, a estrutura IMC define um tipo com três campos, 
    // todos números reais: Massa, Altura, Imc
    // Consequentemente, uma variável deste tipo pode armazenar três valores reais,
    // um em cada campo. Esta variável armazena Massa, Altura e Imc de uma pessoa
    struct IMC
    {
        public double Massa;
        public double Altura;
        public double Imc;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Esse exemplo é semelhante ao exercício 09 da lista 01
            // A diferença está apenas no tipo de variável utilizada
            // Cada campo da variável pessoa é acessado com o operador "."
            IMC pessoa;
            Console.WriteLine("Informe sua massa em kg:");
            pessoa.Massa = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura em metros:");
            pessoa.Altura = double.Parse(Console.ReadLine());
            pessoa.Imc = pessoa.Massa / pessoa.Altura / pessoa.Altura;
            Console.WriteLine($"Seu IMC é {pessoa.Imc:0.00}");
            Console.ReadKey();
        }
    }
}
