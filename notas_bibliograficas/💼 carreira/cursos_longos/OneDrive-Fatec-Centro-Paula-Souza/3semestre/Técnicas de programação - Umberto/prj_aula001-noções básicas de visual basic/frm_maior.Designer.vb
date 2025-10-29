<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_maior
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_redefinir = New System.Windows.Forms.Button()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_antecessor = New System.Windows.Forms.Label()
        Me.lbl_sucessor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(92, 125)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "ok"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_redefinir
        '
        Me.btn_redefinir.Location = New System.Drawing.Point(188, 125)
        Me.btn_redefinir.Name = "btn_redefinir"
        Me.btn_redefinir.Size = New System.Drawing.Size(75, 23)
        Me.btn_redefinir.TabIndex = 1
        Me.btn_redefinir.Text = "redefinir"
        Me.btn_redefinir.UseVisualStyleBackColor = True
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(209, 45)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Digite o numero inteiro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Número antecessor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Número sucessor"
        '
        'lbl_antecessor
        '
        Me.lbl_antecessor.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl_antecessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_antecessor.Location = New System.Drawing.Point(35, 257)
        Me.lbl_antecessor.Name = "lbl_antecessor"
        Me.lbl_antecessor.Size = New System.Drawing.Size(100, 23)
        Me.lbl_antecessor.TabIndex = 8
        Me.lbl_antecessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_sucessor
        '
        Me.lbl_sucessor.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl_sucessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sucessor.Location = New System.Drawing.Point(188, 257)
        Me.lbl_sucessor.Name = "lbl_sucessor"
        Me.lbl_sucessor.Size = New System.Drawing.Size(100, 23)
        Me.lbl_sucessor.TabIndex = 9
        Me.lbl_sucessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_maior
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 479)
        Me.Controls.Add(Me.lbl_sucessor)
        Me.Controls.Add(Me.lbl_antecessor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.btn_redefinir)
        Me.Controls.Add(Me.btn_ok)
        Me.Name = "frm_maior"
        Me.Text = "frm_maior"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_redefinir As Button
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_antecessor As Label
    Friend WithEvents lbl_sucessor As Label
End Class
