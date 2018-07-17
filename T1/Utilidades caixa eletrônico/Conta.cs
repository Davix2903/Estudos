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

        public double Saldo;

        public int agencia;
        public Conta(int Numero, double saldo, int Agencia)
        {
            this.numero = Numero;
            this.Saldo = saldo;
            this.agencia = Agencia;
        }

        public Conta() { }

        public bool Saca(double valorASerSacado)
        {
            if (valorASerSacado > this.Saldo || valorASerSacado < 0)
            {

                return false;
            }
            else
            {
                if (this.Titular.MaiorDeIdade())
                {
                    this.Saldo -= valorASerSacado;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }





        public void Deposita(double valor)
        {
            this.Saldo += valor;
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

