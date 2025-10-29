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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GerenciamentoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualBasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BásicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreaDoQuadradoEPerímetroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NúmerosAntecessorESucessorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaiorNúmeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvançadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciamentoDeClientesToolStripMenuItem, Me.FerramentasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GerenciamentoDeClientesToolStripMenuItem
        '
        Me.GerenciamentoDeClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualBasicToolStripMenuItem})
        Me.GerenciamentoDeClientesToolStripMenuItem.Image = CType(resources.GetObject("GerenciamentoDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciamentoDeClientesToolStripMenuItem.Name = "GerenciamentoDeClientesToolStripMenuItem"
        Me.GerenciamentoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.GerenciamentoDeClientesToolStripMenuItem.Text = "&Programas"
        '
        'VisualBasicToolStripMenuItem
        '
        Me.VisualBasicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BásicosToolStripMenuItem, Me.IntermediáriosToolStripMenuItem, Me.AvançadosToolStripMenuItem})
        Me.VisualBasicToolStripMenuItem.Image = CType(resources.GetObject("VisualBasicToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VisualBasicToolStripMenuItem.Name = "VisualBasicToolStripMenuItem"
        Me.VisualBasicToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VisualBasicToolStripMenuItem.Text = "Visual Basic"
        '
        'BásicosToolStripMenuItem
        '
        Me.BásicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÁreaDoQuadradoEPerímetroToolStripMenuItem, Me.NúmerosAntecessorESucessorToolStripMenuItem, Me.MaiorNúmeroToolStripMenuItem})
        Me.BásicosToolStripMenuItem.Name = "BásicosToolStripMenuItem"
        Me.BásicosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BásicosToolStripMenuItem.Text = "Básicos"
        '
        'ÁreaDoQuadradoEPerímetroToolStripMenuItem
        '
        Me.ÁreaDoQuadradoEPerímetroToolStripMenuItem.Name = "ÁreaDoQuadradoEPerímetroToolStripMenuItem"
        Me.ÁreaDoQuadradoEPerímetroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ÁreaDoQuadradoEPerímetroToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.ÁreaDoQuadradoEPerímetroToolStripMenuItem.Text = "Área do Quadrado e Perímetro"
        '
        'NúmerosAntecessorESucessorToolStripMenuItem
        '
        Me.NúmerosAntecessorESucessorToolStripMenuItem.Name = "NúmerosAntecessorESucessorToolStripMenuItem"
        Me.NúmerosAntecessorESucessorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.NúmerosAntecessorESucessorToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.NúmerosAntecessorESucessorToolStripMenuItem.Text = "Números Antecessor e Sucessor"
        '
        'MaiorNúmeroToolStripMenuItem
        '
        Me.MaiorNúmeroToolStripMenuItem.Name = "MaiorNúmeroToolStripMenuItem"
        Me.MaiorNúmeroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.MaiorNúmeroToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.MaiorNúmeroToolStripMenuItem.Text = "Maior Número"
        '
        'IntermediáriosToolStripMenuItem
        '
        Me.IntermediáriosToolStripMenuItem.Name = "IntermediáriosToolStripMenuItem"
        Me.IntermediáriosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IntermediáriosToolStripMenuItem.Text = "Intermediários"
        '
        'AvançadosToolStripMenuItem
        '
        Me.AvançadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeClientesToolStripMenuItem})
        Me.AvançadosToolStripMenuItem.Name = "AvançadosToolStripMenuItem"
        Me.AvançadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AvançadosToolStripMenuItem.Text = "Avançados"
        '
        'CadastroDeClientesToolStripMenuItem
        '
        Me.CadastroDeClientesToolStripMenuItem.Name = "CadastroDeClientesToolStripMenuItem"
        Me.CadastroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.ExcelToolStripMenuItem})
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.FerramentasToolStripMenuItem.Text = "&Ferramentas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Image = CType(resources.GetObject("ExcelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GerenciamentoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualBasicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BásicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÁreaDoQuadradoEPerímetroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NúmerosAntecessorESucessorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaiorNúmeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntermediáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvançadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerramentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
End Class
