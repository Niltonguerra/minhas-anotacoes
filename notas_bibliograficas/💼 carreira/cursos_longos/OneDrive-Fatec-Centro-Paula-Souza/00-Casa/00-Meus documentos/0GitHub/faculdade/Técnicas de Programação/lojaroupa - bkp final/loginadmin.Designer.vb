<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginadmin
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
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.BackColor = System.Drawing.Color.Transparent
        Me.lbl_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_login.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.ForeColor = System.Drawing.Color.White
        Me.lbl_login.Location = New System.Drawing.Point(185, 353)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(78, 30)
        Me.lbl_login.TabIndex = 0
        Me.lbl_login.Text = "LOGIN"
        Me.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(90, 212)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(163, 20)
        Me.txt_user.TabIndex = 2
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(90, 274)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(163, 20)
        Me.txt_senha.TabIndex = 3
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'loginadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.lojaroupa.My.Resources.Resources.Entrar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 477)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_login)
        Me.DoubleBuffered = True
        Me.Name = "loginadmin"
        Me.Text = "Administrador Entrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_login As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_senha As TextBox
End Class
