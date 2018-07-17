using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades_caixa_eletrônico
{
    class Conta
    {
        public int numero { get; set; }

        public Cliente Titular { get; set; }

        public double Saldo { get; private set; }

        public int agencia;
        public Conta(int Numero, double saldo, int Agencia)
        {
            this.numero = Numero;
            this.Saldo = saldo;
            this.agencia = Agencia;
        }

        public Conta() { }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);

        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.Saldo;

            return rendimento;
        }

    }
}

