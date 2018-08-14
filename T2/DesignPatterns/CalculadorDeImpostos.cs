using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = orcamento.Valor * 0.1;
                Console.WriteLine(icms);
            }
            else if (true)
            {
                double iss = orcamento.Valor * 0.06;
                Console.WriteLine(iss);
            }


        }

    }
}
