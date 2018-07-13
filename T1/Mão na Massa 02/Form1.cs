using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mão_na_Massa_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; 1 <= 100; i = i + 1)
            {
            if (i % 3 != 0)
                {
                soma += 1;
                }
            MessageBox.Show("Resultado da soma: " + soma);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }
            }
            MessageBox.Show("O total é: " + soma);
        }
    }
}
