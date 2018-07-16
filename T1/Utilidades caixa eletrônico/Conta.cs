using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_caixa_eletrônico
{
    class Conta
    {
        public int numero;

        public string titular;

        public double saldo;

        public string cpf;

        public int agencia;

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere (double valor, Conta destino)
        {
            this.saldo -= valor;
            destino.saldo += valor;
        }
    }
}
