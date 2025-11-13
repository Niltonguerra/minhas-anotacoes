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
    public partial class saves : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        String SQL;
        public saves()
        {
            InitializeComponent();
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar tela = new cadastrar();
            tela.Show();
            this.Close();

        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home tela = new home();
            tela.Show();
            this.Close();

        }

        private void dgv_dados_prod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{

            if (dgv_dados.Columns[e.ColumnIndex] == dgv_dados.Columns["col_excluir"])
                {

                //excluir

                //teste de estração de id
                //MessageBox.Show(texto1, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);



                // Obtém o ID (ou outra chave primária) do registro selecionado

                conexao.Open();
                int extraiId = Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells["id"].Value.ToString());
                string stringId = extraiId.ToString();

                SQL = "delete from tb_historico where id=@cpf";
                comando = new SqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@cpf", stringId);

                //executa o código
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //atualiza a tabela no C#
                SQL = "select * from tb_historico order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);

                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();

                //dgv_dados.Rows.Remove(row);
                conexao.Close();





            }
            else if (dgv_dados.Columns[e.ColumnIndex] == dgv_dados.Columns["col_editar"])
            {
                //editar
                
                conexao.Open();
                SQL = "update tb_historico set nome=@NOME,pontuacao=@PONT where id=@cpf";
                comando = new SqlCommand(SQL, conexao);


                //extrai o id
                int extraiId = Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells["id"].Value.ToString());
                string stringId = extraiId.ToString();
                comando.Parameters.AddWithValue("@cpf", stringId);

                //extrai o nome
                string extraiNome = dgv_dados.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                string stringNome = extraiNome.ToString();

                comando.Parameters.AddWithValue("@NOME", stringNome);

                //extrai a pontuação
                string extraiPont = dgv_dados.Rows[e.RowIndex].Cells["pontuacao"].Value.ToString();
                string stringPont = extraiPont.ToString();
                comando.Parameters.AddWithValue("@PONT", stringPont);


                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();

                //mensagem para o usuário
                MessageBox.Show("Dados alterados com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);



                //atualiza a planilha no visual basic
                SQL = "select * from tb_historico order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(SQL, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();

                conexao.Close();


            }












            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Erro ao processar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }



        private void saves_Load(object sender, EventArgs e)
        {
            try
            {
                //DESKTOP - 1FMU4O1\\SQLEXPRESS; Database = cadastro_3dsm; trusted_connection = yes
            string connectionString = "Data Source=DESKTOP-1FMU4O1\\SQLEXPRESS;Initial Catalog=saves_jogo;Integrated Security=True;";
                conexao = new SqlConnection(@connectionString);
                //MessageBox.Show("Conexão bem sucedida com o banco!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SQL = "select * from tb_historico order by nome asc";
                
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
    }
}
