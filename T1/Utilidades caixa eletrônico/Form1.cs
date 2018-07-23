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
        Conta[] contas;

        public int quantidadeDeContas;

        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private void MostraConta()
        {
            comboContas.Text = BuscaContaSelecionada().Titular.nome;
            textoSaldo.Text = Convert.ToString(contas[0].Saldo);
            textoNumero.Text = Convert.ToString(contas[0].Numero);
        }

        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[2];
            contas[0] = new Conta();
            contas[0].Titular = new Cliente();
            contas[0].Titular.nome = "Vitor";
            contas[0].Numero = 00;
            contas[0].Deposita(50.0);
            
            contas[1] = new Conta();
            contas[1].Titular = new Cliente();
            contas[1].Titular.nome = "Julio";
            contas[1].Numero = 11;
            contas[1].Deposita(135.0);

            for (int i = 0; i < contas.Length; i++)
            {
                comboContas.Items.Add(contas[i].Titular.nome);
            }
            //this.MostraConta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Deposita(valorDeposito);
            this.MostraConta(contaSelecionada);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string textoValorSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoValorSaque);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Saca(valorSaque);
            this.MostraConta(contaSelecionada);
        }

        private void MostraConta(Conta contaSelecionada)
        {

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


        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
             int indiceSelecionado = comboContas.SelectedIndex;
             Conta contaSelecionada = contas[indiceSelecionado];
             textotitulare.Text = contaSelecionada.Titular.nome;
             textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
             textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
             this.MostraConta(contaSelecionada);
        }

        private void textotitulare_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();

            int indiceDaContaDestino = comboTransfere.SelectedIndex;

            Conta contaDestino = this.contas[indiceDaContaDestino];

            string textoValue = textoValor.Text;
            double valorTransferencia = Convert.ToDouble(textoValor);

            contaSelecionada.Transfere(valorTransferencia, contaDestino);

            this.MostraConta(contaSelecionada);
        }

        private void comboTransfere_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];
            textotitulare.Text = contaSelecionada.Titular.nome;
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            this.MostraConta(contaSelecionada);
        }
    }
}