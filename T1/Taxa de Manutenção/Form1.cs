using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxa_de_Manutenção
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int saldo = 3000;
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

                MessageBox.Show("A taxa da sua conta é de: " + taxa);
            }
        }
    }
}
