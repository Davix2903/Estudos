﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma_dos_números_de_1_a_1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma1000 = 0;
            for (int i = 0; i <= 1000; i++)
            {
                soma1000 += i;
            }
            MessageBox.Show("Resultado: " + soma1000);
        }
    }
}
