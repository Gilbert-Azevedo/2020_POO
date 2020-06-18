using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Disciplina
    {
        private string nome, semestre;
        private int media;
        private bool aprovado;
        public Disciplina(string n, string s, int m)
        {
            nome = n;
            semestre = s;
            media = m;
            aprovado = media >= 60;
        }
        public override string ToString()
        {
            if (aprovado)
                return $"{nome} - {semestre} - {media} - Aprovado";
            else
                return $"{nome} - {semestre} - {media} - Reprovado";
        }
        public int GetMedia()
        {
            return media;
        }
        public bool GetAprovado()
        {
            return aprovado;
        }
    }

}
