<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class contacliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.ProdutosCadastrados = New System.Windows.Forms.TabPage()
        Me.dgv_dados_prod_cliente = New System.Windows.Forms.DataGridView()
        Me.cod_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca_prod = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo_prod = New System.Windows.Forms.ToolStripComboBox()
        Me.RegistrarVenda = New System.Windows.Forms.TabPage()
        Me.btn_RegistrarVenda = New System.Windows.Forms.Label()
        Me.txt_valorfinal = New System.Windows.Forms.TextBox()
        Me.txt_desconto = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_quantidade_aux = New System.Windows.Forms.TextBox()
        Me.txt_produtopreco = New System.Windows.Forms.TextBox()
        Me.txt_produtonome_aux = New System.Windows.Forms.TextBox()
        Me.txt_produtocodigo = New System.Windows.Forms.TextBox()
        Me.VendasRegistradas = New System.Windows.Forms.TabPage()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_vendasregistradas = New System.Windows.Forms.DataGridView()
        Me.codigovenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutoNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendaQuantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescontoVenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Tab.SuspendLayout()
        Me.ProdutosCadastrados.SuspendLayout()
        CType(Me.dgv_dados_prod_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.RegistrarVenda.SuspendLayout()
        Me.VendasRegistradas.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.dgv_vendasregistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.ProdutosCadastrados)
        Me.Tab.Controls.Add(Me.RegistrarVenda)
        Me.Tab.Controls.Add(Me.VendasRegistradas)
        Me.Tab.Location = New System.Drawing.Point(1, 12)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(800, 425)
        Me.Tab.TabIndex = 2
        '
        'ProdutosCadastrados
        '
        Me.ProdutosCadastrados.Controls.Add(Me.dgv_dados_prod_cliente)
        Me.ProdutosCadastrados.Controls.Add(Me.ToolStrip3)
        Me.ProdutosCadastrados.Location = New System.Drawing.Point(4, 22)
        Me.ProdutosCadastrados.Name = "ProdutosCadastrados"
        Me.ProdutosCadastrados.Padding = New System.Windows.Forms.Padding(3)
        Me.ProdutosCadastrados.Size = New System.Drawing.Size(792, 399)
        Me.ProdutosCadastrados.TabIndex = 2
        Me.ProdutosCadastrados.Text = "Catalogo de Produtos"
        Me.ProdutosCadastrados.UseVisualStyleBackColor = True
        '
        'dgv_dados_prod_cliente
        '
        Me.dgv_dados_prod_cliente.AllowUserToAddRows = False
        Me.dgv_dados_prod_cliente.AllowUserToDeleteRows = False
        Me.dgv_dados_prod_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados_prod_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados_prod_cliente.BackgroundColor = System.Drawing.Color.Tomato
        Me.dgv_dados_prod_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_prod_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_prod, Me.DataGridViewTextBoxColumn3, Me.cor, Me.prec, Me.DataGridViewImageColumn3})
        Me.dgv_dados_prod_cliente.Location = New System.Drawing.Point(3, 31)
        Me.dgv_dados_prod_cliente.Name = "dgv_dados_prod_cliente"
        Me.dgv_dados_prod_cliente.ReadOnly = True
        Me.dgv_dados_prod_cliente.Size = New System.Drawing.Size(792, 368)
        Me.dgv_dados_prod_cliente.TabIndex = 1
        '
        'cod_prod
        '
        Me.cod_prod.HeaderText = "Código do produto"
        Me.cod_prod.Name = "cod_prod"
        Me.cod_prod.ReadOnly = True
        Me.cod_prod.Width = 109
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'cor
        '
        Me.cor.HeaderText = "Cor"
        Me.cor.Name = "cor"
        Me.cor.ReadOnly = True
        Me.cor.Width = 48
        '
        'prec
        '
        Me.prec.HeaderText = "Valor"
        Me.prec.Name = "prec"
        Me.prec.ReadOnly = True
        Me.prec.Width = 56
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "Fotos"
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Width = 39
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.txt_busca_prod, Me.ToolStripLabel5, Me.cmb_tipo_prod})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(786, 25)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripLabel4.Text = "Digite um parãmetro:"
        '
        'txt_busca_prod
        '
        Me.txt_busca_prod.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca_prod.Name = "txt_busca_prod"
        Me.txt_busca_prod.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripLabel5.Text = "Selecione o tipo:"
        '
        'cmb_tipo_prod
        '
        Me.cmb_tipo_prod.Items.AddRange(New Object() {"CPF", "Nome"})
        Me.cmb_tipo_prod.Name = "cmb_tipo_prod"
        Me.cmb_tipo_prod.Size = New System.Drawing.Size(121, 25)
        '
        'RegistrarVenda
        '
        Me.RegistrarVenda.BackgroundImage = Global.lojaroupa.My.Resources.Resources.CadastrarVendaCliente
        Me.RegistrarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrarVenda.Controls.Add(Me.btn_RegistrarVenda)
        Me.RegistrarVenda.Controls.Add(Me.txt_valorfinal)
        Me.RegistrarVenda.Controls.Add(Me.txt_desconto)
        Me.RegistrarVenda.Controls.Add(Me.txt_subtotal)
        Me.RegistrarVenda.Controls.Add(Me.txt_quantidade_aux)
        Me.RegistrarVenda.Controls.Add(Me.txt_produtopreco)
        Me.RegistrarVenda.Controls.Add(Me.txt_produtonome_aux)
        Me.RegistrarVenda.Controls.Add(Me.txt_produtocodigo)
        Me.RegistrarVenda.Location = New System.Drawing.Point(4, 22)
        Me.RegistrarVenda.Name = "RegistrarVenda"
        Me.RegistrarVenda.Padding = New System.Windows.Forms.Padding(3)
        Me.RegistrarVenda.Size = New System.Drawing.Size(792, 399)
        Me.RegistrarVenda.TabIndex = 4
        Me.RegistrarVenda.Text = "Comprar"
        Me.RegistrarVenda.UseVisualStyleBackColor = True
        '
        'btn_RegistrarVenda
        '
        Me.btn_RegistrarVenda.AutoSize = True
        Me.btn_RegistrarVenda.BackColor = System.Drawing.Color.Transparent
        Me.btn_RegistrarVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_RegistrarVenda.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_RegistrarVenda.ForeColor = System.Drawing.Color.White
        Me.btn_RegistrarVenda.Location = New System.Drawing.Point(320, 361)
        Me.btn_RegistrarVenda.Name = "btn_RegistrarVenda"
        Me.btn_RegistrarVenda.Size = New System.Drawing.Size(154, 21)
        Me.btn_RegistrarVenda.TabIndex = 27
        Me.btn_RegistrarVenda.Text = "REGISTRAR VENDA"
        Me.btn_RegistrarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_valorfinal
        '
        Me.txt_valorfinal.Location = New System.Drawing.Point(224, 287)
        Me.txt_valorfinal.Name = "txt_valorfinal"
        Me.txt_valorfinal.ReadOnly = True
        Me.txt_valorfinal.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorfinal.TabIndex = 26
        '
        'txt_desconto
        '
        Me.txt_desconto.Location = New System.Drawing.Point(224, 251)
        Me.txt_desconto.Name = "txt_desconto"
        Me.txt_desconto.Size = New System.Drawing.Size(100, 20)
        Me.txt_desconto.TabIndex = 25
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(224, 217)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_subtotal.TabIndex = 24
        '
        'txt_quantidade_aux
        '
        Me.txt_quantidade_aux.Location = New System.Drawing.Point(224, 180)
        Me.txt_quantidade_aux.Name = "txt_quantidade_aux"
        Me.txt_quantidade_aux.Size = New System.Drawing.Size(100, 20)
        Me.txt_quantidade_aux.TabIndex = 23
        '
        'txt_produtopreco
        '
        Me.txt_produtopreco.Location = New System.Drawing.Point(224, 146)
        Me.txt_produtopreco.Name = "txt_produtopreco"
        Me.txt_produtopreco.ReadOnly = True
        Me.txt_produtopreco.Size = New System.Drawing.Size(100, 20)
        Me.txt_produtopreco.TabIndex = 22
        '
        'txt_produtonome_aux
        '
        Me.txt_produtonome_aux.Location = New System.Drawing.Point(224, 107)
        Me.txt_produtonome_aux.Name = "txt_produtonome_aux"
        Me.txt_produtonome_aux.ReadOnly = True
        Me.txt_produtonome_aux.Size = New System.Drawing.Size(100, 20)
        Me.txt_produtonome_aux.TabIndex = 21
        '
        'txt_produtocodigo
        '
        Me.txt_produtocodigo.Location = New System.Drawing.Point(224, 73)
        Me.txt_produtocodigo.Name = "txt_produtocodigo"
        Me.txt_produtocodigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_produtocodigo.TabIndex = 20
        '
        'VendasRegistradas
        '
        Me.VendasRegistradas.Controls.Add(Me.ToolStrip4)
        Me.VendasRegistradas.Controls.Add(Me.dgv_vendasregistradas)
        Me.VendasRegistradas.Location = New System.Drawing.Point(4, 22)
        Me.VendasRegistradas.Name = "VendasRegistradas"
        Me.VendasRegistradas.Padding = New System.Windows.Forms.Padding(3)
        Me.VendasRegistradas.Size = New System.Drawing.Size(792, 399)
        Me.VendasRegistradas.TabIndex = 5
        Me.VendasRegistradas.Text = "Pedidos"
        Me.VendasRegistradas.UseVisualStyleBackColor = True
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel6, Me.ToolStripTextBox1, Me.ToolStripLabel7, Me.ToolStripComboBox1})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(786, 25)
        Me.ToolStrip4.TabIndex = 2
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripLabel6.Text = "Digite um parãmetro:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripLabel7.Text = "Selecione o tipo:"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"CPF", "Nome"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
        '
        'dgv_vendasregistradas
        '
        Me.dgv_vendasregistradas.AllowUserToAddRows = False
        Me.dgv_vendasregistradas.AllowUserToDeleteRows = False
        Me.dgv_vendasregistradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_vendasregistradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_vendasregistradas.BackgroundColor = System.Drawing.Color.Tomato
        Me.dgv_vendasregistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vendasregistradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigovenda, Me.ClienteNome, Me.ProdutoNome, Me.PrecoProduto, Me.VendaQuantidade, Me.DescontoVenda, Me.TotalValor})
        Me.dgv_vendasregistradas.Location = New System.Drawing.Point(0, 31)
        Me.dgv_vendasregistradas.Name = "dgv_vendasregistradas"
        Me.dgv_vendasregistradas.ReadOnly = True
        Me.dgv_vendasregistradas.Size = New System.Drawing.Size(792, 368)
        Me.dgv_vendasregistradas.TabIndex = 1
        '
        'codigovenda
        '
        Me.codigovenda.HeaderText = "Codigo Venda"
        Me.codigovenda.Name = "codigovenda"
        Me.codigovenda.ReadOnly = True
        Me.codigovenda.Width = 99
        '
        'ClienteNome
        '
        Me.ClienteNome.HeaderText = "Cliente Nome"
        Me.ClienteNome.Name = "ClienteNome"
        Me.ClienteNome.ReadOnly = True
        Me.ClienteNome.Width = 95
        '
        'ProdutoNome
        '
        Me.ProdutoNome.HeaderText = "Produto Nome"
        Me.ProdutoNome.Name = "ProdutoNome"
        Me.ProdutoNome.ReadOnly = True
        '
        'PrecoProduto
        '
        Me.PrecoProduto.HeaderText = "Preço"
        Me.PrecoProduto.Name = "PrecoProduto"
        Me.PrecoProduto.ReadOnly = True
        Me.PrecoProduto.Width = 60
        '
        'VendaQuantidade
        '
        Me.VendaQuantidade.HeaderText = "Quantidade"
        Me.VendaQuantidade.Name = "VendaQuantidade"
        Me.VendaQuantidade.ReadOnly = True
        Me.VendaQuantidade.Width = 87
        '
        'DescontoVenda
        '
        Me.DescontoVenda.HeaderText = "Desconto (%)"
        Me.DescontoVenda.Name = "DescontoVenda"
        Me.DescontoVenda.ReadOnly = True
        Me.DescontoVenda.Width = 95
        '
        'TotalValor
        '
        Me.TotalValor.HeaderText = "Valor Final"
        Me.TotalValor.Name = "TotalValor"
        Me.TotalValor.ReadOnly = True
        Me.TotalValor.Width = 81
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Excluir"
        Me.DataGridViewImageColumn1.Image = Global.lojaroupa.My.Resources.Resources.exc_resized
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 44
        '
        'contacliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 477)
        Me.Controls.Add(Me.Tab)
        Me.Name = "contacliente"
        Me.Text = "contacliente"
        Me.Tab.ResumeLayout(False)
        Me.ProdutosCadastrados.ResumeLayout(False)
        Me.ProdutosCadastrados.PerformLayout()
        CType(Me.dgv_dados_prod_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.RegistrarVenda.ResumeLayout(False)
        Me.RegistrarVenda.PerformLayout()
        Me.VendasRegistradas.ResumeLayout(False)
        Me.VendasRegistradas.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.dgv_vendasregistradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab As TabControl
    Friend WithEvents ProdutosCadastrados As TabPage
    Friend WithEvents dgv_dados_prod_cliente As DataGridView
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents txt_busca_prod As ToolStripTextBox
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents cmb_tipo_prod As ToolStripComboBox
    Friend WithEvents RegistrarVenda As TabPage
    Friend WithEvents btn_RegistrarVenda As Label
    Friend WithEvents txt_valorfinal As TextBox
    Friend WithEvents txt_desconto As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_quantidade_aux As TextBox
    Friend WithEvents txt_produtopreco As TextBox
    Friend WithEvents txt_produtonome_aux As TextBox
    Friend WithEvents txt_produtocodigo As TextBox
    Friend WithEvents VendasRegistradas As TabPage
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents dgv_vendasregistradas As DataGridView
    Friend WithEvents cod_prod As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents cor As DataGridViewTextBoxColumn
    Friend WithEvents prec As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents codigovenda As DataGridViewTextBoxColumn
    Friend WithEvents ClienteNome As DataGridViewTextBoxColumn
    Friend WithEvents ProdutoNome As DataGridViewTextBoxColumn
    Friend WithEvents PrecoProduto As DataGridViewTextBoxColumn
    Friend WithEvents VendaQuantidade As DataGridViewTextBoxColumn
    Friend WithEvents DescontoVenda As DataGridViewTextBoxColumn
    Friend WithEvents TotalValor As DataGridViewTextBoxColumn
End Class
