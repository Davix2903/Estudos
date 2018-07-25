using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
                if (File.Exists("texto.txt"))
                {
                    using (TextReader leitor = Console.In)
                    {
                        string conteudo = leitor.ReadToEnd();
                        texto.Text = conteudo;
                    }
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Stream saidaDeTexto = File.OpenWrite("texto.txt"))
            using (StreamWriter escritor = new StreamWriter(saidaDeTexto))
            {
                escritor.Write(texto.Text);
            }
        }
    }
}
