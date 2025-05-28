namespace trab_Cdsm
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ped = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_beb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(52, 61);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(272, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(373, 61);
            this.txt_tel.Mask = "(99)99999-9999";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 2;
            this.txt_tel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // txt_ped
            // 
            this.txt_ped.Location = new System.Drawing.Point(52, 144);
            this.txt_ped.Name = "txt_ped";
            this.txt_ped.Size = new System.Drawing.Size(421, 20);
            this.txt_ped.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pedido";
            // 
            // txt_beb
            // 
            this.txt_beb.Location = new System.Drawing.Point(52, 222);
            this.txt_beb.Name = "txt_beb";
            this.txt_beb.Size = new System.Drawing.Size(421, 20);
            this.txt_beb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bebida";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(52, 290);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(421, 20);
            this.txt_end.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço";
            // 
            // txt_pag
            // 
            this.txt_pag.Location = new System.Drawing.Point(52, 361);
            this.txt_pag.Name = "txt_pag";
            this.txt_pag.Size = new System.Drawing.Size(421, 20);
            this.txt_pag.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Modo de pagamento";
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(52, 415);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(421, 53);
            this.btn_comprar.TabIndex = 12;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.Btn_comprar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 508);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.txt_pag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_beb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ped);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_beb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_comprar;
    }
}

