<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GerenCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenCliente))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TP_cliente = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.dgvConsultaCliente = New System.Windows.Forms.DataGridView()
        Me.Cod_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cnpj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dt_Nasc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel_Fixo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Cadastrar = New System.Windows.Forms.Button()
        Me.btn_Novo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.mskNum = New System.Windows.Forms.MaskedTextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.mskCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.mskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.mskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.mskDtNasc = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.groupTel = New System.Windows.Forms.GroupBox()
        Me.mskCel2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mskTelFixo2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mskCel1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskTelFixo1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.groupCliente = New System.Windows.Forms.GroupBox()
        Me.rbJuridico = New System.Windows.Forms.RadioButton()
        Me.rbFisico = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TP_cliente.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvConsultaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.groupTel.SuspendLayout()
        Me.groupCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'TP_cliente
        '
        Me.TP_cliente.Controls.Add(Me.TabPage1)
        Me.TP_cliente.Controls.Add(Me.TabPage2)
        Me.TP_cliente.Location = New System.Drawing.Point(12, 12)
        Me.TP_cliente.Name = "TP_cliente"
        Me.TP_cliente.Padding = New System.Drawing.Point(192, 10)
        Me.TP_cliente.SelectedIndex = 0
        Me.TP_cliente.Size = New System.Drawing.Size(857, 485)
        Me.TP_cliente.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnVoltar)
        Me.TabPage1.Controls.Add(Me.btn_Consultar)
        Me.TabPage1.Controls.Add(Me.dgvConsultaCliente)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(849, 445)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoltar.Location = New System.Drawing.Point(6, 383)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(105, 59)
        Me.btnVoltar.TabIndex = 6
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultar.Image = CType(resources.GetObject("btn_Consultar.Image"), System.Drawing.Image)
        Me.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Consultar.Location = New System.Drawing.Point(649, 383)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(197, 59)
        Me.btn_Consultar.TabIndex = 4
        Me.btn_Consultar.Text = "Consulta Avançada"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'dgvConsultaCliente
        '
        Me.dgvConsultaCliente.AllowUserToAddRows = False
        Me.dgvConsultaCliente.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvConsultaCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConsultaCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_Cliente, Me.Nome, Me.Cpf, Me.Cnpj, Me.Dt_Nasc, Me.Tel_Fixo})
        Me.dgvConsultaCliente.Location = New System.Drawing.Point(0, 48)
        Me.dgvConsultaCliente.Name = "dgvConsultaCliente"
        Me.dgvConsultaCliente.ReadOnly = True
        Me.dgvConsultaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaCliente.Size = New System.Drawing.Size(849, 326)
        Me.dgvConsultaCliente.TabIndex = 1
        '
        'Cod_Cliente
        '
        Me.Cod_Cliente.DataPropertyName = "Cod_Cliente"
        Me.Cod_Cliente.HeaderText = "Codigo Cliente"
        Me.Cod_Cliente.Name = "Cod_Cliente"
        Me.Cod_Cliente.ReadOnly = True
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Cpf
        '
        Me.Cpf.DataPropertyName = "Cpf"
        Me.Cpf.HeaderText = "C.P.F"
        Me.Cpf.Name = "Cpf"
        Me.Cpf.ReadOnly = True
        '
        'Cnpj
        '
        Me.Cnpj.DataPropertyName = "Cnpj"
        Me.Cnpj.HeaderText = "C.N.P.J"
        Me.Cnpj.Name = "Cnpj"
        Me.Cnpj.ReadOnly = True
        '
        'Dt_Nasc
        '
        Me.Dt_Nasc.DataPropertyName = "Dt_Nasc"
        Me.Dt_Nasc.HeaderText = "Data de Nascimento"
        Me.Dt_Nasc.Name = "Dt_Nasc"
        Me.Dt_Nasc.ReadOnly = True
        '
        'Tel_Fixo
        '
        Me.Tel_Fixo.DataPropertyName = "Tel_Fixo"
        Me.Tel_Fixo.HeaderText = "Telefone Fixo"
        Me.Tel_Fixo.Name = "Tel_Fixo"
        Me.Tel_Fixo.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Consulta de Clientes"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_Cancelar)
        Me.TabPage2.Controls.Add(Me.btn_Cadastrar)
        Me.TabPage2.Controls.Add(Me.btn_Novo)
        Me.TabPage2.Controls.Add(Me.TabControl1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(849, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastro"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.Location = New System.Drawing.Point(609, 396)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(121, 52)
        Me.btn_Cancelar.TabIndex = 3
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Cadastrar
        '
        Me.btn_Cadastrar.Enabled = False
        Me.btn_Cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cadastrar.Image = CType(resources.GetObject("btn_Cadastrar.Image"), System.Drawing.Image)
        Me.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cadastrar.Location = New System.Drawing.Point(396, 396)
        Me.btn_Cadastrar.Name = "btn_Cadastrar"
        Me.btn_Cadastrar.Size = New System.Drawing.Size(111, 53)
        Me.btn_Cadastrar.TabIndex = 2
        Me.btn_Cadastrar.Text = "Gravar"
        Me.btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'btn_Novo
        '
        Me.btn_Novo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btn_Novo.Image = CType(resources.GetObject("btn_Novo.Image"), System.Drawing.Image)
        Me.btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Novo.Location = New System.Drawing.Point(173, 396)
        Me.btn_Novo.Name = "btn_Novo"
        Me.btn_Novo.Size = New System.Drawing.Size(104, 53)
        Me.btn_Novo.TabIndex = 1
        Me.btn_Novo.Text = "Novo"
        Me.btn_Novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Novo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(380, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(843, 390)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.mskNum)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.mskCnpj)
        Me.TabPage3.Controls.Add(Me.mskCEP)
        Me.TabPage3.Controls.Add(Me.mskCpf)
        Me.TabPage3.Controls.Add(Me.txtEmail)
        Me.TabPage3.Controls.Add(Me.txtUf)
        Me.TabPage3.Controls.Add(Me.txtBairro)
        Me.TabPage3.Controls.Add(Me.txtCidade)
        Me.TabPage3.Controls.Add(Me.txtEndereco)
        Me.TabPage3.Controls.Add(Me.mskDtNasc)
        Me.TabPage3.Controls.Add(Me.txtNome)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.groupTel)
        Me.TabPage3.Controls.Add(Me.groupCliente)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(835, 364)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Dados Pessoais"
        '
        'mskNum
        '
        Me.mskNum.Enabled = False
        Me.mskNum.Location = New System.Drawing.Point(258, 100)
        Me.mskNum.Mask = "00000"
        Me.mskNum.Name = "mskNum"
        Me.mskNum.Size = New System.Drawing.Size(43, 20)
        Me.mskNum.TabIndex = 38
        Me.mskNum.ValidatingType = GetType(Integer)
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(255, 84)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(26, 13)
        Me.Label38.TabIndex = 46
        Me.Label38.Text = "*Nº:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(144, 336)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(579, 25)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = " Campos Com (*) São de Preenchimento Obrigatório."
        '
        'mskCnpj
        '
        Me.mskCnpj.Enabled = False
        Me.mskCnpj.Location = New System.Drawing.Point(258, 258)
        Me.mskCnpj.Mask = "00,000,000/0000-00"
        Me.mskCnpj.Name = "mskCnpj"
        Me.mskCnpj.Size = New System.Drawing.Size(117, 20)
        Me.mskCnpj.TabIndex = 50
        '
        'mskCEP
        '
        Me.mskCEP.Enabled = False
        Me.mskCEP.Location = New System.Drawing.Point(17, 200)
        Me.mskCEP.Mask = "00000-999"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.Size = New System.Drawing.Size(88, 20)
        Me.mskCEP.TabIndex = 42
        Me.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskCpf
        '
        Me.mskCpf.Enabled = False
        Me.mskCpf.Location = New System.Drawing.Point(258, 203)
        Me.mskCpf.Mask = "000,000,000-00"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(100, 20)
        Me.mskCpf.TabIndex = 43
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(17, 253)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(179, 20)
        Me.txtEmail.TabIndex = 49
        '
        'txtUf
        '
        Me.txtUf.Enabled = False
        Me.txtUf.Location = New System.Drawing.Point(749, 100)
        Me.txtUf.MaxLength = 2
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(31, 20)
        Me.txtUf.TabIndex = 41
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(584, 100)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(113, 20)
        Me.txtBairro.TabIndex = 40
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(389, 100)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(111, 20)
        Me.txtCidade.TabIndex = 39
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(17, 100)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(173, 20)
        Me.txtEndereco.TabIndex = 37
        '
        'mskDtNasc
        '
        Me.mskDtNasc.Enabled = False
        Me.mskDtNasc.Location = New System.Drawing.Point(258, 50)
        Me.mskDtNasc.Mask = "00/00/0000"
        Me.mskDtNasc.Name = "mskDtNasc"
        Me.mskDtNasc.Size = New System.Drawing.Size(111, 20)
        Me.mskDtNasc.TabIndex = 36
        Me.mskDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(17, 48)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(173, 20)
        Me.txtNome.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(255, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = " *C.N.P.J:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(255, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "*C.P.F:"
        '
        'groupTel
        '
        Me.groupTel.Controls.Add(Me.mskCel2)
        Me.groupTel.Controls.Add(Me.Label13)
        Me.groupTel.Controls.Add(Me.mskTelFixo2)
        Me.groupTel.Controls.Add(Me.Label12)
        Me.groupTel.Controls.Add(Me.mskCel1)
        Me.groupTel.Controls.Add(Me.mskTelFixo1)
        Me.groupTel.Controls.Add(Me.Label11)
        Me.groupTel.Controls.Add(Me.Label10)
        Me.groupTel.Enabled = False
        Me.groupTel.Location = New System.Drawing.Point(453, 184)
        Me.groupTel.Name = "groupTel"
        Me.groupTel.Size = New System.Drawing.Size(360, 86)
        Me.groupTel.TabIndex = 44
        Me.groupTel.TabStop = False
        Me.groupTel.Text = "Telefones:"
        '
        'mskCel2
        '
        Me.mskCel2.Location = New System.Drawing.Point(238, 49)
        Me.mskCel2.Mask = "(99) 00000-0000"
        Me.mskCel2.Name = "mskCel2"
        Me.mskCel2.Size = New System.Drawing.Size(100, 20)
        Me.mskCel2.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(178, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = " Celular 2:"
        '
        'mskTelFixo2
        '
        Me.mskTelFixo2.Location = New System.Drawing.Point(238, 9)
        Me.mskTelFixo2.Mask = "(99) 0000-0000"
        Me.mskTelFixo2.Name = "mskTelFixo2"
        Me.mskTelFixo2.Size = New System.Drawing.Size(100, 20)
        Me.mskTelFixo2.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(178, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Fixo 2:"
        '
        'mskCel1
        '
        Me.mskCel1.Location = New System.Drawing.Point(66, 53)
        Me.mskCel1.Mask = "(99) 00000-0000"
        Me.mskCel1.Name = "mskCel1"
        Me.mskCel1.Size = New System.Drawing.Size(100, 20)
        Me.mskCel1.TabIndex = 47
        '
        'mskTelFixo1
        '
        Me.mskTelFixo1.Location = New System.Drawing.Point(66, 13)
        Me.mskTelFixo1.Mask = "(99) 0000-0000"
        Me.mskTelFixo1.Name = "mskTelFixo1"
        Me.mskTelFixo1.Size = New System.Drawing.Size(100, 20)
        Me.mskTelFixo1.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = " Celular:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "*Fixo:"
        '
        'groupCliente
        '
        Me.groupCliente.Controls.Add(Me.rbJuridico)
        Me.groupCliente.Controls.Add(Me.rbFisico)
        Me.groupCliente.Enabled = False
        Me.groupCliente.Location = New System.Drawing.Point(453, 32)
        Me.groupCliente.Name = "groupCliente"
        Me.groupCliente.Size = New System.Drawing.Size(239, 44)
        Me.groupCliente.TabIndex = 31
        Me.groupCliente.TabStop = False
        Me.groupCliente.Text = "*Tipo de Cliente"
        '
        'rbJuridico
        '
        Me.rbJuridico.AutoSize = True
        Me.rbJuridico.Location = New System.Drawing.Point(137, 18)
        Me.rbJuridico.Name = "rbJuridico"
        Me.rbJuridico.Size = New System.Drawing.Size(63, 17)
        Me.rbJuridico.TabIndex = 1
        Me.rbJuridico.TabStop = True
        Me.rbJuridico.Text = "Jurídico"
        Me.rbJuridico.UseVisualStyleBackColor = True
        '
        'rbFisico
        '
        Me.rbFisico.AutoSize = True
        Me.rbFisico.Location = New System.Drawing.Point(6, 18)
        Me.rbFisico.Name = "rbFisico"
        Me.rbFisico.Size = New System.Drawing.Size(54, 17)
        Me.rbFisico.TabIndex = 0
        Me.rbFisico.TabStop = True
        Me.rbFisico.Text = "Físico"
        Me.rbFisico.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = " e-Mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = " *CEP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(749, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = " *UF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(581, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = " *Bairro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = " *Cidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = " *Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = " *Data de Nascimento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = " *Nome:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Frm_GerenCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 499)
        Me.Controls.Add(Me.TP_cliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Frm_GerenCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TP_cliente.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvConsultaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.groupTel.ResumeLayout(False)
        Me.groupTel.PerformLayout()
        Me.groupCliente.ResumeLayout(False)
        Me.groupCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TP_cliente As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvConsultaCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents mskCnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtUf As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents mskDtNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents groupTel As System.Windows.Forms.GroupBox
    Friend WithEvents mskCel2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mskTelFixo2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mskCel1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTelFixo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents groupCliente As System.Windows.Forms.GroupBox
    Friend WithEvents rbJuridico As System.Windows.Forms.RadioButton
    Friend WithEvents rbFisico As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Cadastrar As System.Windows.Forms.Button
    Friend WithEvents btn_Novo As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents mskNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Cod_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cpf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cnpj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dt_Nasc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel_Fixo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
