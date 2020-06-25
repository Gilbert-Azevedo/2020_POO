using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    // A interface ISorteio define os métodos Sortear e Sorteados 
    // que deve ser estar presente nas classes que implementem a interface
    // É usada para retornar números aleatórios em um sorteio
    interface ISorteio
    {
        int Sortear();
        int[] Sorteados();
    }
}
