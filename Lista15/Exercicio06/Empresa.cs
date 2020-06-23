using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Empresa
    {
        // Vetor para até 100 clientes
        private Cliente[] clientes = new Cliente[100];
        // Número de clientes já inseridos
        private int k;
        // Método para inserir um cliente
        public void Inserir(Cliente c)
        {
            if (k < 100)           // Verifica se ainda não chegou ao limite do vetor
                clientes[k++] = c; // Insere o cliente no vetor
        }
        // Método para retornar o vetor com os clientes já cadastrados
        public Cliente[] Listar()
        {
            // Vetor com a quantidade de clientes já cadastrados
            Cliente[] v = new Cliente[k];
            // Copia para o vetor de retorno, os clientes já inseridos
            Array.Copy(clientes, v, k);
            return v;
        }
    }
}
