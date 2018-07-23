using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronico.Contas;

namespace Benner.CaixaEletronico
{
    class TotalizadordeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel cp)
        {
            Total += cp.CalculaTributo();
        }

        public void Acumula(ContaInvestimento ci)
        {
            Total += ci.CalculaTributo();
        }
    }
}
