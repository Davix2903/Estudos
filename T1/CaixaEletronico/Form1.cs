using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Benner.CaixaEletronico.Contas;
using Benner.CaixaEletronico.Usuario;

namespace Benner.CaixaEletronico
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

        private void MostraConta(Conta conta)
        {
            textotitulare.Text = conta.Titular.nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);

            //comboContas.Text = BuscaContaSelecionada().Titular.nome;
            //textoSaldo.Text = Convert.ToString(contas.[].Saldo);
            //textoNumero.Text = Convert.ToString(contas[].Numero);
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[2];
            contas[0] = new ContaCorrente();
            contas[0].Titular = new Cliente();
            contas[0].Titular.nome = "Vitor";
            contas[0].Numero = 00;
            contas[0].Deposita(50.0);

            contas[1] = new ContaCorrente();
            contas[1].Titular = new Cliente();
            contas[1].Titular.nome = "Julio";
            contas[1].Numero = 11;
            contas[1].Deposita(135.0);

            for (int i = 0; i < contas.Length; i++)
            {
                comboContas.Items.Add(contas[i].Titular.nome);
                comboTransfere.Items.Add(contas[i].Titular.nome);

            }
            //foreach (var c in contas)
            //{
            //    comboContas.Items.Add(c.Titular.nome);
            //}
            //this.MostraConta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            //Conta contaSelecionada = this.BuscaContaSelecionada();
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];
            contaSelecionada.Deposita(valorDeposito);
            MostraConta(contaSelecionada);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string textoValorSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoValorSaque);
            Conta contaSelecionada = this.BuscaContaSelecionada();

            try
            {
                contaSelecionada.Saca(valorSaque);

                this.MostraConta(contaSelecionada);
                MessageBox.Show("Dinheiro liberado com sucesso!");
            }            catch (ArgumentException exception)
            {
                MessageBox.Show("Valor inválido para saque");
            }
            catch (saldoInsuficienteException exception)
            {
                MessageBox.Show("Saldo insuficiente!");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContaCorrente[] contas = new ContaCorrente[2];
            contas[0] = new ContaCorrente();
            contas[1] = new ContaCorrente();

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
            double valorTransferencia = Convert.ToDouble(textoValor.Text);

            contaSelecionada.Transfere(valorTransferencia, contaDestino);

            this.MostraConta(contaSelecionada);
        }

        private void comboTransfere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ContaInvestimento ci = new ContaInvestimento();
            ci.Deposita(50.0);
            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(100.0);
            TotalizadordeTributos t = new TotalizadordeTributos();
            t.Acumula(cp);
            t.Acumula(cp);
            MessageBox.Show("Tributos: " + t.Total);
        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textotitulare_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}