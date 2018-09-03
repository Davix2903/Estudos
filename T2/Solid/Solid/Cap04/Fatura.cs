using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap04
{
    class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        private List<Pagamento> Pagamentos;
        private IEnumerable<Pagamento> pagamentos;

        public bool Pago { get; private set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }

        internal void AdicionaPagamento()
        {
            throw new NotImplementedException();
        }

        public AdicionaPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);

            if(valorTotalDosPagamentos >= Valor)
            {
                this.Pago = true;
            }
        }

        private double valorTotalDosPagamentos()
        {
            double total = 0;

            foreach (Pagamento pag in pagamentos)
            {
                total += pag.Valor;
            }

                return total;
        }


    }
}
