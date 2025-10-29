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
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_Cadastrar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Location = New System.Drawing.Point(225, 118)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(33, 13)
        Me.lbl_login.TabIndex = 0
        Me.lbl_login.Text = "Login"
        '
        'lbl_Cadastrar
        '
        Me.lbl_Cadastrar.AutoSize = True
        Me.lbl_Cadastrar.Location = New System.Drawing.Point(225, 159)
        Me.lbl_Cadastrar.Name = "lbl_Cadastrar"
        Me.lbl_Cadastrar.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Cadastrar.TabIndex = 1
        Me.lbl_Cadastrar.Text = "Cadastro"
        '
        'entrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_Cadastrar)
        Me.Controls.Add(Me.lbl_login)
        Me.Name = "entrar"
        Me.Text = "entrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_Cadastrar As Label
End Class
