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
            Conta ContaCharles = new Conta(1, 5000.0, 111-1);
            Cliente clienteCharles = new Cliente("Charles", "111.111.111", "Rua Aparecida", "111.111.111-11", 17);
            ContaCharles.Titular = clienteCharles;
        
            Conta ContaScott = new Conta(2, 200, 222-2);
            Cliente clienteScott = new Cliente("Scott", "222.222.222", "Rua Itajaí", "222.222.222-22", 18);
            ContaScott.Titular = clienteScott;

            Conta contaJames = new Conta(1, 500.0, 333 - 3);
            Cliente clienteJames = new Cliente("James", "526.259.547.25", "Rua itajaí", "256.321.654-96", 19);
            contaJames.Titular = clienteJames;

            MessageBox.Show("O titular da conta 1 é: " + ContaCharles.Titular.nome + ", CPF: " + ContaCharles.Titular.cpf + ", Agência: " +ContaCharles.agencia + ", Idade: " + ContaCharles.Titular.idade);
            MessageBox.Show("O titular da conta 2 é: " + ContaScott.Titular.nome + ", CPF: " + ContaScott.Titular.cpf + ", Agência: " + ContaScott.agencia + ", Idade: " + ContaScott.Titular.idade);
            MessageBox.Show("O titular da conta 3 é: " + contaJames.Titular.nome + ", CPF: " + contaJames.Titular.cpf + ", Agência: " + contaJames.agencia + ", Idade: " + contaJames.Titular.idade);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.Deposita(800);
            MessageBox.Show(".." + mauricio.Saldo);
            double rendimentoDoMauricio = mauricio.CalculaRendimentoAnual();
            MessageBox.Show("Rendimento anual de mauricio: R$ " + rendimentoDoMauricio);

        }

        private void button6_Click(object sender, EventArgs e)
        {
                Conta contaGuilherme = new Conta();
                contaGuilherme.numero = 1;
                contaGuilherme.Saldo = 1500.0;

                Cliente clienteGuilherme = new Cliente();
                clienteGuilherme.nome = "Guilherme";
                clienteGuilherme.idade = 17;

                contaGuilherme.Titular = clienteGuilherme;

                bool sacou = contaGuilherme.Saca(300.0);
                if (sacou)
                {
                    MessageBox.Show("Saldo da Conta do Guilherme após saque: " + contaGuilherme.Saldo);
                }
                else
                {
                    MessageBox.Show("Não foi possível sacar da conta do Guilherme");
                }
            }
        }
    }
