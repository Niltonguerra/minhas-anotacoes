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

namespace prj_crud_cs_3dsm_1S23
{
    public partial class Form1 : Form
    {

        SqlConnection conexao;
        SqlCommand comando;
        String SQL;
        public Form1()
        {
            InitializeComponent();

        }

        private void Btn_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                SQL = "insert into tb_cadastro values (@CPF,@NOME,@FONE,@EMAIL)";
                comando = new SqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@CPF", txt_cpf.Text);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.Parameters.AddWithValue("@FONE", txt_fone.Text);
                comando.Parameters.AddWithValue("@EMAIL", txt_email.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SQL = "select * from tb_cadastro order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
                txt_cpf.Clear();
                txt_nome.Clear();
                txt_fone.Clear();
                txt_email.Clear();
                txt_cpf.Focus();
                
            }

            catch
            {
                MessageBox.Show("Erro ao gravar!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexao.Close();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=LAB5-PROF;Database=cadastro_3dsm;trusted_connection=yes");
                MessageBox.Show("Conexão bem sucedida com o banco!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SQL = "select * from tb_cadastro order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
                

            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            try
          {
                conexao.Open();
                SQL = "select * from tb_cadastro where cpf = '" + txt_cpf.Text + "'";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                txt_nome.Text = tabela.Tables[0].Rows[0]["nome"].ToString();
                txt_fone.Text = tabela.Tables[0].Rows[0]["fone"].ToString();
                txt_email.Text = tabela.Tables[0].Rows[0]["email"].ToString();
               
            }

            catch
            {
               MessageBox.Show("CPF não localizado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexao.Close();
            }
        }

        private void Txt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void Txt_busca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SQL = "select * from tb_cadastro where nome like '" + txt_busca.Text + "%'";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
            }
            finally
            {
                conexao.Close();
            }
            
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
           try
            {
                conexao.Open();
                SQL = "update tb_cadastro set nome=@NOME,fone=@FONE,email=@EMAIL where cpf=@CPF";
                comando = new SqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txt_nome.Text);
                comando.Parameters.AddWithValue("@FONE", txt_fone.Text);
                comando.Parameters.AddWithValue("@EMAIL", txt_email.Text);
                comando.CommandType = CommandType.Text;
                MessageBox.Show("Dados alterados com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SQL = "select * from tb_cadastro order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
                txt_cpf.Clear();
                txt_nome.Clear();
                txt_fone.Clear();
                txt_email.Clear();
                txt_cpf.Focus();

            }

           catch
            {
              MessageBox.Show("Erro ao alterar dados!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            finally
            {
               conexao.Close();
            }
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                SQL = "delete from tb_cadastro where cpf=@cpf";
                comando = new SqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@CPF", txt_cpf.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SQL = "select * from tb_cadastro order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
                txt_cpf.Clear();
                txt_nome.Clear();
                txt_fone.Clear();
                txt_email.Clear();
                txt_cpf.Focus();

            }

            catch
            {
                MessageBox.Show("Erro ao excluir!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            finally
            {
                conexao.Close();
            }
        }
    }
}
