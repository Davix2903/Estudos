using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Média_das_Idades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Wanessa = 22;
            int Wagner = 18;
            int Lucas = 14;

            double MedindoIdades = (Wagner + Wanessa + Lucas) / 3;

            MessageBox.Show("A média das idades é: " + MedindoIdades);
        }
    }
}
