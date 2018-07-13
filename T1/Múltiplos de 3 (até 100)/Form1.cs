using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Múltiplos_de_3__até_100_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 100; i = i + 1)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("O número " + i + " é múltíplo de 3");
                }
            }

            }
         
        }
    }

