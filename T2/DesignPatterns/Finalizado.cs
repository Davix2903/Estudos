using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar algo já finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar algo já finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não é possível finalizar algo já finalizado");
        }
    }
}
