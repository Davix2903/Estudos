using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benner.CaixaEletronico.Usuario
{
    public class Cliente
    {
        public string nome;

        public string rg;

        public string endereco;

        public string cpf;

        public int idade;

        public bool EEmancipado { get; set; }

        public bool MaiorDeIdade()
        {
            return this.idade >= 18;
        }

        public Cliente(string Nome, string Rg, string Endereco, string Cpf, int Idade)
        {
            this.nome = Nome;
            this.rg = Rg;
            this.endereco = Endereco;
            this.cpf = Cpf;
            this.idade = Idade;
        }
        public Cliente () { }

        public Cliente(string Nome)
        {
            this.nome = Nome;
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = (Cliente)obj;
            return.this.rg.Equals(cliente.rg);
        }

    }
    
}
