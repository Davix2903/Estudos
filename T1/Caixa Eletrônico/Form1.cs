using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletrônico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valor = 1000.0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
private void button1_Click_2(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_3(object sender, EventArgs e)
        {}

        private void button1_Click_4(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valor = 10.0;
            bool PodeSacar = (valor <= saldo) && (valor >= 0);
            if (PodeSacar)
            {
                saldo = saldo - valor;
                MessageBox.Show("Saque realizado com sucesso!");
                MessageBox.Show("Saldo atual: " + saldo);

            }
            else
            {

                MessageBox.Show("Saldo insufisciente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorDoSaque = 10.0;
            double valorAposSaque = saldo - valorDoSaque;

            MessageBox.Show("O saldo da conta após o saque é: " + valorAposSaque);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double saldo = 0;
            double taxa;

            if (saldo < 1000)
            {
                taxa = 0.01;
            }
            else if (saldo <= 5000)
            {
                taxa = 0.05;
            }
            else
            {
                taxa = 0.1;
            }
            MessageBox.Show("A taxa da sua conta é de: " + taxa);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ValorInvestido = 200000.0;
            for (int i = 1; i <= 12; i++) ;
                {
                ValorInvestido *= 1.01;
                }
            MessageBox.Show("O valor investido é: " + ValorInvestido);
        }   
        
    }
       
    }

