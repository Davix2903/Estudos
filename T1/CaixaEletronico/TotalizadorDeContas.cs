﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronico.Contas;

namespace Benner.CaixaEletronico
{
    class TotalizadorDeContas
    {
        public double Total { get; private set; }
        public void Adiciona (Conta conta)
        {
            this.Total += conta.Saldo;
        }
    }
}