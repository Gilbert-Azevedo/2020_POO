using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Aluno
    {
        private string nome;
        private double media;
        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetMedia(double m)
        {
            media = m;
        }
        public string GetNome()
        {
            return nome;
        }
        public double GetMedia()
        {
            return media;
        }
    }
}
