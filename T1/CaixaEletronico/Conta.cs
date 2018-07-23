using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronico;
using Benner.CaixaEletronico.Usuario;

namespace Benner.CaixaEletronico.Contas
{
    public abstract class Conta
    {
        public int Numero { get; set; }

        public Cliente Titular { get; set; }

        public double Saldo { get; protected set; }

        public int Agencia { get; set; }
        public Conta(int numero, double saldo, int agencia)
        {
            this.Numero = numero;
            this.Saldo = saldo;
            this.Agencia = agencia;
        }

        public Conta() { }

        public abstract void Saca(double valor);
        

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

