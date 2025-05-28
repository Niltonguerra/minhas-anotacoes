namespace teste
{
    partial class cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_nome = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Crimson;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(240, 29);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Qual é o seu nome:";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.BaseColor = System.Drawing.Color.White;
            this.txt_nome.BorderColor = System.Drawing.Color.Silver;
            this.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nome.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_nome.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_nome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nome.Location = new System.Drawing.Point(21, 54);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(298, 30);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Text = "Seu nome";
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(98, 90);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(116, 29);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Concluir";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(331, 139);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.txt_nome);
            this.Name = "cadastrar";
            this.Text = "cadastrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_nome;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}

