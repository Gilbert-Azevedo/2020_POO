using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    // A interface ISequencia define os métodos Iniciar e Proximo 
    // que devem ser estar presentes nas classes que implementem a interface
    // É usada para mostrar elementos de uma sequência de valores
    interface ISequencia
    {
        void Iniciar();
        int Proximo();
    }
}
