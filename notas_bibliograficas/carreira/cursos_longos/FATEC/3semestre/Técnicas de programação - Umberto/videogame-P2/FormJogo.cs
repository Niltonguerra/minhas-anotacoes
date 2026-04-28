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
    public partial class FormJogo : Form
    {
        private int numeroAleatorio;
        private int tentativas;


        public FormJogo()
        {
            InitializeComponent();
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            Random random = new Random();
            numeroAleatorio = random.Next(1, 101);
            tentativas = 0;

            lblMensagem.Text = "Estou pensando em um número entre 1 e 100.";
        }


        private void btnTentar_Click(object sender, EventArgs e)
        {

        }

        private void FormJogo_Load(object sender, EventArgs e)
        {

        }

        private void BtnTentar_Click_1(object sender, EventArgs e)
        {
            int palpite = Convert.ToInt32(txtPalpite.Text);
            tentativas++;

            if (palpite == numeroAleatorio)
            {
                lblMensagem.Text = "Parabéns, você acertou o número em " + tentativas + " tentativas!";
                btnTentar.Enabled = false;
            }
            else if (palpite < numeroAleatorio)
            {
                lblMensagem.Text = "O número que estou pensando é maior que " + palpite + ". Tente novamente!";
            }
            else
            {
                lblMensagem.Text = "O número que estou pensando é menor que " + palpite + ". Tente novamente!";
            }

            txtPalpite.Clear();
            txtPalpite.Focus();
        }

        private void savesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.Show();
        }
    }
}
