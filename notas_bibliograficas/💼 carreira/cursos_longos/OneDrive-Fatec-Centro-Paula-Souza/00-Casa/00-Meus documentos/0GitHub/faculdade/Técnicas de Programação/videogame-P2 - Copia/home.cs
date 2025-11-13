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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void VisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saves tela = new saves();
            tela.Show();
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar tela = new cadastrar();
            tela.Show();
        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {
            FormJogo tela = new FormJogo();
            tela.Show();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
