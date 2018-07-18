﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_caixa_eletrônico
{
    public class Cliente
    {
        public string nome;

        public string rg;

        public string endereco;

        public string cpf;

        public int idade;

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

    }
}
