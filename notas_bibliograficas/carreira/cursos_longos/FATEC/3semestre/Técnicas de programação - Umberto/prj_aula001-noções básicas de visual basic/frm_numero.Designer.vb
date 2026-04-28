<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_numero
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
        Me.lbl_maiorNumero = New System.Windows.Forms.Label()
        Me.txt_numero3 = New System.Windows.Forms.TextBox()
        Me.txt_numero2 = New System.Windows.Forms.TextBox()
        Me.txt_numero1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_maiorNumero
        '
        Me.lbl_maiorNumero.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl_maiorNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_maiorNumero.Location = New System.Drawing.Point(209, 213)
        Me.lbl_maiorNumero.Name = "lbl_maiorNumero"
        Me.lbl_maiorNumero.Size = New System.Drawing.Size(100, 23)
        Me.lbl_maiorNumero.TabIndex = 9
        Me.lbl_maiorNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_numero3
        '
        Me.txt_numero3.Location = New System.Drawing.Point(209, 149)
        Me.txt_numero3.Name = "txt_numero3"
        Me.txt_numero3.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero3.TabIndex = 10
        '
        'txt_numero2
        '
        Me.txt_numero2.Location = New System.Drawing.Point(209, 97)
        Me.txt_numero2.Name = "txt_numero2"
        Me.txt_numero2.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero2.TabIndex = 11
        '
        'txt_numero1
        '
        Me.txt_numero1.Location = New System.Drawing.Point(209, 47)
        Me.txt_numero1.Name = "txt_numero1"
        Me.txt_numero1.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Digite o numero1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Digite o numero2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Digite o numero 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Maior número"
        '
        'btn_verificar
        '
        Me.btn_verificar.Location = New System.Drawing.Point(412, 99)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_verificar.TabIndex = 17
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(412, 180)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpar.TabIndex = 18
        Me.btn_limpar.Text = "limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'frm_numero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_numero1)
        Me.Controls.Add(Me.txt_numero2)
        Me.Controls.Add(Me.txt_numero3)
        Me.Controls.Add(Me.lbl_maiorNumero)
        Me.Name = "frm_numero"
        Me.Text = "frm_numero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_maiorNumero As Label
    Friend WithEvents txt_numero3 As TextBox
    Friend WithEvents txt_numero2 As TextBox
    Friend WithEvents txt_numero1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_verificar As Button
    Friend WithEvents btn_limpar As Button
End Class
