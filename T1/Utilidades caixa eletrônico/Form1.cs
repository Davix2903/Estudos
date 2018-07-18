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
        Conta guilherme;
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


        private void button4_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.Deposita(800);
            MessageBox.Show(".." + mauricio.Saldo);
            double rendimentoDoMauricio = mauricio.CalculaRendimentoAnual();
            MessageBox.Show("Rendimento anual de mauricio: R$ " + rendimentoDoMauricio);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta contaAmanda = new Conta();
            Cliente clienteAmanda = new Cliente("Amanda", "rg", "Rua Joinville", "111.111.111-11", 25);
            contaAmanda.Titular = clienteAmanda;
            contaAmanda.Numero = 99;
            contaAmanda.Agencia = 999-0;
            contaAmanda.Saldo = 50.0;
            contaAmanda.Titular.nome = "Amanda";

            contaAmanda.Saca(9.0);
            contaAmanda.Deposita(10.0);

            MessageBox.Show("O saldo da conta de " + contaAmanda.Titular.nome + ", é: " + contaAmanda.Saldo);
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("Guilherme Silveira", "rg", "Rua Bahia", "123.456.789-12", 18);

        }

        private void TitularBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta contaVictor = new Conta(1, 11.0, 111-0);
            Cliente clienteVictor = new Cliente("Victor", "rg", "Rua Paraná", "111.111.111-11", 18);
            contaVictor.Titular = clienteVictor;
            textoTitular.Text = contaVictor.Titular.nome;

            guilherme = new Conta();


            textoTitular.Text = Convert.ToString(10);
            string valor = "sp";
            string valorConvertido = Convert.ToString(valor);
            textoTitular.Text = valorConvertido;
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            guilherme
        }
    }
}