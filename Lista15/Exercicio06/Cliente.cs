using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Cliente
    {
        private string nome, cpf;
        private decimal limite;
        private Cliente socio;
        public Cliente(string nome, string cpf, decimal limite)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.limite = limite;
        }
        public void SetSocio(Cliente c)
        {
            // c vai passar a ser sócio de this e this vai ser sócio de c

            // Mas antes tem que remover a sociedade de c, caso exista
            Cliente socio_de_c = c.socio;
            // Se c tiver algum sócio, remove a sociedade desse sócio 
            if (socio_de_c != null) socio_de_c.socio = null;

            // E remover a sociedade atual de this
            Cliente socio_de_this = socio;
            // Se c tiver algum sócio, remove a sociedade desse sócio 
            if (socio_de_this != null) socio_de_this.socio = null;

            // Agora sim, c vai passar a ser sócio de this e this vai ser sócio de c
            c.socio = this;
            this.socio = c;
        }

        public decimal GetLimite()
        {
            // Verifica se tem sócio
            if (socio == null) return limite;
            else return limite + socio.limite;
        }

        public override string ToString()
        {
            if (socio == null)
                return $"{nome} - {cpf} - {limite}";
            else 
                return $"{nome} - {cpf} - {GetLimite()} - {socio.nome}";
        }
    }
}
