using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades_caixa_eletrônico
{
    public partial class Form1 : Form
    {
        private void MostraConta()
        {

            textoTitular.Text = contaVictor.Titular.nome;
            textoSaldo.Text = Convert.ToString(contaVictor.Saldo);
            textoNumero.Text = Convert.ToString(contaVictor.Numero);
        }
        Conta contaVictor;
        Cliente clienteVictor;

        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {

           contaVictor = new Conta(1, 250.0, 111-0);
           clienteVictor = new Cliente("Victor", "", "Rua Paraná", "111.111.111-11", 18);
           contaVictor.Titular = clienteVictor;
           contaVictor.Titular.nome = clienteVictor.nome;

            this.MostraConta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.contaVictor.Deposita(valorDeposito);
            this.MostraConta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textoDoValorDoSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoDoValorDoSaque);
            this.contaVictor.Saca(valorSaque);
            this.MostraConta();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta[] contas = new Conta[2];
            contas[0] = new Conta();
            contas[1] = new ContaPoupanca();

            contas[0].Deposita(10.0);
            contas[1].Deposita(100.0);
            for (int i = 0; i < contas.Length; i++)
            {
                MessageBox.Show("O saldo da conta é: " + contas[i].Saldo);
            }

            /*foreach (Conta conta in contas)
            {
            }
            */
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}