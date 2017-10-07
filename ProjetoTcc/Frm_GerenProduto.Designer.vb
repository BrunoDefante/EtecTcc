<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GerenProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenProduto))
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TP_usuario = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.dgvConsultaProduto = New System.Windows.Forms.DataGridView()
        Me.FotosProdutos = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cod_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Custo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantMinima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodFornec = New System.Windows.Forms.TextBox()
        Me.btnConsFornec = New System.Windows.Forms.Button()
        Me.NumQuantiMini = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PicPreImagem = New System.Windows.Forms.PictureBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btn_EnviarFoto = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtUrlFoto = New System.Windows.Forms.TextBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.NumQuanti = New System.Windows.Forms.NumericUpDown()
        Me.txtCusto = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerNotificacao = New System.Windows.Forms.Timer(Me.components)
        Me.TP_usuario.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvConsultaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumQuantiMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicPreImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumQuanti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TP_usuario
        '
        Me.TP_usuario.Controls.Add(Me.TabPage1)
        Me.TP_usuario.Controls.Add(Me.TabPage2)
        Me.TP_usuario.Location = New System.Drawing.Point(13, 7)
        Me.TP_usuario.Name = "TP_usuario"
        Me.TP_usuario.Padding = New System.Drawing.Point(190, 10)
        Me.TP_usuario.SelectedIndex = 0
        Me.TP_usuario.Size = New System.Drawing.Size(857, 485)
        Me.TP_usuario.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_Consultar)
        Me.TabPage1.Controls.Add(Me.btnVoltar)
        Me.TabPage1.Controls.Add(Me.dgvConsultaProduto)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(849, 445)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Produtos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultar.Image = CType(resources.GetObject("btn_Consultar.Image"), System.Drawing.Image)
        Me.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Consultar.Location = New System.Drawing.Point(638, 380)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(205, 59)
        Me.btn_Consultar.TabIndex = 7
        Me.btn_Consultar.Text = "Consulta Avançada"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoltar.Location = New System.Drawing.Point(6, 380)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(106, 62)
        Me.btnVoltar.TabIndex = 6
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'dgvConsultaProduto
        '
        Me.dgvConsultaProduto.AllowUserToAddRows = False
        Me.dgvConsultaProduto.AllowUserToDeleteRows = False
        Me.dgvConsultaProduto.AllowUserToResizeColumns = False
        Me.dgvConsultaProduto.AllowUserToResizeRows = False
        Me.dgvConsultaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FotosProdutos, Me.Cod_Produto, Me.Nome_Produto, Me.Tipo_Produto, Me.Custo, Me.Quantidade, Me.QuantMinima, Me.Foto})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsultaProduto.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvConsultaProduto.Location = New System.Drawing.Point(0, 48)
        Me.dgvConsultaProduto.MultiSelect = False
        Me.dgvConsultaProduto.Name = "dgvConsultaProduto"
        Me.dgvConsultaProduto.ReadOnly = True
        Me.dgvConsultaProduto.RowTemplate.Height = 50
        Me.dgvConsultaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaProduto.Size = New System.Drawing.Size(849, 326)
        Me.dgvConsultaProduto.TabIndex = 1
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
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Custo.DefaultCellStyle = DataGridViewCellStyle9
        Me.Custo.HeaderText = "Custo"
        Me.Custo.Name = "Custo"
        Me.Custo.ReadOnly = True
        '
        'Quantidade
        '
        Me.Quantidade.DataPropertyName = "Quantidade"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Quantidade.DefaultCellStyle = DataGridViewCellStyle10
        Me.Quantidade.HeaderText = "Quantidade em Estoque"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        '
        'QuantMinima
        '
        Me.QuantMinima.DataPropertyName = "QuantMinima"
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Red
        Me.QuantMinima.DefaultCellStyle = DataGridViewCellStyle11
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta de Produtos"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(849, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastrar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(270, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(318, 31)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cadastro de Produtos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtCodFornec)
        Me.GroupBox1.Controls.Add(Me.btnConsFornec)
        Me.GroupBox1.Controls.Add(Me.NumQuantiMini)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Controls.Add(Me.btn_EnviarFoto)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.txtUrlFoto)
        Me.GroupBox1.Controls.Add(Me.btnCadastrar)
        Me.GroupBox1.Controls.Add(Me.NumQuanti)
        Me.GroupBox1.Controls.Add(Me.txtCusto)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 374)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtCodFornec
        '
        Me.txtCodFornec.Location = New System.Drawing.Point(21, 113)
        Me.txtCodFornec.Name = "txtCodFornec"
        Me.txtCodFornec.ReadOnly = True
        Me.txtCodFornec.Size = New System.Drawing.Size(91, 23)
        Me.txtCodFornec.TabIndex = 51
        Me.txtCodFornec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnConsFornec
        '
        Me.btnConsFornec.Enabled = False
        Me.btnConsFornec.Image = CType(resources.GetObject("btnConsFornec.Image"), System.Drawing.Image)
        Me.btnConsFornec.Location = New System.Drawing.Point(118, 109)
        Me.btnConsFornec.Name = "btnConsFornec"
        Me.btnConsFornec.Size = New System.Drawing.Size(51, 27)
        Me.btnConsFornec.TabIndex = 50
        Me.btnConsFornec.UseVisualStyleBackColor = True
        '
        'NumQuantiMini
        '
        Me.NumQuantiMini.Enabled = False
        Me.NumQuantiMini.Location = New System.Drawing.Point(21, 178)
        Me.NumQuantiMini.Maximum = New Decimal(New Integer() {49, 0, 0, 0})
        Me.NumQuantiMini.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumQuantiMini.Name = "NumQuantiMini"
        Me.NumQuantiMini.Size = New System.Drawing.Size(170, 23)
        Me.NumQuantiMini.TabIndex = 49
        Me.NumQuantiMini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumQuantiMini.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 17)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Quantidade Mínima:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Gainsboro
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(129, 282)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(527, 25)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = " Campos Com (*) São de Preenchimento Obrigatório."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "*Código do Fornecedor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicPreImagem)
        Me.GroupBox2.Location = New System.Drawing.Point(622, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 145)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pré-Visualização"
        '
        'PicPreImagem
        '
        Me.PicPreImagem.Enabled = False
        Me.PicPreImagem.Location = New System.Drawing.Point(6, 19)
        Me.PicPreImagem.Name = "PicPreImagem"
        Me.PicPreImagem.Size = New System.Drawing.Size(201, 120)
        Me.PicPreImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPreImagem.TabIndex = 0
        Me.PicPreImagem.TabStop = False
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(69, 318)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(100, 50)
        Me.btnNovo.TabIndex = 22
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btn_EnviarFoto
        '
        Me.btn_EnviarFoto.Enabled = False
        Me.btn_EnviarFoto.Image = CType(resources.GetObject("btn_EnviarFoto.Image"), System.Drawing.Image)
        Me.btn_EnviarFoto.Location = New System.Drawing.Point(494, 227)
        Me.btn_EnviarFoto.Name = "btn_EnviarFoto"
        Me.btn_EnviarFoto.Size = New System.Drawing.Size(88, 46)
        Me.btn_EnviarFoto.TabIndex = 13
        Me.btn_EnviarFoto.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(632, 318)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(126, 50)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtUrlFoto
        '
        Me.txtUrlFoto.Enabled = False
        Me.txtUrlFoto.Location = New System.Drawing.Point(210, 242)
        Me.txtUrlFoto.Name = "txtUrlFoto"
        Me.txtUrlFoto.Size = New System.Drawing.Size(278, 23)
        Me.txtUrlFoto.TabIndex = 12
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Enabled = False
        Me.btnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Image = CType(resources.GetObject("btnCadastrar.Image"), System.Drawing.Image)
        Me.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastrar.Location = New System.Drawing.Point(360, 318)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(113, 50)
        Me.btnCadastrar.TabIndex = 20
        Me.btnCadastrar.Text = "Gravar"
        Me.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'NumQuanti
        '
        Me.NumQuanti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumQuanti.Enabled = False
        Me.NumQuanti.Location = New System.Drawing.Point(270, 178)
        Me.NumQuanti.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumQuanti.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumQuanti.Name = "NumQuanti"
        Me.NumQuanti.Size = New System.Drawing.Size(191, 23)
        Me.NumQuanti.TabIndex = 11
        Me.NumQuanti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumQuanti.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'txtCusto
        '
        Me.txtCusto.Enabled = False
        Me.txtCusto.Location = New System.Drawing.Point(270, 112)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(122, 23)
        Me.txtCusto.TabIndex = 10
        Me.txtCusto.Text = "0,00"
        Me.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(468, 31)
        Me.txtDescricao.MaxLength = 140
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(337, 102)
        Me.txtDescricao.TabIndex = 9
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(270, 32)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(176, 23)
        Me.txtTipo.TabIndex = 8
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(19, 32)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(229, 23)
        Me.txtNome.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(207, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "*Foto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(266, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "*Quantidade à ser Inserida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "*Custo (R$):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(465, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "*Descrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "*Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "*Nome:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TimerNotificacao
        '
        Me.TimerNotificacao.Enabled = True
        Me.TimerNotificacao.Interval = 1000
        '
        'Frm_GerenProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 499)
        Me.Controls.Add(Me.TP_usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_GerenProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Produtos"
        Me.TP_usuario.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvConsultaProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumQuantiMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicPreImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumQuanti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TP_usuario As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents dgvConsultaProduto As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NumQuanti As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_EnviarFoto As System.Windows.Forms.Button
    Friend WithEvents txtUrlFoto As System.Windows.Forms.TextBox
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PicPreImagem As System.Windows.Forms.PictureBox
    Friend WithEvents txtCusto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TimerNotificacao As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NumQuantiMini As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnConsFornec As System.Windows.Forms.Button
    Friend WithEvents txtCodFornec As System.Windows.Forms.TextBox
    Friend WithEvents FotosProdutos As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Cod_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Custo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantMinima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Foto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
