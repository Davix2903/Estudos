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
            int numeroDaConta1 = 1;
            string titularDaConta1 = "James Howlett";
            double saldoDaConta1 = 2000.0;

            int numeroDaConta2 = 2;
            string titularDaConta2 = "Charles Xavier";
            double saldoDaConta2 = 5000.0;
        }
    }
}
