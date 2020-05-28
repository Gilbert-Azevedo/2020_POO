using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Referência para o objeto 
            Frete x;
            // Dados do objeto
            Console.WriteLine("Informe a distância até o dentino em km");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o peso da mercadoria");
            double p = double.Parse(Console.ReadLine());
            // Instancia a classe, passando os dados para o novo objeto chamando
            // o construtor da classe
            x = new Frete(d, p);
            // Mostra dados do objeto. Quando o objeto é apresentado, o método ToString
            // da classe é chamado
            Console.WriteLine(x);
            // Realiza as outras operações do objeto
            Console.WriteLine($"Valor do frete = {x.CalcFrete():c2}");
            Console.ReadKey();
        }
    }
}
