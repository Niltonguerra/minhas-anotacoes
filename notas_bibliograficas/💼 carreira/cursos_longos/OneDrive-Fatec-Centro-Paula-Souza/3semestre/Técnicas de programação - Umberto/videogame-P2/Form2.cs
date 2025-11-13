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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void VisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
