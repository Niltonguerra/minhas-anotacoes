namespace teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_nome = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.txt_dt_nasc = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_cargo = new Guna.UI.WinForms.GunaTextBox();
            this.txt_altura = new Guna.UI.WinForms.GunaTextBox();
            this.txt_end = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_home = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.txt_nome.Location = new System.Drawing.Point(74, 83);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.SelectedText = "";
            this.txt_nome.Size = new System.Drawing.Size(223, 30);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Text = "coloque seu nome";
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
            this.gunaButton1.Location = new System.Drawing.Point(301, 328);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(153, 51);
            this.gunaButton1.TabIndex = 2;
            this.gunaButton1.Text = "Concluir";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // txt_dt_nasc
            // 
            this.txt_dt_nasc.BaseColor = System.Drawing.Color.White;
            this.txt_dt_nasc.BorderColor = System.Drawing.Color.Silver;
            this.txt_dt_nasc.CustomFormat = null;
            this.txt_dt_nasc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_dt_nasc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dt_nasc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dt_nasc.ForeColor = System.Drawing.Color.Black;
            this.txt_dt_nasc.Location = new System.Drawing.Point(423, 141);
            this.txt_dt_nasc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_dt_nasc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_dt_nasc.Name = "txt_dt_nasc";
            this.txt_dt_nasc.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_dt_nasc.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dt_nasc.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dt_nasc.OnPressedColor = System.Drawing.Color.Black;
            this.txt_dt_nasc.Size = new System.Drawing.Size(223, 30);
            this.txt_dt_nasc.TabIndex = 3;
            this.txt_dt_nasc.Text = "terça-feira, 23 de maio de 2023";
            this.txt_dt_nasc.Value = new System.DateTime(2023, 5, 23, 19, 57, 45, 828);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Crimson;
            this.gunaLabel1.Location = new System.Drawing.Point(69, 40);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(90, 29);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Nome:";
            // 
            // txt_cargo
            // 
            this.txt_cargo.BaseColor = System.Drawing.Color.White;
            this.txt_cargo.BorderColor = System.Drawing.Color.Silver;
            this.txt_cargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cargo.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cargo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cargo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cargo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cargo.Location = new System.Drawing.Point(74, 174);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.PasswordChar = '\0';
            this.txt_cargo.SelectedText = "";
            this.txt_cargo.Size = new System.Drawing.Size(223, 30);
            this.txt_cargo.TabIndex = 5;
            this.txt_cargo.Text = "coloque seu cargo";
            this.txt_cargo.TextChanged += new System.EventHandler(this.GunaTextBox2_TextChanged);
            // 
            // txt_altura
            // 
            this.txt_altura.BaseColor = System.Drawing.Color.White;
            this.txt_altura.BorderColor = System.Drawing.Color.Silver;
            this.txt_altura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_altura.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_altura.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_altura.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_altura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_altura.Location = new System.Drawing.Point(74, 268);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.PasswordChar = '\0';
            this.txt_altura.SelectedText = "";
            this.txt_altura.Size = new System.Drawing.Size(223, 30);
            this.txt_altura.TabIndex = 7;
            this.txt_altura.Text = "coloque sua altura";
            // 
            // txt_end
            // 
            this.txt_end.BaseColor = System.Drawing.Color.White;
            this.txt_end.BorderColor = System.Drawing.Color.Silver;
            this.txt_end.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_end.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_end.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_end.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_end.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_end.Location = new System.Drawing.Point(423, 245);
            this.txt_end.Name = "txt_end";
            this.txt_end.PasswordChar = '\0';
            this.txt_end.SelectedText = "";
            this.txt_end.Size = new System.Drawing.Size(223, 30);
            this.txt_end.TabIndex = 9;
            this.txt_end.Text = "coloque seu endereço";
            this.txt_end.TextChanged += new System.EventHandler(this.GunaTextBox4_TextChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Crimson;
            this.gunaLabel6.Location = new System.Drawing.Point(69, 132);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(127, 29);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "Emprego:";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Crimson;
            this.gunaLabel7.Location = new System.Drawing.Point(69, 225);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(87, 29);
            this.gunaLabel7.TabIndex = 13;
            this.gunaLabel7.Text = "Altura:";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Crimson;
            this.gunaLabel8.Location = new System.Drawing.Point(418, 202);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(133, 29);
            this.gunaLabel8.TabIndex = 14;
            this.gunaLabel8.Text = "Endereço:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Crimson;
            this.gunaLabel2.Location = new System.Drawing.Point(418, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(250, 29);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Data de nascimento:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_home,
            this.visualizarToolStripMenuItem});
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clienteToolStripMenuItem.Text = "menu";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(180, 22);
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.CadastrarToolStripMenuItem_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualizarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarToolStripMenuItem.Text = "Saves";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.VisualizarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(777, 399);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_dt_nasc);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "cadastrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txt_nome;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaDateTimePicker txt_dt_nasc;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_cargo;
        private Guna.UI.WinForms.GunaTextBox txt_altura;
        private Guna.UI.WinForms.GunaTextBox txt_end;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_home;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
    }
}

