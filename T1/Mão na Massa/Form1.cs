using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mão_na_Massa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 1; i <= 30; i = i + 1)
            {
                if (i % 3 == 0)
                    MessageBox.Show("O número " + i + " é dívisvel por 3");
                if (i % 4 == 0)
                {
                    MessageBox.Show("O número " + i + " é divisível por 4");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i = i + 1)
            {
                int NúmeroUm = 3;
                int NúmeroDois = 4;
                if (i % NúmeroUm != 0 && i % NúmeroDois != 0);
                if (i % NúmeroUm == 0)
                {
                    MessageBox.Show("O número " + i + " é divisível por: " + NúmeroUm);
                }
                if (i % NúmeroDois == 0)
                {
                    MessageBox.Show("O numero " + i + " é divisível por: " + NúmeroDois);
                }

                

                

                
            }
        }
    }
}