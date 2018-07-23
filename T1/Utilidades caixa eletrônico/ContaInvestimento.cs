using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_caixa_eletrônico
{
    class ContaInvestimento : Conta, Tributavel
    {

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
