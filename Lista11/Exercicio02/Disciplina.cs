using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Disciplina
    {
        // Atributos encapsulados
        private string nome;
        private int nota1, nota2, notaF;
        // Métodos acessores. Apenas os sets foram implementados. 
        // Normalmente os gets também são implementados
        // É importante ainda que os valores sejam verificados antes de serem
        // armazenados no atributo. Isso pode impedir, por exemplo, que uma
        // nota tenha valor negativo ou maior que 100.
        // A validação dos valores vai ser realizada no futuro e, em casos de 
        // erro, uma notificação de erro será realizada
        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetNota1(int n)
        {
            nota1 = n;
        }
        public void SetNota2(int n)
        {
            nota2 = n;
        }
        public void SetNotaF(int n)
        {
            notaF = n;
        }
        // O cálculo da média usa uma média ponderada de pesos 2 e 3
        // e, caso seja menor que 60, uma média aritmética com a média parcial
        public int CalcMedia()
        {
            int media = (2 * nota1 + 3 * nota2) / 5;
            if (media < 60) media = (media + notaF) / 2;
            return media;
        }
    }
}
