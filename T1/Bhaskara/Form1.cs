using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int avalor = 2;
            int bvalor = 5;
            int cvalor = 1;

            double delta;
            double a1;
            double a2;


            delta = bvalor * bvalor - 4 * avalor * cvalor;
            a1 = (-bvalor + Math.Sqrt(delta)) / (2 * avalor);
            a2 = (-bvalor - Math.Sqrt(delta)) / (2 * avalor);

            MessageBox.Show("Resultado 1: " + a1);
            MessageBox.Show("Resultado 2: " + a2);
        }
    }
}
