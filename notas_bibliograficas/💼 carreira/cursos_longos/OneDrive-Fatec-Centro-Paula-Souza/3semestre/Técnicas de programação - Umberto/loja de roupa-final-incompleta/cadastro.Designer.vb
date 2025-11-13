<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_dtNasc = New System.Windows.Forms.DateTimePicker()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_senhaconfirmar = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cadastrar_cliente = New System.Windows.Forms.Label()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(146, 147)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_nome.TabIndex = 1
        '
        'txt_dtNasc
        '
        Me.txt_dtNasc.Location = New System.Drawing.Point(454, 144)
        Me.txt_dtNasc.Name = "txt_dtNasc"
        Me.txt_dtNasc.Size = New System.Drawing.Size(200, 20)
        Me.txt_dtNasc.TabIndex = 2
        '
        'img_foto
        '
        Me.img_foto.Image = Global.lojaroupa.My.Resources.Resources.nova_foto3
        Me.img_foto.Location = New System.Drawing.Point(454, 208)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(121, 114)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 3
        Me.img_foto.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(146, 324)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(119, 20)
        Me.txt_email.TabIndex = 9
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(146, 381)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(145, 20)
        Me.txt_senha.TabIndex = 11
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'txt_senhaconfirmar
        '
        Me.txt_senhaconfirmar.Location = New System.Drawing.Point(320, 381)
        Me.txt_senhaconfirmar.Name = "txt_senhaconfirmar"
        Me.txt_senhaconfirmar.Size = New System.Drawing.Size(141, 20)
        Me.txt_senhaconfirmar.TabIndex = 13
        Me.txt_senhaconfirmar.UseSystemPasswordChar = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(146, 208)
        Me.txt_cpf.Mask = "999,999,999-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf.TabIndex = 16
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(146, 265)
        Me.txt_fone.Mask = "(00) 00000-0000"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(119, 20)
        Me.txt_fone.TabIndex = 17
        Me.txt_fone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cadastrar_cliente
        '
        Me.btn_cadastrar_cliente.AutoSize = True
        Me.btn_cadastrar_cliente.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar_cliente.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_cliente.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.Location = New System.Drawing.Point(346, 487)
        Me.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente"
        Me.btn_cadastrar_cliente.Size = New System.Drawing.Size(138, 30)
        Me.btn_cadastrar_cliente.TabIndex = 26
        Me.btn_cadastrar_cliente.Text = "CADASTRAR"
        Me.btn_cadastrar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.lojaroupa.My.Resources.Resources.ClienteCadastro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 561)
        Me.Controls.Add(Me.btn_cadastrar_cliente)
        Me.Controls.Add(Me.txt_fone)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_senhaconfirmar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.txt_dtNasc)
        Me.Controls.Add(Me.txt_nome)
        Me.DoubleBuffered = True
        Me.Name = "cadastro"
        Me.Text = "Cadastro de Cliente"
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_dtNasc As DateTimePicker
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_senhaconfirmar As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents btn_cadastrar_cliente As Label
End Class
