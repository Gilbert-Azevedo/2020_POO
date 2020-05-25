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
            // Dados da Conta
            ContaBancaria c = new ContaBancaria();
            Console.WriteLine("Informe o titular e número da conta");
            c.SetTitular(Console.ReadLine());
            c.SetNumero(Console.ReadLine());
            Console.WriteLine($"Titular: {c.GetTitular()}   Conta: {c.GetNumero()}");
            // Menu
            int op = 1;
            while (op != 0)
            {
                Console.WriteLine("0-Fim 1-Depositar 2-Sacar 3-Ver Saldo");
                op = int.Parse(Console.ReadLine());
                switch (op) {
                    case 1:
                        Console.WriteLine("Informe o valor do depósito");
                        double d = double.Parse(Console.ReadLine());
                        if (c.Depositar(d)) Console.WriteLine("Depósito realizado com sucesso");
                        else Console.WriteLine("Valor informado é inválido");
                        break;
                    case 2:
                        Console.WriteLine("Informe o valor do saque");
                        double s = double.Parse(Console.ReadLine());
                        if (c.Sacar(s)) Console.WriteLine("Saque realizado com sucesso");
                        else Console.WriteLine("Valor informado é inválido ou saldo insuficiente");
                        break;
                    case 3:
                        Console.WriteLine($"Saldo Atual: {c.VerificaSaldo():c2}");
                        break;
                }
            }
        }
    }
}
