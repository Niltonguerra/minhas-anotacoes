namespace prj_aula01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
            this.lbl_situacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1:";
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(148, 94);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(100, 20);
            this.txt_nota1.TabIndex = 1;
            this.txt_nota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nota1.TextChanged += new System.EventHandler(this.Txt_nota1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2:";
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(148, 141);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(100, 20);
            this.txt_nota2.TabIndex = 3;
            this.txt_nota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(148, 178);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(100, 20);
            this.txt_nota3.TabIndex = 5;
            this.txt_nota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 3:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(321, 171);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(321, 114);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 7;
            this.btn_calcular.Text = "calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Média do aluno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "situação aluno";
            // 
            // lbl_media
            // 
            this.lbl_media.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_media.Location = new System.Drawing.Point(465, 124);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(80, 13);
            this.lbl_media.TabIndex = 10;
            this.lbl_media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_situacao
            // 
            this.lbl_situacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_situacao.Location = new System.Drawing.Point(469, 181);
            this.lbl_situacao.Name = "lbl_situacao";
            this.lbl_situacao.Size = new System.Drawing.Size(80, 13);
            this.lbl_situacao.TabIndex = 11;
            this.lbl_situacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 500);
            this.Controls.Add(this.lbl_situacao);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_nota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendimento do aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Label lbl_situacao;
    }
}

