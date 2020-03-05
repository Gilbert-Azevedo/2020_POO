using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Disciplina
    {
        private string nome;
        private int nota1, nota2, notaF;
        public void SetNome(string n) {
            nome = n;
        }
        public void SetNota1(int n) {
            if (n >= 0 && n <= 100) nota1 = n;
            else throw new ArgumentOutOfRangeException();
        }
        public void SetNota2(int n) {
            if (n >= 0 && n <= 100) nota2 = n;
        }
        public void SetNotaF(int n) {
            if (n >= 0 && n <= 100) notaF = n;
        }
        public int CalcMedia() {
            int m = (2 * nota1 + 3 * nota2) / 5;
            if (m < 60)
            {
                int m1 = (m + notaF) / 2;
                int m2 = (2 * notaF + 3 * nota2) / 5;
                int m3 = (2 * nota1 + 3 * notaF) / 5;
                m = Math.Max(m1, Math.Max(m2, m3));
            }
            return m;
        }
    }
}
