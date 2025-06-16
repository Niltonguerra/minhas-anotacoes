<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logincliente
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
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.btn_logincliente = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(461, 267)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(163, 20)
        Me.txt_senha.TabIndex = 6
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(461, 205)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(163, 20)
        Me.txt_user.TabIndex = 5
        '
        'btn_logincliente
        '
        Me.btn_logincliente.AutoSize = True
        Me.btn_logincliente.BackColor = System.Drawing.Color.Transparent
        Me.btn_logincliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logincliente.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logincliente.ForeColor = System.Drawing.Color.White
        Me.btn_logincliente.Location = New System.Drawing.Point(555, 352)
        Me.btn_logincliente.Name = "btn_logincliente"
        Me.btn_logincliente.Size = New System.Drawing.Size(78, 30)
        Me.btn_logincliente.TabIndex = 4
        Me.btn_logincliente.Text = "LOGIN"
        Me.btn_logincliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logincliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.lojaroupa.My.Resources.Resources.ClienteLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 477)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.btn_logincliente)
        Me.DoubleBuffered = True
        Me.Name = "logincliente"
        Me.Text = "logincliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents btn_logincliente As Label
End Class
