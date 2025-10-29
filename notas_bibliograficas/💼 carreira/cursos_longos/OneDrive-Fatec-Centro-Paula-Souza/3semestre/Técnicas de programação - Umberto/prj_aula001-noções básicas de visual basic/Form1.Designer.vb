<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualBasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BásicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AréaDoQuadradoEPerimetroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NúmerosAntecessoresESucessoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaiorNúmeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvançadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramasToolStripMenuItem, Me.FerramentasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1438, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualBasicToolStripMenuItem})
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ProgramasToolStripMenuItem.Text = "Programas"
        '
        'VisualBasicToolStripMenuItem
        '
        Me.VisualBasicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BásicosToolStripMenuItem, Me.IntermediarioToolStripMenuItem, Me.AvançadoToolStripMenuItem})
        Me.VisualBasicToolStripMenuItem.Name = "VisualBasicToolStripMenuItem"
        Me.VisualBasicToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VisualBasicToolStripMenuItem.Text = "Visual Basic"
        '
        'BásicosToolStripMenuItem
        '
        Me.BásicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AréaDoQuadradoEPerimetroToolStripMenuItem, Me.NúmerosAntecessoresESucessoresToolStripMenuItem, Me.MaiorNúmeroToolStripMenuItem})
        Me.BásicosToolStripMenuItem.Name = "BásicosToolStripMenuItem"
        Me.BásicosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BásicosToolStripMenuItem.Text = "Básicos"
        '
        'AréaDoQuadradoEPerimetroToolStripMenuItem
        '
        Me.AréaDoQuadradoEPerimetroToolStripMenuItem.Name = "AréaDoQuadradoEPerimetroToolStripMenuItem"
        Me.AréaDoQuadradoEPerimetroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AréaDoQuadradoEPerimetroToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.AréaDoQuadradoEPerimetroToolStripMenuItem.Text = "Aréa do quadrado e perimetro"
        '
        'NúmerosAntecessoresESucessoresToolStripMenuItem
        '
        Me.NúmerosAntecessoresESucessoresToolStripMenuItem.Name = "NúmerosAntecessoresESucessoresToolStripMenuItem"
        Me.NúmerosAntecessoresESucessoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.NúmerosAntecessoresESucessoresToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.NúmerosAntecessoresESucessoresToolStripMenuItem.Text = "Números Antecessores e sucessores"
        '
        'MaiorNúmeroToolStripMenuItem
        '
        Me.MaiorNúmeroToolStripMenuItem.Name = "MaiorNúmeroToolStripMenuItem"
        Me.MaiorNúmeroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MaiorNúmeroToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.MaiorNúmeroToolStripMenuItem.Text = "Maior número"
        '
        'IntermediarioToolStripMenuItem
        '
        Me.IntermediarioToolStripMenuItem.Name = "IntermediarioToolStripMenuItem"
        Me.IntermediarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IntermediarioToolStripMenuItem.Text = "Intermediario"
        '
        'AvançadoToolStripMenuItem
        '
        Me.AvançadoToolStripMenuItem.Name = "AvançadoToolStripMenuItem"
        Me.AvançadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AvançadoToolStripMenuItem.Text = "Avançado"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.CalculadoraToolStripMenuItem})
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.FerramentasToolStripMenuItem.Text = "Ferramentas"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 562)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerramentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualBasicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BásicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AréaDoQuadradoEPerimetroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NúmerosAntecessoresESucessoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaiorNúmeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntermediarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvançadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
End Class
