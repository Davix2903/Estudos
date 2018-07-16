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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta ContaCharles = new Conta();
            ContaCharles.numero = 1;
            ContaCharles.titular = "Charles Xavier";
            ContaCharles.saldo = 5000.0;
            ContaCharles.cpf = "111.111.111-11";
            ContaCharles.agencia = 1;

            Conta ContaScott = new Conta();
            ContaScott.numero = 2;
            ContaScott.titular = "Scott Summers";
            ContaScott.saldo = 2000.0;
            ContaScott.cpf = "222.222.222-22";
            ContaScott.agencia = 2;

            MessageBox.Show("O titular da conta 1 é: " + ContaCharles.titular + " CPF: " +ContaCharles.cpf + " Agência: " +ContaCharles.agencia);
            MessageBox.Show("O titular da conta 2 é: " + ContaScott.titular + " CPF: " + ContaScott.cpf + " Agência: " + ContaScott.agencia);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Conta ContaJames = new Conta();
            ContaJames.numero = 3;
            ContaJames.titular = "James Howlett";
            ContaJames.saldo = 100.0;
            ContaJames.cpf = "333.333.333-33";
            ContaJames.agencia = 3;
            MessageBox.Show("O titular da conta 3 é: " + ContaJames.titular);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta guilherme = new Conta();
            Conta alessandro = new Conta();

            guilherme.saldo = 1500.0;
            alessandro.saldo = 2000.0;

            guilherme.Deposita (200);
            MessageBox.Show("O atual da conta é: "+guilherme.saldo);
        }
    }
}
