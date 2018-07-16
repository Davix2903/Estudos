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

        public Cliente Titular;

        public double saldo;

        public int agencia;
        public Conta(int Numero, double Saldo, int Agencia)
        {
            this.numero = Numero;
            this.saldo = Saldo;
            this.agencia = Agencia;
        }

        public Conta() { }

        public bool Saca(double valorASerSacado)
        {
            if (valorASerSacado > this.saldo || valorASerSacado < 0)
            {

                return false;
            }
            else
            {
                if (this.Titular.MaiorDeIdade())
                {
                    this.saldo -= valorASerSacado;

                    return true;
                }
                else
                {

                }
            }
        }
    }

    public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.saldo;

            return rendimento;
        }
    }
}
