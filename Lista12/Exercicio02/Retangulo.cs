using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Retangulo
    {
        // Atributos
        private double b, h;
        // Método construtor. Um construtor permite executar instruções ao se 
        // instanciar a classe. Isso pode ser feito, por exemplo, para iniciar
        // os atributos do objeto com valores direfentes do padrão. Para isso,
        // é necessário definir um construtor que receba os valores iniciais a 
        // serem atribuídos ao objeto.
        // Um construtor tem sempre o mesmo nome da classe e não declara um
        // tipo de retorno. Todo construtor retorna uma referência para o objeto
        // instanciado
        public Retangulo(double b, double h)
        {
            // Atribui os argumentos recebidos aos atributos do novo objeto
            this.b = b;
            this.h = h;
        }
        // Métodos de acesso. Métodos Set podem alterar os valores iniciais passados
        // para o construtor. Observe que a diferença principal é que o construtor
        // cria umanova instância enquanto o Set altera uma instância que já existe
        public void SetBase(double b)
        {
            this.b = b;
        }
        public void SetAltura(double h)
        {
            this.h = h;
        }
        public double GetBase()
        {
            return b;
        }
        public double GetAltura()
        {
            return h;
        }
        // Métodos de cálculo
        public double CalcArea()
        {
            // Calcula a área do retângulo a partir dos valores de base e altura
            return b * h;
        }
        public double CalcDiagonal()
        {
            // Calcula a diagonal do retângulo a partir dos valores de base e altura
            return Math.Sqrt(b * b + h * h);
        }
        // Redefinição do método ToString
        // O ToString é um método que existe em toda classe e normalmente é utilizado
        // para mostrar alguma informação sobre o objeto. O comportamento padrão do
        // método é retornar um texto com o nome da classe. Nesse exemplo, o método
        // vai ser alterado para mostrar um texto contendo o estado do objeto, no caso,
        // os valores da base e da altura
        // Todo método que é redefinido vem com a instrução override em sua assinatura.
        // Isso é devido ao conceito de Herança que será estudado mais adiante.
        public override string ToString()
        {
            return $"Retângulo com Base = {b} e Altura = {h}";
        }
    }
}
