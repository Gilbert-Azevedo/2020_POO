using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Disciplina : object
    {
        private string nome;
        private string semestre;
        private int media;
        private bool aprovado;
        public Disciplina(string nome, string semestre, int media)
        {
            this.nome = nome;
            this.semestre = semestre;
            this.media = media;
            aprovado = media >= 60;
        }
        public override string ToString()
        {
            return aprovado ? $"{nome} {semestre} {media} aprovado" :
                 $"{nome} {semestre} {media} reprovado";
        }
    }
}
