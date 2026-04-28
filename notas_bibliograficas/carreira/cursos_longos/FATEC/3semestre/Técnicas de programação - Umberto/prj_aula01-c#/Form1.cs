using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_aula01
{
    public partial class Form1 : Form
    {
        //declaração de variaveis
        decimal n1, n2, n3, media;
        string situacao;
        int numero;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nota1.Clear();
            txt_nota2.Clear();
            txt_nota3.Clear();
            lbl_media.Text = "";
            lbl_situacao.Text = "";
            txt_nota1.Focus();
        }

        private void Txt_nota1_TextChanged(object sender, EventArgs e)
        {

        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                numero = int.Parse(txt_nota1.Text);
                n1 = Convert.ToDecimal(txt_nota1.Text);
                n2 = Convert.ToDecimal(txt_nota2.Text);
                n3 = Convert.ToDecimal(txt_nota3.Text);
                media = (n1 + n2 + n3) / 3;
                if (media < 4)
                {
                    situacao = "reprovado";

                }
                else if(media >= 4 && media <6){
                    situacao = "recuperação";
                }
                else
                {
                    situacao = "aprovado";
                }
                //C transforma o resultado em formato monetario, reais(R$)
                //F limita a 2 caixas decimais
                lbl_media.Text = media.ToString("F");
                lbl_situacao.Text = situacao.ToString();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos, por favor","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
