using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_caixa_eletrônico
{
    class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.1);
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
