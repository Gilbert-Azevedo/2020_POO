using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Conversor
    {
        // Atributos
        private int num;
        // Métodos de Acesso
        public void SetNum(int n)
        {
            // Apenas números positivos são armazenados
            if (n >= 0) num = n;
        }
        public int GetNum()
        {
            return num;
        }
        // Métodos de cálculo
        public string Binario()
        {
            // Implementa o algoritmo de conversão para binário
            string aux = string.Empty;
            int x = num;
            while (x != 0)
            {
                int r = x % 2;
                aux = r + aux;
                x = x / 2;
            }
            return aux;
        }
    }
}
