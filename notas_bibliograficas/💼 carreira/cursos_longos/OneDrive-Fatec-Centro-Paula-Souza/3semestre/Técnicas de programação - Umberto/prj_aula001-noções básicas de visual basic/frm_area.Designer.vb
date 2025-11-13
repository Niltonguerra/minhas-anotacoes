<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_area
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_lado = New System.Windows.Forms.TextBox()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.lbl_perimetro = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "um dos lados do quadrado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "perimetro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Área"
        '
        'txt_lado
        '
        Me.txt_lado.Location = New System.Drawing.Point(183, 34)
        Me.txt_lado.Name = "txt_lado"
        Me.txt_lado.Size = New System.Drawing.Size(100, 20)
        Me.txt_lado.TabIndex = 3
        Me.txt_lado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_area
        '
        Me.lbl_area.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl_area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_area.Location = New System.Drawing.Point(48, 156)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(100, 23)
        Me.lbl_area.TabIndex = 6
        Me.lbl_area.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_perimetro
        '
        Me.lbl_perimetro.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl_perimetro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_perimetro.Location = New System.Drawing.Point(227, 156)
        Me.lbl_perimetro.Name = "lbl_perimetro"
        Me.lbl_perimetro.Size = New System.Drawing.Size(100, 23)
        Me.lbl_perimetro.TabIndex = 7
        Me.lbl_perimetro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(102, 84)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular.TabIndex = 8
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpar
        '
        Me.btn_limpar.Location = New System.Drawing.Point(208, 84)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpar.TabIndex = 9
        Me.btn_limpar.Text = "Limpar"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'frm_area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.lbl_perimetro)
        Me.Controls.Add(Me.lbl_area)
        Me.Controls.Add(Me.txt_lado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ÁREA QUADRADA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_lado As TextBox
    Friend WithEvents lbl_area As Label
    Friend WithEvents lbl_perimetro As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpar As Button
End Class
