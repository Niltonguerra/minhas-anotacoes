<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class contaadmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(contaadmin))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChormeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.CadastrarProdutos = New System.Windows.Forms.TabPage()
        Me.btn_cadastrar_roupa = New System.Windows.Forms.Label()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_quantidade = New System.Windows.Forms.TextBox()
        Me.txt_cor = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.ProdutosCadastrados = New System.Windows.Forms.TabPage()
        Me.dgv_dados_prod = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.excl = New System.Windows.Forms.DataGridViewImageColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca_prod = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo_prod = New System.Windows.Forms.ToolStripComboBox()
        Me.CadastrarClientes = New System.Windows.Forms.TabPage()
        Me.btn_cadastrar_cliente = New System.Windows.Forms.Label()
        Me.img_foto_cliente = New System.Windows.Forms.PictureBox()
        Me.txt_dtNasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_clientenome = New System.Windows.Forms.TextBox()
        Me.ClientesCadastrados = New System.Windows.Forms.TabPage()
        Me.dgv_dados_cliente = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colum_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colum_nome_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colum_excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.RegistrarVenda = New System.Windows.Forms.TabPage()
        Me.btn_RegistrarVenda = New System.Windows.Forms.Label()
        Me.txt_valorfinal = New System.Windows.Forms.TextBox()
        Me.txt_desconto = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_quantidade_aux = New System.Windows.Forms.TextBox()
        Me.txt_produtopreco = New System.Windows.Forms.TextBox()
        Me.txt_produtonome_aux = New System.Windows.Forms.TextBox()
        Me.txt_codigoaux = New System.Windows.Forms.TextBox()
        Me.txt_nome_aux = New System.Windows.Forms.TextBox()
        Me.txt_cpf_aux = New System.Windows.Forms.MaskedTextBox()
        Me.VendasRegistradas = New System.Windows.Forms.TabPage()
        Me.dgv_vendasregistradas = New System.Windows.Forms.DataGridView()
        Me.codigovenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutoNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendaQuantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescontoVenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ContaadminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.CadastrarProdutos.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdutosCadastrados.SuspendLayout()
        CType(Me.dgv_dados_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.CadastrarClientes.SuspendLayout()
        CType(Me.img_foto_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesCadastrados.SuspendLayout()
        CType(Me.dgv_dados_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.RegistrarVenda.SuspendLayout()
        Me.VendasRegistradas.SuspendLayout()
        CType(Me.dgv_vendasregistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.ContaadminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel1.Image = Global.lojaroupa.My.Resources.Resources.logo
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordToolStripMenuItem, Me.ChormeToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripSplitButton1.Text = "Ferramentas"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.Image = Global.lojaroupa.My.Resources.Resources.Captura_de_tela_2023_03_28_162336_resized
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.WordToolStripMenuItem.Text = "word"
        '
        'ChormeToolStripMenuItem
        '
        Me.ChormeToolStripMenuItem.Image = Global.lojaroupa.My.Resources.Resources.Captura_de_tela_2023_03_28_162310_resized
        Me.ChormeToolStripMenuItem.Name = "ChormeToolStripMenuItem"
        Me.ChormeToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ChormeToolStripMenuItem.Text = "chorme"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.CadastrarProdutos)
        Me.Tab.Controls.Add(Me.ProdutosCadastrados)
        Me.Tab.Controls.Add(Me.CadastrarClientes)
        Me.Tab.Controls.Add(Me.ClientesCadastrados)
        Me.Tab.Controls.Add(Me.RegistrarVenda)
        Me.Tab.Controls.Add(Me.VendasRegistradas)
        Me.Tab.Location = New System.Drawing.Point(0, 28)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(800, 425)
        Me.Tab.TabIndex = 1
        '
        'CadastrarProdutos
        '
        Me.CadastrarProdutos.BackgroundImage = Global.lojaroupa.My.Resources.Resources.CadastrarProdutos1
        Me.CadastrarProdutos.Controls.Add(Me.btn_cadastrar_roupa)
        Me.CadastrarProdutos.Controls.Add(Me.txt_preco)
        Me.CadastrarProdutos.Controls.Add(Me.txt_codigo)
        Me.CadastrarProdutos.Controls.Add(Me.img_foto)
        Me.CadastrarProdutos.Controls.Add(Me.txt_quantidade)
        Me.CadastrarProdutos.Controls.Add(Me.txt_cor)
        Me.CadastrarProdutos.Controls.Add(Me.txt_nome)
        Me.CadastrarProdutos.Location = New System.Drawing.Point(4, 22)
        Me.CadastrarProdutos.Name = "CadastrarProdutos"
        Me.CadastrarProdutos.Padding = New System.Windows.Forms.Padding(3)
        Me.CadastrarProdutos.Size = New System.Drawing.Size(792, 399)
        Me.CadastrarProdutos.TabIndex = 0
        Me.CadastrarProdutos.Text = "Cadastrar Produtos"
        Me.CadastrarProdutos.UseVisualStyleBackColor = True
        '
        'btn_cadastrar_roupa
        '
        Me.btn_cadastrar_roupa.AutoSize = True
        Me.btn_cadastrar_roupa.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar_roupa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar_roupa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_roupa.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar_roupa.Location = New System.Drawing.Point(317, 364)
        Me.btn_cadastrar_roupa.Name = "btn_cadastrar_roupa"
        Me.btn_cadastrar_roupa.Size = New System.Drawing.Size(161, 21)
        Me.btn_cadastrar_roupa.TabIndex = 21
        Me.btn_cadastrar_roupa.Text = "CADASTRAR ROUPA"
        Me.btn_cadastrar_roupa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_preco
        '
        Me.txt_preco.Location = New System.Drawing.Point(205, 296)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(100, 20)
        Me.txt_preco.TabIndex = 20
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(205, 96)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 18
        '
        'img_foto
        '
        Me.img_foto.Image = Global.lojaroupa.My.Resources.Resources.grande
        Me.img_foto.InitialImage = Nothing
        Me.img_foto.Location = New System.Drawing.Point(472, 96)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(200, 167)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 17
        Me.img_foto.TabStop = False
        '
        'txt_quantidade
        '
        Me.txt_quantidade.Location = New System.Drawing.Point(205, 243)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(100, 20)
        Me.txt_quantidade.TabIndex = 4
        '
        'txt_cor
        '
        Me.txt_cor.Location = New System.Drawing.Point(205, 193)
        Me.txt_cor.Name = "txt_cor"
        Me.txt_cor.Size = New System.Drawing.Size(100, 20)
        Me.txt_cor.TabIndex = 2
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(205, 143)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_nome.TabIndex = 0
        '
        'ProdutosCadastrados
        '
        Me.ProdutosCadastrados.Controls.Add(Me.dgv_dados_prod)
        Me.ProdutosCadastrados.Controls.Add(Me.ToolStrip3)
        Me.ProdutosCadastrados.Location = New System.Drawing.Point(4, 22)
        Me.ProdutosCadastrados.Name = "ProdutosCadastrados"
        Me.ProdutosCadastrados.Padding = New System.Windows.Forms.Padding(3)
        Me.ProdutosCadastrados.Size = New System.Drawing.Size(792, 399)
        Me.ProdutosCadastrados.TabIndex = 2
        Me.ProdutosCadastrados.Text = "Produtos Cadastrados"
        Me.ProdutosCadastrados.UseVisualStyleBackColor = True
        '
        'dgv_dados_prod
        '
        Me.dgv_dados_prod.AllowUserToAddRows = False
        Me.dgv_dados_prod.AllowUserToDeleteRows = False
        Me.dgv_dados_prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados_prod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados_prod.BackgroundColor = System.Drawing.Color.Tomato
        Me.dgv_dados_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.cod_prod, Me.DataGridViewTextBoxColumn3, Me.quant, Me.cor, Me.prec, Me.excl, Me.edit, Me.DataGridViewImageColumn3})
        Me.dgv_dados_prod.Location = New System.Drawing.Point(0, 31)
        Me.dgv_dados_prod.Name = "dgv_dados_prod"
        Me.dgv_dados_prod.ReadOnly = True
        Me.dgv_dados_prod.Size = New System.Drawing.Size(792, 368)
        Me.dgv_dados_prod.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nº"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 44
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
        'quant
        '
        Me.quant.HeaderText = "Quantidade de Peças"
        Me.quant.Name = "quant"
        Me.quant.ReadOnly = True
        Me.quant.Width = 96
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
        'excl
        '
        Me.excl.HeaderText = "Excluir"
        Me.excl.Image = Global.lojaroupa.My.Resources.Resources.exc_resized
        Me.excl.Name = "excl"
        Me.excl.ReadOnly = True
        Me.excl.Width = 44
        '
        'edit
        '
        Me.edit.HeaderText = "Editar"
        Me.edit.Image = Global.lojaroupa.My.Resources.Resources.edit_resized
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Width = 40
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
        'CadastrarClientes
        '
        Me.CadastrarClientes.BackgroundImage = Global.lojaroupa.My.Resources.Resources.CadastrarClientes1
        Me.CadastrarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CadastrarClientes.Controls.Add(Me.btn_cadastrar_cliente)
        Me.CadastrarClientes.Controls.Add(Me.img_foto_cliente)
        Me.CadastrarClientes.Controls.Add(Me.txt_dtNasc)
        Me.CadastrarClientes.Controls.Add(Me.txt_email)
        Me.CadastrarClientes.Controls.Add(Me.txt_fone)
        Me.CadastrarClientes.Controls.Add(Me.txt_cpf)
        Me.CadastrarClientes.Controls.Add(Me.txt_clientenome)
        Me.CadastrarClientes.Location = New System.Drawing.Point(4, 22)
        Me.CadastrarClientes.Name = "CadastrarClientes"
        Me.CadastrarClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.CadastrarClientes.Size = New System.Drawing.Size(792, 399)
        Me.CadastrarClientes.TabIndex = 3
        Me.CadastrarClientes.Text = "Cadastrar Cliente"
        Me.CadastrarClientes.UseVisualStyleBackColor = True
        '
        'btn_cadastrar_cliente
        '
        Me.btn_cadastrar_cliente.AutoSize = True
        Me.btn_cadastrar_cliente.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar_cliente.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_cliente.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.Location = New System.Drawing.Point(329, 357)
        Me.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente"
        Me.btn_cadastrar_cliente.Size = New System.Drawing.Size(138, 30)
        Me.btn_cadastrar_cliente.TabIndex = 25
        Me.btn_cadastrar_cliente.Text = "CADASTRAR"
        Me.btn_cadastrar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'img_foto_cliente
        '
        Me.img_foto_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_foto_cliente.Image = Global.lojaroupa.My.Resources.Resources.nova_foto3
        Me.img_foto_cliente.Location = New System.Drawing.Point(396, 155)
        Me.img_foto_cliente.Name = "img_foto_cliente"
        Me.img_foto_cliente.Size = New System.Drawing.Size(155, 159)
        Me.img_foto_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto_cliente.TabIndex = 23
        Me.img_foto_cliente.TabStop = False
        '
        'txt_dtNasc
        '
        Me.txt_dtNasc.Location = New System.Drawing.Point(396, 95)
        Me.txt_dtNasc.Name = "txt_dtNasc"
        Me.txt_dtNasc.Size = New System.Drawing.Size(212, 20)
        Me.txt_dtNasc.TabIndex = 22
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(128, 286)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(119, 20)
        Me.txt_email.TabIndex = 19
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(128, 222)
        Me.txt_fone.Mask = "(00) 00000-0000"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(119, 20)
        Me.txt_fone.TabIndex = 18
        Me.txt_fone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(128, 155)
        Me.txt_cpf.Mask = "999,999,999-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf.TabIndex = 17
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_clientenome
        '
        Me.txt_clientenome.Location = New System.Drawing.Point(128, 95)
        Me.txt_clientenome.Name = "txt_clientenome"
        Me.txt_clientenome.Size = New System.Drawing.Size(100, 20)
        Me.txt_clientenome.TabIndex = 2
        '
        'ClientesCadastrados
        '
        Me.ClientesCadastrados.Controls.Add(Me.dgv_dados_cliente)
        Me.ClientesCadastrados.Controls.Add(Me.ToolStrip2)
        Me.ClientesCadastrados.Location = New System.Drawing.Point(4, 22)
        Me.ClientesCadastrados.Name = "ClientesCadastrados"
        Me.ClientesCadastrados.Padding = New System.Windows.Forms.Padding(3)
        Me.ClientesCadastrados.Size = New System.Drawing.Size(792, 399)
        Me.ClientesCadastrados.TabIndex = 1
        Me.ClientesCadastrados.Text = "Clientes Cadastrados"
        Me.ClientesCadastrados.UseVisualStyleBackColor = True
        '
        'dgv_dados_cliente
        '
        Me.dgv_dados_cliente.AllowUserToAddRows = False
        Me.dgv_dados_cliente.AllowUserToDeleteRows = False
        Me.dgv_dados_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados_cliente.BackgroundColor = System.Drawing.Color.Tomato
        Me.dgv_dados_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.colum_cpf, Me.colum_nome_cliente, Me.img, Me.colum_excluir})
        Me.dgv_dados_cliente.Location = New System.Drawing.Point(0, 28)
        Me.dgv_dados_cliente.Name = "dgv_dados_cliente"
        Me.dgv_dados_cliente.ReadOnly = True
        Me.dgv_dados_cliente.Size = New System.Drawing.Size(792, 368)
        Me.dgv_dados_cliente.TabIndex = 0
        '
        'num
        '
        Me.num.HeaderText = "Nº"
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        Me.num.Width = 44
        '
        'colum_cpf
        '
        Me.colum_cpf.HeaderText = "CPF"
        Me.colum_cpf.Name = "colum_cpf"
        Me.colum_cpf.ReadOnly = True
        Me.colum_cpf.Width = 52
        '
        'colum_nome_cliente
        '
        Me.colum_nome_cliente.HeaderText = "Cliente"
        Me.colum_nome_cliente.Name = "colum_nome_cliente"
        Me.colum_nome_cliente.ReadOnly = True
        Me.colum_nome_cliente.Width = 64
        '
        'img
        '
        Me.img.HeaderText = "Foto"
        Me.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.img.Name = "img"
        Me.img.ReadOnly = True
        Me.img.Width = 34
        '
        'colum_excluir
        '
        Me.colum_excluir.HeaderText = "Excluir"
        Me.colum_excluir.Image = Global.lojaroupa.My.Resources.Resources.exc_resized
        Me.colum_excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colum_excluir.Name = "colum_excluir"
        Me.colum_excluir.ReadOnly = True
        Me.colum_excluir.Width = 44
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.txt_busca, Me.ToolStripLabel3, Me.cmb_tipo})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(786, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripLabel2.Text = "Digite um parãmetro:"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripLabel3.Text = "Selecione o tipo:"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Items.AddRange(New Object() {"CPF", "Nome"})
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(121, 25)
        '
        'RegistrarVenda
        '
        Me.RegistrarVenda.BackgroundImage = Global.lojaroupa.My.Resources.Resources.CadastrarVenda
        Me.RegistrarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegistrarVenda.Controls.Add(Me.btn_RegistrarVenda)
        Me.RegistrarVenda.Controls.Add(Me.txt_valorfinal)
        Me.RegistrarVenda.Controls.Add(Me.txt_desconto)
        Me.RegistrarVenda.Controls.Add(Me.txt_subtotal)
        Me.RegistrarVenda.Controls.Add(Me.txt_quantidade_aux)
        Me.RegistrarVenda.Controls.Add(Me.txt_produtopreco)
        Me.RegistrarVenda.Controls.Add(Me.txt_produtonome_aux)
        Me.RegistrarVenda.Controls.Add(Me.txt_codigoaux)
        Me.RegistrarVenda.Controls.Add(Me.txt_nome_aux)
        Me.RegistrarVenda.Controls.Add(Me.txt_cpf_aux)
        Me.RegistrarVenda.Location = New System.Drawing.Point(4, 22)
        Me.RegistrarVenda.Name = "RegistrarVenda"
        Me.RegistrarVenda.Padding = New System.Windows.Forms.Padding(3)
        Me.RegistrarVenda.Size = New System.Drawing.Size(792, 399)
        Me.RegistrarVenda.TabIndex = 4
        Me.RegistrarVenda.Text = "Registrar Venda"
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
        Me.txt_valorfinal.Location = New System.Drawing.Point(497, 293)
        Me.txt_valorfinal.Name = "txt_valorfinal"
        Me.txt_valorfinal.ReadOnly = True
        Me.txt_valorfinal.Size = New System.Drawing.Size(100, 20)
        Me.txt_valorfinal.TabIndex = 26
        '
        'txt_desconto
        '
        Me.txt_desconto.Location = New System.Drawing.Point(215, 293)
        Me.txt_desconto.Name = "txt_desconto"
        Me.txt_desconto.Size = New System.Drawing.Size(100, 20)
        Me.txt_desconto.TabIndex = 25
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(215, 267)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_subtotal.TabIndex = 24
        '
        'txt_quantidade_aux
        '
        Me.txt_quantidade_aux.Location = New System.Drawing.Point(215, 241)
        Me.txt_quantidade_aux.Name = "txt_quantidade_aux"
        Me.txt_quantidade_aux.Size = New System.Drawing.Size(100, 20)
        Me.txt_quantidade_aux.TabIndex = 23
        '
        'txt_produtopreco
        '
        Me.txt_produtopreco.Location = New System.Drawing.Point(215, 215)
        Me.txt_produtopreco.Name = "txt_produtopreco"
        Me.txt_produtopreco.ReadOnly = True
        Me.txt_produtopreco.Size = New System.Drawing.Size(100, 20)
        Me.txt_produtopreco.TabIndex = 22
        '
        'txt_produtonome_aux
        '
        Me.txt_produtonome_aux.Location = New System.Drawing.Point(215, 189)
        Me.txt_produtonome_aux.Name = "txt_produtonome_aux"
        Me.txt_produtonome_aux.ReadOnly = True
        Me.txt_produtonome_aux.Size = New System.Drawing.Size(100, 20)
        Me.txt_produtonome_aux.TabIndex = 21
        '
        'txt_codigoaux
        '
        Me.txt_codigoaux.Location = New System.Drawing.Point(215, 163)
        Me.txt_codigoaux.Name = "txt_codigoaux"
        Me.txt_codigoaux.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigoaux.TabIndex = 20
        '
        'txt_nome_aux
        '
        Me.txt_nome_aux.Location = New System.Drawing.Point(201, 102)
        Me.txt_nome_aux.Name = "txt_nome_aux"
        Me.txt_nome_aux.ReadOnly = True
        Me.txt_nome_aux.Size = New System.Drawing.Size(100, 20)
        Me.txt_nome_aux.TabIndex = 19
        '
        'txt_cpf_aux
        '
        Me.txt_cpf_aux.Location = New System.Drawing.Point(110, 66)
        Me.txt_cpf_aux.Mask = "999,999,999-00"
        Me.txt_cpf_aux.Name = "txt_cpf_aux"
        Me.txt_cpf_aux.Size = New System.Drawing.Size(100, 20)
        Me.txt_cpf_aux.TabIndex = 18
        Me.txt_cpf_aux.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VendasRegistradas
        '
        Me.VendasRegistradas.Controls.Add(Me.dgv_vendasregistradas)
        Me.VendasRegistradas.Controls.Add(Me.ToolStrip4)
        Me.VendasRegistradas.Location = New System.Drawing.Point(4, 22)
        Me.VendasRegistradas.Name = "VendasRegistradas"
        Me.VendasRegistradas.Padding = New System.Windows.Forms.Padding(3)
        Me.VendasRegistradas.Size = New System.Drawing.Size(792, 399)
        Me.VendasRegistradas.TabIndex = 5
        Me.VendasRegistradas.Text = "Vendas Registradas"
        Me.VendasRegistradas.UseVisualStyleBackColor = True
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
        Me.dgv_vendasregistradas.Location = New System.Drawing.Point(0, 26)
        Me.dgv_vendasregistradas.Name = "dgv_vendasregistradas"
        Me.dgv_vendasregistradas.ReadOnly = True
        Me.dgv_vendasregistradas.Size = New System.Drawing.Size(792, 368)
        Me.dgv_vendasregistradas.TabIndex = 3
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "editar"
        Me.DataGridViewImageColumn1.Image = Global.lojaroupa.My.Resources.Resources.edit
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 39
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "excluir"
        Me.DataGridViewImageColumn2.Image = Global.lojaroupa.My.Resources.Resources.exc
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 43
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.HeaderText = "editar"
        Me.DataGridViewImageColumn4.Image = Global.lojaroupa.My.Resources.Resources.edit_resized
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ReadOnly = True
        Me.DataGridViewImageColumn4.Width = 39
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.HeaderText = "Excluir"
        Me.DataGridViewImageColumn5.Image = Global.lojaroupa.My.Resources.Resources.exc_resized
        Me.DataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.Width = 44
        '
        'ContaadminBindingSource
        '
        Me.ContaadminBindingSource.DataSource = GetType(lojaroupa.contaadmin)
        '
        'CadastroBindingSource
        '
        Me.CadastroBindingSource.DataSource = GetType(lojaroupa.cadastro)
        '
        'contaadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Tab)
        Me.Name = "contaadmin"
        Me.Text = "Administração R&E Roupas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Tab.ResumeLayout(False)
        Me.CadastrarProdutos.ResumeLayout(False)
        Me.CadastrarProdutos.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdutosCadastrados.ResumeLayout(False)
        Me.ProdutosCadastrados.PerformLayout()
        CType(Me.dgv_dados_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.CadastrarClientes.ResumeLayout(False)
        Me.CadastrarClientes.PerformLayout()
        CType(Me.img_foto_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesCadastrados.ResumeLayout(False)
        Me.ClientesCadastrados.PerformLayout()
        CType(Me.dgv_dados_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.RegistrarVenda.ResumeLayout(False)
        Me.RegistrarVenda.PerformLayout()
        Me.VendasRegistradas.ResumeLayout(False)
        Me.VendasRegistradas.PerformLayout()
        CType(Me.dgv_vendasregistradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.ContaadminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChormeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tab As TabControl
    Friend WithEvents CadastrarProdutos As TabPage
    Friend WithEvents ClientesCadastrados As TabPage
    Friend WithEvents ProdutosCadastrados As TabPage
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents txt_cor As TextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents dgv_dados_cliente As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents dgv_dados_prod As DataGridView
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents txt_busca_prod As ToolStripTextBox
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents cmb_tipo_prod As ToolStripComboBox
    Friend WithEvents CadastrarClientes As TabPage
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents RegistrarVenda As TabPage
    Friend WithEvents VendasRegistradas As TabPage
    Friend WithEvents txt_clientenome As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_dtNasc As DateTimePicker
    Friend WithEvents img_foto_cliente As PictureBox
    Friend WithEvents btn_cadastrar_cliente As Label
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel7 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents btn_cadastrar_roupa As Label
    Friend WithEvents ContaadminBindingSource As BindingSource
    Friend WithEvents CadastroBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents cod_prod As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents quant As DataGridViewTextBoxColumn
    Friend WithEvents cor As DataGridViewTextBoxColumn
    Friend WithEvents prec As DataGridViewTextBoxColumn
    Friend WithEvents excl As DataGridViewImageColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents colum_cpf As DataGridViewTextBoxColumn
    Friend WithEvents colum_nome_cliente As DataGridViewTextBoxColumn
    Friend WithEvents img As DataGridViewImageColumn
    Friend WithEvents colum_excluir As DataGridViewImageColumn
    Friend WithEvents btn_RegistrarVenda As Label
    Friend WithEvents txt_valorfinal As TextBox
    Friend WithEvents txt_desconto As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_quantidade_aux As TextBox
    Friend WithEvents txt_produtopreco As TextBox
    Friend WithEvents txt_produtonome_aux As TextBox
    Friend WithEvents txt_codigoaux As TextBox
    Friend WithEvents txt_nome_aux As TextBox
    Friend WithEvents txt_cpf_aux As MaskedTextBox
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents dgv_vendasregistradas As DataGridView
    Friend WithEvents codigovenda As DataGridViewTextBoxColumn
    Friend WithEvents ClienteNome As DataGridViewTextBoxColumn
    Friend WithEvents ProdutoNome As DataGridViewTextBoxColumn
    Friend WithEvents PrecoProduto As DataGridViewTextBoxColumn
    Friend WithEvents VendaQuantidade As DataGridViewTextBoxColumn
    Friend WithEvents DescontoVenda As DataGridViewTextBoxColumn
    Friend WithEvents TotalValor As DataGridViewTextBoxColumn
End Class
