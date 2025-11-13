using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teste
{
    public partial class cadastrar : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        String SQL;

        public string tentativas { get; set; }

        public cadastrar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //DESKTOP - 1FMU4O1\\SQLEXPRESS; Database = cadastro_3dsm; trusted_connection = yes
                string connectionString = "Data Source=DESKTOP-1FMU4O1\\SQLEXPRESS;Initial Catalog=saves_jogo;Integrated Security=True;";
                conexao = new SqlConnection(@connectionString);
                //MessageBox.Show("Conexão bem sucedida com o banco!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            conexao.Open();
            SQL = "insert into tb_historico (pontuacao,nome) values (@PONT,@NOME)";
            comando = new SqlCommand(SQL, conexao);
            comando.Parameters.AddWithValue("@PONT", this.tentativas);
            comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
            comando.ExecuteNonQuery();
            
            conexao.Close();
            MessageBox.Show("Cadastrado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home tela = new home();
            tela.Show();
            this.Close();

        }

        private void VisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saves tela = new saves();
            tela.Show();
            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
