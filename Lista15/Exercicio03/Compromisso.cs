using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Compromisso
    {
        private string assunto;
        private DateTime data;
        private string local;
        public Compromisso(string a, DateTime d, string l)
        {
            assunto = a;
            data = d;
            local = l;
        }
        public override string ToString()
        {
            return $"{assunto} - {data} - {local}";
        }
    }
}
