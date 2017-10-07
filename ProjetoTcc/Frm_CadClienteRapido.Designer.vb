<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadClienteRapido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadClienteRapido))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Cadastrar = New System.Windows.Forms.Button()
        Me.btn_Novo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.groupTel.SuspendLayout()
        Me.groupCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 468)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.Panel2.Controls.Add(Me.btn_Cadastrar)
        Me.Panel2.Controls.Add(Me.btn_Novo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.mskNum)
        Me.Panel2.Controls.Add(Me.Label38)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.mskCnpj)
        Me.Panel2.Controls.Add(Me.mskCEP)
        Me.Panel2.Controls.Add(Me.mskCpf)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.txtUf)
        Me.Panel2.Controls.Add(Me.txtBairro)
        Me.Panel2.Controls.Add(Me.txtCidade)
        Me.Panel2.Controls.Add(Me.txtEndereco)
        Me.Panel2.Controls.Add(Me.mskDtNasc)
        Me.Panel2.Controls.Add(Me.txtNome)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.groupTel)
        Me.Panel2.Controls.Add(Me.groupCliente)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 442)
        Me.Panel2.TabIndex = 0
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.Location = New System.Drawing.Point(601, 374)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(121, 52)
        Me.btn_Cancelar.TabIndex = 79
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
        Me.btn_Cadastrar.Location = New System.Drawing.Point(388, 374)
        Me.btn_Cadastrar.Name = "btn_Cadastrar"
        Me.btn_Cadastrar.Size = New System.Drawing.Size(111, 53)
        Me.btn_Cadastrar.TabIndex = 78
        Me.btn_Cadastrar.Text = "Gravar"
        Me.btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'btn_Novo
        '
        Me.btn_Novo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btn_Novo.Image = CType(resources.GetObject("btn_Novo.Image"), System.Drawing.Image)
        Me.btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Novo.Location = New System.Drawing.Point(165, 374)
        Me.btn_Novo.Name = "btn_Novo"
        Me.btn_Novo.Size = New System.Drawing.Size(104, 53)
        Me.btn_Novo.TabIndex = 77
        Me.btn_Novo.Text = "Novo"
        Me.btn_Novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Novo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 31)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Cadastro de Clientes"
        '
        'mskNum
        '
        Me.mskNum.Enabled = False
        Me.mskNum.Location = New System.Drawing.Point(297, 126)
        Me.mskNum.Mask = "00000"
        Me.mskNum.Name = "mskNum"
        Me.mskNum.Size = New System.Drawing.Size(43, 21)
        Me.mskNum.TabIndex = 65
        Me.mskNum.ValidatingType = GetType(Integer)
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(294, 110)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(29, 16)
        Me.Label38.TabIndex = 73
        Me.Label38.Text = "*Nº:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(169, 338)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(579, 25)
        Me.Label25.TabIndex = 72
        Me.Label25.Text = " Campos Com (*) São de Preenchimento Obrigatório."
        '
        'mskCnpj
        '
        Me.mskCnpj.Enabled = False
        Me.mskCnpj.Location = New System.Drawing.Point(297, 284)
        Me.mskCnpj.Mask = "00,000,000/0000-00"
        Me.mskCnpj.Name = "mskCnpj"
        Me.mskCnpj.Size = New System.Drawing.Size(117, 21)
        Me.mskCnpj.TabIndex = 75
        '
        'mskCEP
        '
        Me.mskCEP.Enabled = False
        Me.mskCEP.Location = New System.Drawing.Point(56, 226)
        Me.mskCEP.Mask = "00000-999"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.Size = New System.Drawing.Size(88, 21)
        Me.mskCEP.TabIndex = 69
        Me.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskCpf
        '
        Me.mskCpf.Enabled = False
        Me.mskCpf.Location = New System.Drawing.Point(297, 229)
        Me.mskCpf.Mask = "000,000,000-00"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(100, 21)
        Me.mskCpf.TabIndex = 70
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(56, 279)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(179, 21)
        Me.txtEmail.TabIndex = 74
        '
        'txtUf
        '
        Me.txtUf.Enabled = False
        Me.txtUf.Location = New System.Drawing.Point(788, 126)
        Me.txtUf.MaxLength = 2
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(31, 21)
        Me.txtUf.TabIndex = 68
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(623, 126)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(113, 21)
        Me.txtBairro.TabIndex = 67
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(428, 126)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(111, 21)
        Me.txtCidade.TabIndex = 66
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(56, 126)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(173, 21)
        Me.txtEndereco.TabIndex = 64
        '
        'mskDtNasc
        '
        Me.mskDtNasc.Enabled = False
        Me.mskDtNasc.Location = New System.Drawing.Point(297, 76)
        Me.mskDtNasc.Mask = "00/00/0000"
        Me.mskDtNasc.Name = "mskDtNasc"
        Me.mskDtNasc.Size = New System.Drawing.Size(111, 21)
        Me.mskDtNasc.TabIndex = 63
        Me.mskDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(56, 74)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(173, 21)
        Me.txtNome.TabIndex = 62
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(294, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = " *C.N.P.J:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(294, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 16)
        Me.Label14.TabIndex = 60
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
        Me.groupTel.Location = New System.Drawing.Point(492, 210)
        Me.groupTel.Name = "groupTel"
        Me.groupTel.Size = New System.Drawing.Size(360, 86)
        Me.groupTel.TabIndex = 71
        Me.groupTel.TabStop = False
        Me.groupTel.Text = "Telefones:"
        '
        'mskCel2
        '
        Me.mskCel2.Location = New System.Drawing.Point(238, 49)
        Me.mskCel2.Mask = "(99) 00000-0000"
        Me.mskCel2.Name = "mskCel2"
        Me.mskCel2.Size = New System.Drawing.Size(100, 21)
        Me.mskCel2.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(178, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = " Celular 2:"
        '
        'mskTelFixo2
        '
        Me.mskTelFixo2.Location = New System.Drawing.Point(238, 9)
        Me.mskTelFixo2.Mask = "(99) 0000-0000"
        Me.mskTelFixo2.Name = "mskTelFixo2"
        Me.mskTelFixo2.Size = New System.Drawing.Size(100, 21)
        Me.mskTelFixo2.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(178, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Fixo 2:"
        '
        'mskCel1
        '
        Me.mskCel1.Location = New System.Drawing.Point(66, 53)
        Me.mskCel1.Mask = "(99) 00000-0000"
        Me.mskCel1.Name = "mskCel1"
        Me.mskCel1.Size = New System.Drawing.Size(100, 21)
        Me.mskCel1.TabIndex = 47
        '
        'mskTelFixo1
        '
        Me.mskTelFixo1.Location = New System.Drawing.Point(66, 13)
        Me.mskTelFixo1.Mask = "(99) 0000-0000"
        Me.mskTelFixo1.Name = "mskTelFixo1"
        Me.mskTelFixo1.Size = New System.Drawing.Size(100, 21)
        Me.mskTelFixo1.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = " Celular:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "*Fixo:"
        '
        'groupCliente
        '
        Me.groupCliente.Controls.Add(Me.rbJuridico)
        Me.groupCliente.Controls.Add(Me.rbFisico)
        Me.groupCliente.Enabled = False
        Me.groupCliente.Location = New System.Drawing.Point(492, 58)
        Me.groupCliente.Name = "groupCliente"
        Me.groupCliente.Size = New System.Drawing.Size(239, 44)
        Me.groupCliente.TabIndex = 59
        Me.groupCliente.TabStop = False
        Me.groupCliente.Text = "*Tipo de Cliente"
        '
        'rbJuridico
        '
        Me.rbJuridico.AutoSize = True
        Me.rbJuridico.Location = New System.Drawing.Point(137, 18)
        Me.rbJuridico.Name = "rbJuridico"
        Me.rbJuridico.Size = New System.Drawing.Size(67, 20)
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
        Me.rbFisico.Size = New System.Drawing.Size(53, 20)
        Me.rbFisico.TabIndex = 0
        Me.rbFisico.TabStop = True
        Me.rbFisico.Text = "Físico"
        Me.rbFisico.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = " e-Mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = " *CEP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(788, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = " *UF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(620, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = " *Bairro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(425, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = " *Cidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = " *Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = " *Data de Nascimento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = " *Nome:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Frm_CadClienteRapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_CadClienteRapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_CadClienteRapido"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.groupTel.ResumeLayout(False)
        Me.groupTel.PerformLayout()
        Me.groupCliente.ResumeLayout(False)
        Me.groupCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents mskNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Cadastrar As System.Windows.Forms.Button
    Friend WithEvents btn_Novo As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
