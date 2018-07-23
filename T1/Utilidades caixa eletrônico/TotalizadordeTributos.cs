using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_caixa_eletrônico
{
    class TotalizadordeTributos
    {
        public double Total { get; private set; }

        public void Acumula(Tributavel cp)
        {
            Total += cp.CalculaTributo();
        }

        public void Acumula(ContaInvestimento ci)
        {
            Total += ci.CalculaTributo();
        }
    }
}
