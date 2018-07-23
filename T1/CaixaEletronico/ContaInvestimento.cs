using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benner.CaixaEletronico.Contas
{
    class  ContaInvestimento : Conta, ITributavel
    {

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
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
