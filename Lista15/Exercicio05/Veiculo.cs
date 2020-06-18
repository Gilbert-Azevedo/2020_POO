using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Veiculo
    {
        private string placa, fabricante, modelo;
        private int ano;
        private decimal preco;
        private bool vendido;
        public Veiculo(string p, string f, string m, int a, decimal pr)
        {
            placa = p;
            fabricante = f;
            modelo = m;
            ano = a;
            preco = pr;
            vendido = false;
        }
        public override string ToString()
        {
            if (vendido)
              return $"{placa} - {fabricante} - {modelo} - {ano} - {preco} - Vendido";
            else
              return $"{placa} - {fabricante} - {modelo} - {ano} - {preco} - Disponível";    
        }
        public void Vender()
        {
            vendido = true;
        }
        public decimal GetPreco()
        {
            return preco;
        }
        public bool GetVendido()
        {
            return vendido;
        }
    }
}
