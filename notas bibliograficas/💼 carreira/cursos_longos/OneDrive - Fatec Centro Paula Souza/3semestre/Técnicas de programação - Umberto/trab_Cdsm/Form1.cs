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

namespace trab_Cdsm
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

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //@ faz com que iguinore a barra invertida na string de conecção
                conexao = new SqlConnection(@"server=LAB5-01;Database=pedido_comida;trusted_connection=yes");
                MessageBox.Show("Conexão bem sucedida", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao conectar", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_comprar_Click(object sender, EventArgs e)
        {
            try
            {
                sql_query = "insert into tb_pedido (nome,telefone,comida,bebida,endereco,modo_pagamendo) values (@nome,@telefone,@comida,@bebida,@endereco,@modo_pagamento)";
                comando = new SqlCommand(sql_query, conexao);
                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@telefone", txt_tel.Text);
                comando.Parameters.AddWithValue("@comida", txt_ped.Text);
                comando.Parameters.AddWithValue("@bebida", txt_beb.Text);
                comando.Parameters.AddWithValue("@endereco", txt_end.Text);
                comando.Parameters.AddWithValue("@modo_pagamento", txt_pag.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("registro gravado com sucesso!", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();

                
                txt_nome.Clear();
                txt_tel.Clear();
                txt_ped.Clear();
                txt_beb.Clear();
                txt_end.Clear();
                txt_pag.Clear();
                txt_nome.Focus();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
