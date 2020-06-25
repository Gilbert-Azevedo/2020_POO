using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    // Refatoração da classe Bingo do Exercício 02 da Lista 15
    class Bingo : ISorteio
    {
        // Atributos do bingo
        private int numBolas;
        private int[] nums;   // Vetor com os números sorteados
        private int k;        // Números sorteados até o momento

        // Método de início do jogo
        public Bingo(int numBolas)
        {
            k = 0;                     // Nenhum número sorteado no início do jogo
            nums = new int[numBolas];  // Vetor para armazenar as bolas
            this.numBolas = numBolas;  // Número de bolas do jogo
            Random r = new Random();   // Gerador de números aleatórios
            int n = 0;                 // Números já sorteados
            while (n < numBolas)       // Repete a inserção de números até preencher o vetor
            {
                int x = r.Next(numBolas) + 1; // Gera um número entre 1 e o nº bolas
                if (!nums.Contains(x))        // Se o nº não estiver no vetor, insere
                    nums[n++] = x;
            }
        }
        // Método que retorna um número sorteado
        public int Sortear()
        {
            if (k == numBolas) return -1; // Jogo encerrado retorna -1
            int x = nums[k++];            // Número sorteado
            return x;
        }
        // Método que retorna os números sorteados até o momento
        public int[] Sorteados()
        {
            int[] v = new int[k];         // Vetor com k elementos
            Array.Copy(nums, v, k);       // Copia os números já sorteados
            return v;                     // Retorna o vetor
        }
    }
}
