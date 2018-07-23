using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_caixa_eletrônico
{
    class ContaCorrente : Conta
    {
        public static int  TotalDeContas { get; private set; }
        public ContaCorrente() 
        {
        ContaCorrente.TotalDeContas++;
        }
        public override void Saca (double Valor)
        {
            this.Saldo -= Valor + 0.01;
        }
    }
}
