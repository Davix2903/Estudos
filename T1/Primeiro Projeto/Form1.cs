﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tudo bem com você?");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso de C# do Alura");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meu primeiro programa C#");
        }
    }
}
