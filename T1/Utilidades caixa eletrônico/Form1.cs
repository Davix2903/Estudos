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

        private void button1_Click(object sender, EventArgs e)
        {
            Conta ContaCharles = new Conta(1, 5000.0, 111-1);
            Cliente clienteCharles = new Cliente("Charles", "111.111.111", "Rua Aparecida", "111.111.111-11", 17);
            ContaCharles.Titular = clienteCharles;
        
            Conta ContaScott = new Conta(2, 200, 222-2);
            Cliente clienteScott = new Cliente("Scott", "222.222.222", "Rua Itajaí", "222.222.222-22", 18);
            ContaScott.Titular = clienteScott;

            Conta contaJames = new Conta(1, 500.0, 333 - 3);
            Cliente clienteJames = new Cliente("James", "526.259.547.25", "Rua itajaí", "256.321.654-96", 19);
            contaJames.Titular = clienteJames;

            MessageBox.Show("O titular da conta 1 é: " + ContaCharles.Titular.nome + ", CPF: " + ContaCharles.Titular.cpf + ", Agência: " +ContaCharles.Agencia + ", Idade: " + ContaCharles.Titular.idade);
            MessageBox.Show("O titular da conta 2 é: " + ContaScott.Titular.nome + ", CPF: " + ContaScott.Titular.cpf + ", Agência: " + ContaScott.Agencia + ", Idade: " + ContaScott.Titular.idade);
            MessageBox.Show("O titular da conta 3 é: " + contaJames.Titular.nome + ", CPF: " + contaJames.Titular.cpf + ", Agência: " + contaJames.Agencia + ", Idade: " + contaJames.Titular.idade);
        
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {

           contaVictor = new Conta(1, 250.0, 111-0);
           clienteVictor = new Cliente("Victor", "", "Rua Paraná", "111.111.111-11", 18);
           contaVictor.Titular = clienteVictor;
           contaVictor.Titular.nome = clienteVictor.nome;

            this.MostraConta();


        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            this.contaVictor.Deposita(valorDeposito);
            this.MostraConta();
        }
    }
}