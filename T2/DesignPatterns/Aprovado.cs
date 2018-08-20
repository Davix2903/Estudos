using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= (orcamento.Valor * 0.05);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar algo já aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar algo que já foi aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
