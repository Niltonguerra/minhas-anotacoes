using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
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

        private void GunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void GunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void GunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.Show();
        }

        private void VisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }
    }
}
