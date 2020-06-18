using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Loja
    {
        // Nome da loja
        private string nome;
        // Vetor para até 100 veículos
        private Veiculo[] veiculos = new Veiculo[100];
        // Número de veículos já inseridos
        private int k;
        // Construtor da loja
        public Loja(string nome)
        {
            this.nome = nome;
        }
        // Método para inserir um veículo
        public void Inserir(Veiculo c)
        {
            if (k < 100)        // Verifica se ainda não chegou ao limite do vetor
                veiculos[k++] = c; // Insere o veículo no vetor
        }
        // Método para retornar o vetor com os veículos já cadastrados
        public Veiculo[] Listar()
        {
            // Vetor com a quantidade de veículos já cadastrados
            Veiculo[] v = new Veiculo[k];
            // Copia para o vetor de retorno, os veículos já inseridos
            Array.Copy(veiculos, v, k);
            return v;
        }
        // Método para retornar o vetor com os veículos disponíveis atpe um preço máximo
        public Veiculo[] ListarValor(decimal precoMax)
        {
            // Vetor com a quantidade de veículos já cadastrados
            Veiculo[] v = new Veiculo[k];
            int c = 0;
            // Insere no vetor os veículos disponíveis até o valor máximo
            foreach (Veiculo x in Listar())
                if (!x.GetVendido() && x.GetPreco() <= precoMax)
                    v[c++] = x;
            // Vetor de retorno
            Veiculo[] r = new Veiculo[k];
            // Copia para o vetor de retorno, os veículos já inseridos
            Array.Copy(v, r, c);
            return r;
        }
        // Método para calcular disponível na loja a ser vendido
        public decimal Total()
        {
            // O total é calculado com os veículos não vendidos
            decimal t = 0;
            foreach (Veiculo x in Listar())
                if (!x.GetVendido()) t += x.GetPreco();
            return t;
        }
    }
}
