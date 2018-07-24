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
using Benner.CaixaEletronico;

namespace CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string titular = titularConta.Text;
            int numero = Convert.ToInt32(numeroConta.Text);

            Conta contas = new ContaCorrente()
            {
                Numero = numero, Titular = new Cliente(titular)
            };
            this.aplicacaoPrincipal.AdicionaConta(contas);
            this.Close();
        }
    }
}
