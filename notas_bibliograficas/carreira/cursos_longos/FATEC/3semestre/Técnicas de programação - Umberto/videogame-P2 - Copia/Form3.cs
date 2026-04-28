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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.Show();
        }
    }
}
