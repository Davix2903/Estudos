using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronico.Contas;

namespace CaixaEletronico
{
    public class Banco
    {
       private Conta[] contabancaria = new Conta[10];
  
    private int quantidade;

    public void Adiciona (Conta conta)
    {
            this.contabancaria[this.quantidade] = conta;
            this.quantidade++;
    }

    }
}
