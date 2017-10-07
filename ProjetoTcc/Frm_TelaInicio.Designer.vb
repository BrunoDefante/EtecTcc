<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnP_Sair = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PicNotfic = New System.Windows.Forms.PictureBox()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Data = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGerProd = New System.Windows.Forms.PictureBox()
        Me.btnGerFunc = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGerFornec = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRelato = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVenda = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGerUsuario = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGerCliente = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ListNotifica = New System.Windows.Forms.ListView()
        Me.colNotfica = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.antBug = New System.Windows.Forms.Button()
        Me.dgvConsultaProduto = New System.Windows.Forms.DataGridView()
        Me.FotosProdutos = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cod_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantMinima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.btnP_Sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PicNotfic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnGerProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGerFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGerFornec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRelato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGerUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGerCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsultaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnP_Sair
        '
        Me.btnP_Sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnP_Sair.Image = CType(resources.GetObject("btnP_Sair.Image"), System.Drawing.Image)
        Me.btnP_Sair.Location = New System.Drawing.Point(1259, 23)
        Me.btnP_Sair.Name = "btnP_Sair"
        Me.btnP_Sair.Size = New System.Drawing.Size(67, 52)
        Me.btnP_Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnP_Sair.TabIndex = 34
        Me.btnP_Sair.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PicNotfic)
        Me.Panel4.Controls.Add(Me.lbUser)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label_Data)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1366, 43)
        Me.Panel4.TabIndex = 13
        '
        'PicNotfic
        '
        Me.PicNotfic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicNotfic.Image = CType(resources.GetObject("PicNotfic.Image"), System.Drawing.Image)
        Me.PicNotfic.Location = New System.Drawing.Point(937, 0)
        Me.PicNotfic.Name = "PicNotfic"
        Me.PicNotfic.Size = New System.Drawing.Size(62, 44)
        Me.PicNotfic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNotfic.TabIndex = 28
        Me.PicNotfic.TabStop = False
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUser.Location = New System.Drawing.Point(199, 12)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(14, 21)
        Me.lbUser.TabIndex = 27
        Me.lbUser.Text = "."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Logado Como:"
        '
        'Label_Data
        '
        Me.Label_Data.AutoSize = True
        Me.Label_Data.BackColor = System.Drawing.Color.Transparent
        Me.Label_Data.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Data.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_Data.Location = New System.Drawing.Point(1180, 12)
        Me.Label_Data.Name = "Label_Data"
        Me.Label_Data.Size = New System.Drawing.Size(96, 21)
        Me.Label_Data.TabIndex = 25
        Me.Label_Data.Text = "00/00/0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(634, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Bem Vindo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnGerProd)
        Me.Panel1.Controls.Add(Me.btnGerFunc)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnGerFornec)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnRelato)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnVenda)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnGerUsuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnGerCliente)
        Me.Panel1.Controls.Add(Me.btnP_Sair)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 655)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 113)
        Me.Panel1.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1272, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 20)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Saír"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(724, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 17)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Gerenciar Produtos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(534, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 17)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Gerenciar Funcionário"
        '
        'btnGerProd
        '
        Me.btnGerProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerProd.Image = CType(resources.GetObject("btnGerProd.Image"), System.Drawing.Image)
        Me.btnGerProd.Location = New System.Drawing.Point(747, -5)
        Me.btnGerProd.Name = "btnGerProd"
        Me.btnGerProd.Size = New System.Drawing.Size(100, 98)
        Me.btnGerProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnGerProd.TabIndex = 51
        Me.btnGerProd.TabStop = False
        '
        'btnGerFunc
        '
        Me.btnGerFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerFunc.Image = CType(resources.GetObject("btnGerFunc.Image"), System.Drawing.Image)
        Me.btnGerFunc.Location = New System.Drawing.Point(564, -5)
        Me.btnGerFunc.Name = "btnGerFunc"
        Me.btnGerFunc.Size = New System.Drawing.Size(100, 98)
        Me.btnGerFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnGerFunc.TabIndex = 50
        Me.btnGerFunc.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(351, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Gerenciar Fornecedor"
        '
        'btnGerFornec
        '
        Me.btnGerFornec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerFornec.Image = CType(resources.GetObject("btnGerFornec.Image"), System.Drawing.Image)
        Me.btnGerFornec.Location = New System.Drawing.Point(382, -5)
        Me.btnGerFornec.Name = "btnGerFornec"
        Me.btnGerFornec.Size = New System.Drawing.Size(100, 98)
        Me.btnGerFornec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnGerFornec.TabIndex = 48
        Me.btnGerFornec.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1095, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Relatórios"
        '
        'btnRelato
        '
        Me.btnRelato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelato.Image = CType(resources.GetObject("btnRelato.Image"), System.Drawing.Image)
        Me.btnRelato.Location = New System.Drawing.Point(1090, -5)
        Me.btnRelato.Name = "btnRelato"
        Me.btnRelato.Size = New System.Drawing.Size(100, 98)
        Me.btnRelato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRelato.TabIndex = 46
        Me.btnRelato.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(922, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Nova Venda"
        '
        'btnVenda
        '
        Me.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVenda.Image = CType(resources.GetObject("btnVenda.Image"), System.Drawing.Image)
        Me.btnVenda.Location = New System.Drawing.Point(922, -5)
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.Size = New System.Drawing.Size(100, 98)
        Me.btnVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVenda.TabIndex = 44
        Me.btnVenda.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(172, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Gerenciar Usuário"
        '
        'btnGerUsuario
        '
        Me.btnGerUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerUsuario.Image = CType(resources.GetObject("btnGerUsuario.Image"), System.Drawing.Image)
        Me.btnGerUsuario.Location = New System.Drawing.Point(201, -8)
        Me.btnGerUsuario.Name = "btnGerUsuario"
        Me.btnGerUsuario.Size = New System.Drawing.Size(100, 98)
        Me.btnGerUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnGerUsuario.TabIndex = 42
        Me.btnGerUsuario.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Gerenciar Cliente"
        '
        'btnGerCliente
        '
        Me.btnGerCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGerCliente.Image = CType(resources.GetObject("btnGerCliente.Image"), System.Drawing.Image)
        Me.btnGerCliente.Location = New System.Drawing.Point(29, -8)
        Me.btnGerCliente.Name = "btnGerCliente"
        Me.btnGerCliente.Size = New System.Drawing.Size(100, 98)
        Me.btnGerCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnGerCliente.TabIndex = 41
        Me.btnGerCliente.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 2000
        '
        'ListNotifica
        '
        Me.ListNotifica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListNotifica.BackgroundImage = CType(resources.GetObject("ListNotifica.BackgroundImage"), System.Drawing.Image)
        Me.ListNotifica.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNotfica})
        Me.ListNotifica.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListNotifica.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListNotifica.ForeColor = System.Drawing.Color.Red
        Me.ListNotifica.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListNotifica.Location = New System.Drawing.Point(828, 44)
        Me.ListNotifica.MultiSelect = False
        Me.ListNotifica.Name = "ListNotifica"
        Me.ListNotifica.Size = New System.Drawing.Size(280, 241)
        Me.ListNotifica.TabIndex = 18
        Me.ListNotifica.UseCompatibleStateImageBehavior = False
        Me.ListNotifica.Visible = False
        '
        'colNotfica
        '
        Me.colNotfica.Text = ""
        Me.colNotfica.Width = 250
        '
        'antBug
        '
        Me.antBug.Location = New System.Drawing.Point(-81, 49)
        Me.antBug.Name = "antBug"
        Me.antBug.Size = New System.Drawing.Size(75, 23)
        Me.antBug.TabIndex = 20
        Me.antBug.Text = "Button1"
        Me.antBug.UseVisualStyleBackColor = True
        '
        'dgvConsultaProduto
        '
        Me.dgvConsultaProduto.AllowUserToAddRows = False
        Me.dgvConsultaProduto.AllowUserToDeleteRows = False
        Me.dgvConsultaProduto.AllowUserToResizeColumns = False
        Me.dgvConsultaProduto.AllowUserToResizeRows = False
        Me.dgvConsultaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FotosProdutos, Me.Cod_Produto, Me.Nome_Produto, Me.Tipo_Produto, Me.Custo, Me.Quantidade, Me.QuantMinima, Me.Foto})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsultaProduto.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvConsultaProduto.Location = New System.Drawing.Point(259, 221)
        Me.dgvConsultaProduto.MultiSelect = False
        Me.dgvConsultaProduto.Name = "dgvConsultaProduto"
        Me.dgvConsultaProduto.ReadOnly = True
        Me.dgvConsultaProduto.RowTemplate.Height = 50
        Me.dgvConsultaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaProduto.Size = New System.Drawing.Size(849, 326)
        Me.dgvConsultaProduto.TabIndex = 22
        Me.dgvConsultaProduto.Visible = False
        '
        'FotosProdutos
        '
        Me.FotosProdutos.FillWeight = 80.0!
        Me.FotosProdutos.HeaderText = "Foto"
        Me.FotosProdutos.Image = CType(resources.GetObject("FotosProdutos.Image"), System.Drawing.Image)
        Me.FotosProdutos.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.FotosProdutos.Name = "FotosProdutos"
        Me.FotosProdutos.ReadOnly = True
        Me.FotosProdutos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FotosProdutos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FotosProdutos.Visible = False
        Me.FotosProdutos.Width = 50
        '
        'Cod_Produto
        '
        Me.Cod_Produto.DataPropertyName = "Cod_Produto"
        Me.Cod_Produto.HeaderText = "Código"
        Me.Cod_Produto.Name = "Cod_Produto"
        Me.Cod_Produto.ReadOnly = True
        '
        'Nome_Produto
        '
        Me.Nome_Produto.DataPropertyName = "Nome_Produto"
        Me.Nome_Produto.HeaderText = "Nome"
        Me.Nome_Produto.Name = "Nome_Produto"
        Me.Nome_Produto.ReadOnly = True
        '
        'Tipo_Produto
        '
        Me.Tipo_Produto.DataPropertyName = "Tipo_Produto"
        Me.Tipo_Produto.HeaderText = "Tipo"
        Me.Tipo_Produto.Name = "Tipo_Produto"
        Me.Tipo_Produto.ReadOnly = True
        '
        'Custo
        '
        Me.Custo.DataPropertyName = "Custo"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Custo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Custo.HeaderText = "Custo"
        Me.Custo.Name = "Custo"
        Me.Custo.ReadOnly = True
        '
        'Quantidade
        '
        Me.Quantidade.DataPropertyName = "Quantidade"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Quantidade.DefaultCellStyle = DataGridViewCellStyle2
        Me.Quantidade.HeaderText = "Quantidade em Estoque"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        '
        'QuantMinima
        '
        Me.QuantMinima.DataPropertyName = "QuantMinima"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red
        Me.QuantMinima.DefaultCellStyle = DataGridViewCellStyle3
        Me.QuantMinima.HeaderText = "Quantidade Mínima"
        Me.QuantMinima.Name = "QuantMinima"
        Me.QuantMinima.ReadOnly = True
        '
        'Foto
        '
        Me.Foto.DataPropertyName = "Foto"
        Me.Foto.HeaderText = "Imagem"
        Me.Foto.Name = "Foto"
        Me.Foto.ReadOnly = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.dgvConsultaProduto)
        Me.Controls.Add(Me.antBug)
        Me.Controls.Add(Me.ListNotifica)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_TelaInicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.btnP_Sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PicNotfic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnGerProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGerFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGerFornec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRelato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGerUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGerCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsultaProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnP_Sair As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label_Data As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PicNotfic As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ListNotifica As System.Windows.Forms.ListView
    Friend WithEvents colNotfica As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnGerCliente As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGerUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents btnVenda As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRelato As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnGerFornec As System.Windows.Forms.PictureBox
    Friend WithEvents btnGerProd As System.Windows.Forms.PictureBox
    Friend WithEvents btnGerFunc As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents antBug As System.Windows.Forms.Button
    Friend WithEvents dgvConsultaProduto As System.Windows.Forms.DataGridView
    Friend WithEvents FotosProdutos As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Cod_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Custo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantMinima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Foto As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
