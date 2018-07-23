using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronico.Usuario;
using Benner.CaixaEletronico.Contas;

namespace Benner.CaixaEletronico.Contas
{
    class ContaCorrente : Conta
    {
        public static int TotalDeContas { get; private set; }
        public ContaCorrente()
        {
            ContaCorrente.TotalDeContas++;
        }
        public override void Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
            }
            else if (valor < 0)
            {
                throw new ArgumentException();
            }
            else if (valor > Saldo)
            {
                throw new saldoInsuficienteException();
            }
        }
    }
}
