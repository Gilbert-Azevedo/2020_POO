using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Referência para o objeto 
            Viagem x;
            // Dados do objeto
            Console.WriteLine("Informe a distância da viagem em km");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a tempo em horas");
            double t = double.Parse(Console.ReadLine());
            // Instancia a classe, passando os dados para o novo objeto chamando
            // o construtor da classe
            x = new Viagem(d, t);
            // Mostra dados do objeto. Quando o objeto é apresentado, o método ToString
            // da classe é chamado
            Console.WriteLine(x);
            // Realiza as outras operações do objeto
            Console.WriteLine($"Velocidade média = {x.CalcVelocidade()} km/h");
            Console.ReadKey();
        }
    }
}
