using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_Cdsm
{
    public partial class Form1 : Form
    {

        SqlConnection conexao;
        SqlCommand comando;
        String sql_query;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //@ faz com que iguinore a barra invertida na string de conecção
                conexao = new SqlConnection(@"server=LAB5-01;Database=cadastro_clientes;trusted_connection=yes");
                MessageBox.Show("Conexão bem sucedida", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao conectar", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                sql_query = "insert into tb_clientes (cpf,nome) values (@cpf,@nome)";
                comando = new SqlCommand(sql_query, conexao);
                comando.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                comando.Parameters.AddWithValue("@nome", txt_nome.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("registro gravado com sucesso!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();

                txt_cpf.Clear();
                txt_nome.Clear();
                txt_cpf.Focus();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
