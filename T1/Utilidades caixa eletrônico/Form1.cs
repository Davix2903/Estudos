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

            Conta ContaScott = new Conta();
            ContaScott.numero = 2;
            ContaScott.titular = "Scott Summers";
            ContaScott.saldo = 2000.0;
        }
    }
}
