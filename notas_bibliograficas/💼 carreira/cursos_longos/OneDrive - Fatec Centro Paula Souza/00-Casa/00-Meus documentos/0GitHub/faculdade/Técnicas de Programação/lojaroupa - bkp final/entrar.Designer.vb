<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entrar
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
        Me.btn_login = New System.Windows.Forms.Label()
        Me.btn_cadastro = New System.Windows.Forms.Label()
        Me.btn_entrar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.AutoSize = True
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(176, 266)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(78, 30)
        Me.btn_login.TabIndex = 1
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cadastro
        '
        Me.btn_cadastro.AutoSize = True
        Me.btn_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastro.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastro.ForeColor = System.Drawing.Color.White
        Me.btn_cadastro.Location = New System.Drawing.Point(149, 315)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(138, 30)
        Me.btn_cadastro.TabIndex = 2
        Me.btn_cadastro.Text = "CADASTRAR"
        Me.btn_cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_entrar
        '
        Me.btn_entrar.AutoSize = True
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Location = New System.Drawing.Point(558, 284)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(96, 30)
        Me.btn_entrar.TabIndex = 3
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'entrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.lojaroupa.My.Resources.Resources.Entrar1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 477)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.btn_login)
        Me.DoubleBuffered = True
        Me.Name = "entrar"
        Me.Text = "Entrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Label
    Friend WithEvents btn_cadastro As Label
    Friend WithEvents btn_entrar As Label
End Class
