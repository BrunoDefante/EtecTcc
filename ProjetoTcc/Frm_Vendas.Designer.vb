<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Vendas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Vendas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.colNumPed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCod_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCod_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuantEstoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuant_Prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVl_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSub_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gp_Cliente = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.btnCadCliente = New System.Windows.Forms.Button()
        Me.btnConsCliente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConsProd = New System.Windows.Forms.Button()
        Me.NumQuantProd = New System.Windows.Forms.NumericUpDown()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnRemoveProd = New System.Windows.Forms.Button()
        Me.btnAddProd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecoTotProd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrecoUnit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtQuantEstoque = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbNumPedido = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combVendedor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbPrecoTotPed = New System.Windows.Forms.Label()
        Me.lbData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancelVenda = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gp_Cliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumQuantProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(499, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nova Venda"
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToAddRows = False
        Me.dgvPedido.AllowUserToDeleteRows = False
        Me.dgvPedido.BackgroundColor = System.Drawing.Color.White
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumPed, Me.colCod_Cliente, Me.colCod_Produto, Me.colQuantEstoque, Me.colDescricao, Me.colQuant_Prod, Me.colVl_Produto, Me.colSub_Total})
        Me.dgvPedido.Location = New System.Drawing.Point(17, 103)
        Me.dgvPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvPedido.MultiSelect = False
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.ReadOnly = True
        Me.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedido.Size = New System.Drawing.Size(733, 393)
        Me.dgvPedido.TabIndex = 9
        '
        'colNumPed
        '
        Me.colNumPed.HeaderText = "NumPed"
        Me.colNumPed.Name = "colNumPed"
        Me.colNumPed.ReadOnly = True
        Me.colNumPed.Visible = False
        '
        'colCod_Cliente
        '
        Me.colCod_Cliente.HeaderText = "Código_Cliente"
        Me.colCod_Cliente.Name = "colCod_Cliente"
        Me.colCod_Cliente.ReadOnly = True
        Me.colCod_Cliente.Visible = False
        '
        'colCod_Produto
        '
        Me.colCod_Produto.HeaderText = "Código Produto"
        Me.colCod_Produto.Name = "colCod_Produto"
        Me.colCod_Produto.ReadOnly = True
        '
        'colQuantEstoque
        '
        Me.colQuantEstoque.DataPropertyName = "Quantidade"
        Me.colQuantEstoque.HeaderText = "QuantEstoque"
        Me.colQuantEstoque.Name = "colQuantEstoque"
        Me.colQuantEstoque.ReadOnly = True
        Me.colQuantEstoque.Visible = False
        '
        'colDescricao
        '
        Me.colDescricao.HeaderText = "Descrição"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.ReadOnly = True
        '
        'colQuant_Prod
        '
        Me.colQuant_Prod.HeaderText = "Quantidade"
        Me.colQuant_Prod.Name = "colQuant_Prod"
        Me.colQuant_Prod.ReadOnly = True
        '
        'colVl_Produto
        '
        Me.colVl_Produto.HeaderText = "Valor Unitário"
        Me.colVl_Produto.Name = "colVl_Produto"
        Me.colVl_Produto.ReadOnly = True
        '
        'colSub_Total
        '
        Me.colSub_Total.HeaderText = "Sub Total"
        Me.colSub_Total.Name = "colSub_Total"
        Me.colSub_Total.ReadOnly = True
        '
        'gp_Cliente
        '
        Me.gp_Cliente.BackColor = System.Drawing.Color.Transparent
        Me.gp_Cliente.Controls.Add(Me.Label7)
        Me.gp_Cliente.Controls.Add(Me.txtNomeCliente)
        Me.gp_Cliente.Controls.Add(Me.Label6)
        Me.gp_Cliente.Controls.Add(Me.txtCodCliente)
        Me.gp_Cliente.Controls.Add(Me.btnCadCliente)
        Me.gp_Cliente.Controls.Add(Me.btnConsCliente)
        Me.gp_Cliente.Location = New System.Drawing.Point(725, 15)
        Me.gp_Cliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gp_Cliente.Name = "gp_Cliente"
        Me.gp_Cliente.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gp_Cliente.Size = New System.Drawing.Size(467, 80)
        Me.gp_Cliente.TabIndex = 10
        Me.gp_Cliente.TabStop = False
        Me.gp_Cliente.Text = "Adicionar Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(211, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nome:"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCliente.Location = New System.Drawing.Point(215, 32)
        Me.txtNomeCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(248, 26)
        Me.txtNomeCliente.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(120, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cod. Cliente"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(120, 32)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(87, 26)
        Me.txtCodCliente.TabIndex = 1
        Me.txtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCadCliente
        '
        Me.btnCadCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadCliente.Image = CType(resources.GetObject("btnCadCliente.Image"), System.Drawing.Image)
        Me.btnCadCliente.Location = New System.Drawing.Point(6, 22)
        Me.btnCadCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCadCliente.Name = "btnCadCliente"
        Me.btnCadCliente.Size = New System.Drawing.Size(54, 39)
        Me.btnCadCliente.TabIndex = 0
        Me.btnCadCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCadCliente.UseVisualStyleBackColor = True
        '
        'btnConsCliente
        '
        Me.btnConsCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsCliente.Image = CType(resources.GetObject("btnConsCliente.Image"), System.Drawing.Image)
        Me.btnConsCliente.Location = New System.Drawing.Point(61, 22)
        Me.btnConsCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsCliente.Name = "btnConsCliente"
        Me.btnConsCliente.Size = New System.Drawing.Size(54, 39)
        Me.btnConsCliente.TabIndex = 0
        Me.btnConsCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsCliente.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnConsProd)
        Me.GroupBox1.Controls.Add(Me.NumQuantProd)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.btnRemoveProd)
        Me.GroupBox1.Controls.Add(Me.btnAddProd)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPrecoTotProd)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPrecoUnit)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtQuantEstoque)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCodProd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(776, 103)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(412, 426)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adicionar Produtos"
        '
        'btnConsProd
        '
        Me.btnConsProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsProd.Image = CType(resources.GetObject("btnConsProd.Image"), System.Drawing.Image)
        Me.btnConsProd.Location = New System.Drawing.Point(115, 44)
        Me.btnConsProd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsProd.Name = "btnConsProd"
        Me.btnConsProd.Size = New System.Drawing.Size(54, 23)
        Me.btnConsProd.TabIndex = 19
        Me.btnConsProd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsProd.UseVisualStyleBackColor = True
        '
        'NumQuantProd
        '
        Me.NumQuantProd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumQuantProd.Location = New System.Drawing.Point(185, 98)
        Me.NumQuantProd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumQuantProd.Name = "NumQuantProd"
        Me.NumQuantProd.Size = New System.Drawing.Size(215, 26)
        Me.NumQuantProd.TabIndex = 18
        Me.NumQuantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumQuantProd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(10, 317)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(390, 21)
        Me.txtDescricao.TabIndex = 16
        '
        'btnRemoveProd
        '
        Me.btnRemoveProd.Enabled = False
        Me.btnRemoveProd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProd.Image = CType(resources.GetObject("btnRemoveProd.Image"), System.Drawing.Image)
        Me.btnRemoveProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveProd.Location = New System.Drawing.Point(227, 367)
        Me.btnRemoveProd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemoveProd.Name = "btnRemoveProd"
        Me.btnRemoveProd.Size = New System.Drawing.Size(177, 52)
        Me.btnRemoveProd.TabIndex = 15
        Me.btnRemoveProd.Text = "Remover Produto"
        Me.btnRemoveProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveProd.UseVisualStyleBackColor = True
        '
        'btnAddProd
        '
        Me.btnAddProd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProd.Image = CType(resources.GetObject("btnAddProd.Image"), System.Drawing.Image)
        Me.btnAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProd.Location = New System.Drawing.Point(10, 367)
        Me.btnAddProd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddProd.Name = "btnAddProd"
        Me.btnAddProd.Size = New System.Drawing.Size(194, 52)
        Me.btnAddProd.TabIndex = 14
        Me.btnAddProd.Text = "Adicionar Produto"
        Me.btnAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddProd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Descrição:"
        '
        'txtPrecoTotProd
        '
        Me.txtPrecoTotProd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoTotProd.Location = New System.Drawing.Point(194, 274)
        Me.txtPrecoTotProd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecoTotProd.Name = "txtPrecoTotProd"
        Me.txtPrecoTotProd.ReadOnly = True
        Me.txtPrecoTotProd.Size = New System.Drawing.Size(207, 23)
        Me.txtPrecoTotProd.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(194, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Preço Total:"
        '
        'txtPrecoUnit
        '
        Me.txtPrecoUnit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoUnit.Location = New System.Drawing.Point(194, 210)
        Me.txtPrecoUnit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecoUnit.Name = "txtPrecoUnit"
        Me.txtPrecoUnit.ReadOnly = True
        Me.txtPrecoUnit.Size = New System.Drawing.Size(207, 23)
        Me.txtPrecoUnit.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(192, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Preço Unitário:"
        '
        'txtQuantEstoque
        '
        Me.txtQuantEstoque.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantEstoque.Location = New System.Drawing.Point(277, 140)
        Me.txtQuantEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantEstoque.Name = "txtQuantEstoque"
        Me.txtQuantEstoque.ReadOnly = True
        Me.txtQuantEstoque.Size = New System.Drawing.Size(124, 21)
        Me.txtQuantEstoque.TabIndex = 8
        Me.txtQuantEstoque.Text = "Qtde. em Estoque"
        Me.txtQuantEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(182, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Quantidade:"
        '
        'txtCodProd
        '
        Me.txtCodProd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(185, 44)
        Me.txtCodProd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(216, 23)
        Me.txtCodProd.TabIndex = 1
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Data:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "N° Pedido:"
        '
        'lbNumPedido
        '
        Me.lbNumPedido.AutoSize = True
        Me.lbNumPedido.BackColor = System.Drawing.Color.Transparent
        Me.lbNumPedido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumPedido.ForeColor = System.Drawing.Color.Red
        Me.lbNumPedido.Location = New System.Drawing.Point(274, 51)
        Me.lbNumPedido.Name = "lbNumPedido"
        Me.lbNumPedido.Size = New System.Drawing.Size(18, 19)
        Me.lbNumPedido.TabIndex = 15
        Me.lbNumPedido.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Vendedor:"
        '
        'combVendedor
        '
        Me.combVendedor.FormattingEnabled = True
        Me.combVendedor.Location = New System.Drawing.Point(392, 49)
        Me.combVendedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.combVendedor.Name = "combVendedor"
        Me.combVendedor.Size = New System.Drawing.Size(263, 24)
        Me.combVendedor.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(464, 513)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 28)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Total:"
        '
        'lbPrecoTotPed
        '
        Me.lbPrecoTotPed.BackColor = System.Drawing.Color.MediumBlue
        Me.lbPrecoTotPed.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecoTotPed.ForeColor = System.Drawing.Color.White
        Me.lbPrecoTotPed.Location = New System.Drawing.Point(561, 500)
        Me.lbPrecoTotPed.Name = "lbPrecoTotPed"
        Me.lbPrecoTotPed.Size = New System.Drawing.Size(189, 47)
        Me.lbPrecoTotPed.TabIndex = 19
        Me.lbPrecoTotPed.Text = "00,00"
        Me.lbPrecoTotPed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.BackColor = System.Drawing.Color.Transparent
        Me.lbData.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbData.Location = New System.Drawing.Point(11, 43)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(95, 19)
        Me.lbData.TabIndex = 20
        Me.lbData.Text = "00/00/0000"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnCancelVenda
        '
        Me.btnCancelVenda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelVenda.Image = CType(resources.GetObject("btnCancelVenda.Image"), System.Drawing.Image)
        Me.btnCancelVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelVenda.Location = New System.Drawing.Point(234, 500)
        Me.btnCancelVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelVenda.Name = "btnCancelVenda"
        Me.btnCancelVenda.Size = New System.Drawing.Size(160, 52)
        Me.btnCancelVenda.TabIndex = 22
        Me.btnCancelVenda.Text = "Cancelar Venda"
        Me.btnCancelVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelVenda.UseVisualStyleBackColor = True
        '
        'btnVender
        '
        Me.btnVender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVender.Image = CType(resources.GetObject("btnVender.Image"), System.Drawing.Image)
        Me.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVender.Location = New System.Drawing.Point(17, 500)
        Me.btnVender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(157, 52)
        Me.btnVender.TabIndex = 21
        Me.btnVender.Text = "Realizar Venda"
        Me.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'Frm_Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1209, 556)
        Me.Controls.Add(Me.btnCancelVenda)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.lbPrecoTotPed)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.combVendedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbNumPedido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gp_Cliente)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_Vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total Pago:"
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gp_Cliente.ResumeLayout(False)
        Me.gp_Cliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumQuantProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPedido As System.Windows.Forms.DataGridView
    Friend WithEvents gp_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsCliente As System.Windows.Forms.Button
    Friend WithEvents txtNomeCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoTotProd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtQuantEstoque As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoveProd As System.Windows.Forms.Button
    Friend WithEvents btnAddProd As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbNumPedido As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbPrecoTotPed As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents NumQuantProd As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbData As System.Windows.Forms.Label
    Friend WithEvents btnConsProd As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCancelVenda As System.Windows.Forms.Button
    Friend WithEvents btnVender As System.Windows.Forms.Button
    Friend WithEvents colNumPed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCod_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCod_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantEstoque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuant_Prod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVl_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSub_Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCadCliente As System.Windows.Forms.Button
End Class
