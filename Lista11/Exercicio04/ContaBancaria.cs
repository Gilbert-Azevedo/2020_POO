using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class ContaBancaria
    {
        // Atributos
        private string titular, numero;
        private double saldo;
        // Métodos Acessores
        public void SetTitular(string titular)
        {
            // Define o titular da conta
            this.titular = titular;
        }
        public string GetTitular()
        {
            // Recupera o titular da conta
            return titular;
        }
        public void SetNumero(string numero)
        {
            // Define o número da conta
            this.numero = numero;
        }
        public string GetNumero()
        {
            // Recupera o número da conta
            return numero;
        }
        public bool Depositar(double valor)
        {
            if (valor <= 0) return false; // Não pode depositar um valor nulo ou negativo
            saldo += valor;               // Incrementa o saldo caso o depósito seja válido
            return true;
        }
        public bool Sacar(double valor)
        {
            if (valor <= 0) return false;    // Não pode sacar um valor nulo ou negativo
            if (valor > saldo) return false; // Não pode sacar um valor maior que o saldo
            saldo -= valor;                  // Decrementa o saldo caso o saque seja válido
            return true;
        }
        public double VerificaSaldo()
        {
            return saldo; // Retorna o saldo atual
        }
    }
}
