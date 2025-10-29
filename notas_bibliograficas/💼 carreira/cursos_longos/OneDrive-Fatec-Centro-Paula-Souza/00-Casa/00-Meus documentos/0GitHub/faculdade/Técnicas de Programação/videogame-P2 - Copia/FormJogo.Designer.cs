namespace teste
{
    partial class FormJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            this.lblMensagem = new Guna.UI.WinForms.GunaLabel();
            this.txtPalpite = new Guna.UI.WinForms.GunaTextBox();
            this.btnTentar = new Guna.UI.WinForms.GunaButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Crimson;
            this.lblMensagem.Location = new System.Drawing.Point(34, 132);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(141, 29);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "mensagem";
            // 
            // txtPalpite
            // 
            this.txtPalpite.BaseColor = System.Drawing.Color.White;
            this.txtPalpite.BorderColor = System.Drawing.Color.Silver;
            this.txtPalpite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPalpite.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPalpite.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPalpite.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPalpite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPalpite.Location = new System.Drawing.Point(248, 185);
            this.txtPalpite.Name = "txtPalpite";
            this.txtPalpite.PasswordChar = '\0';
            this.txtPalpite.SelectedText = "";
            this.txtPalpite.Size = new System.Drawing.Size(349, 30);
            this.txtPalpite.TabIndex = 8;
            this.txtPalpite.Text = "Digite um numero";
            this.txtPalpite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTentar
            // 
            this.btnTentar.AnimationHoverSpeed = 0.07F;
            this.btnTentar.AnimationSpeed = 0.03F;
            this.btnTentar.BackColor = System.Drawing.Color.Transparent;
            this.btnTentar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTentar.BorderColor = System.Drawing.Color.Black;
            this.btnTentar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTentar.FocusedColor = System.Drawing.Color.Empty;
            this.btnTentar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTentar.ForeColor = System.Drawing.Color.White;
            this.btnTentar.Image = ((System.Drawing.Image)(resources.GetObject("btnTentar.Image")));
            this.btnTentar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTentar.Location = new System.Drawing.Point(248, 256);
            this.btnTentar.Name = "btnTentar";
            this.btnTentar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTentar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTentar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTentar.OnHoverImage = null;
            this.btnTentar.OnPressedColor = System.Drawing.Color.Black;
            this.btnTentar.Radius = 15;
            this.btnTentar.Size = new System.Drawing.Size(153, 51);
            this.btnTentar.TabIndex = 9;
            this.btnTentar.Text = "Testar";
            this.btnTentar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTentar.Click += new System.EventHandler(this.BtnTentar_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savesToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // savesToolStripMenuItem
            // 
            this.savesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.savesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savesToolStripMenuItem.Name = "savesToolStripMenuItem";
            this.savesToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.savesToolStripMenuItem.Text = "Saves";
            this.savesToolStripMenuItem.Click += new System.EventHandler(this.savesToolStripMenuItem_Click);
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
            this.gunaButton1.Location = new System.Drawing.Point(444, 256);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(153, 51);
            this.gunaButton1.TabIndex = 11;
            this.gunaButton1.Text = "Finalizar";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 410);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btnTentar);
            this.Controls.Add(this.txtPalpite);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormJogo";
            this.Text = "FormJogo";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblMensagem;
        private Guna.UI.WinForms.GunaTextBox txtPalpite;
        private Guna.UI.WinForms.GunaButton btnTentar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savesToolStripMenuItem;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}