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
            Console.WriteLine("Informe o raio do círculo");
            double r = double.Parse(Console.ReadLine());
            // c e x são referências para objetos círculos
            // Como apenas um objeto foi instanciado (new), ambos c e x 
            // referenciam o mesmo objeto
            Circulo c = new Circulo();
            Circulo x = c;
            // Define o raio do círculo com o valor entrado pelo usuário
            c.SetRaio(r);
            // Mostra o raio do círculo utilizando as duas referências
            Console.WriteLine($"Raio = {c.GetRaio():0.00}");
            Console.WriteLine($"Raio = {x.GetRaio():0.00}");
            // Define o raio do círculo com o valor 15
            c.SetRaio(15);
            // Mostra o raio, a área e a circunferência do círculo
            Console.WriteLine($"Raio = {c.GetRaio():0.00}");
            Console.WriteLine($"Raio = {x.GetRaio():0.00}");
            Console.WriteLine($"Área = {x.CalcArea():0.00}");
            Console.WriteLine($"Circunferência = {x.CalcCircunferencia():0.00}");
            Console.WriteLine(c.ToString());
            // Um novo objeto é instanciado (new) e c passa a ser sua referencia
            // Note que x continua referenciando o círculo de raio 15
            // e c agora referencia um novo círculo que recebe em seguida o valor
            // 10 para o raio
            c = new Circulo();
            c.SetRaio(10);
            Console.WriteLine($"Raio = {c.GetRaio():0.00}");
            Console.WriteLine($"Raio = {x.GetRaio():0.00}");
            Console.ReadKey();
        }
    }
}
