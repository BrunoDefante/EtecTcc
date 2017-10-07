<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EditCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EditCliente))
        Me.Label_Titulo = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_VCancelar = New System.Windows.Forms.Button()
        Me.btn_Excluir = New System.Windows.Forms.Button()
        Me.groupTel.SuspendLayout()
        Me.groupCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Titulo
        '
        Me.Label_Titulo.AutoSize = True
        Me.Label_Titulo.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titulo.Location = New System.Drawing.Point(279, 9)
        Me.Label_Titulo.Name = "Label_Titulo"
        Me.Label_Titulo.Size = New System.Drawing.Size(377, 27)
        Me.Label_Titulo.TabIndex = 0
        Me.Label_Titulo.Text = "Consulta Avançada de Cliente"
        '
        'mskNum
        '
        Me.mskNum.Enabled = False
        Me.mskNum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mskNum.Location = New System.Drawing.Point(277, 116)
        Me.mskNum.Mask = "00000"
        Me.mskNum.Name = "mskNum"
        Me.mskNum.Size = New System.Drawing.Size(43, 20)
        Me.mskNum.TabIndex = 72
        Me.mskNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskNum.ValidatingType = GetType(Integer)
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(274, 100)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(26, 13)
        Me.Label38.TabIndex = 71
        Me.Label38.Text = "*Nº:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(160, 362)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(579, 25)
        Me.Label25.TabIndex = 70
        Me.Label25.Text = " Campos Com (*) São de Preenchimento Obrigatório."
        '
        'mskCnpj
        '
        Me.mskCnpj.Enabled = False
        Me.mskCnpj.Location = New System.Drawing.Point(271, 269)
        Me.mskCnpj.Mask = "00,000,000/0000-00"
        Me.mskCnpj.Name = "mskCnpj"
        Me.mskCnpj.Size = New System.Drawing.Size(117, 20)
        Me.mskCnpj.TabIndex = 69
        '
        'mskCEP
        '
        Me.mskCEP.Enabled = False
        Me.mskCEP.Location = New System.Drawing.Point(36, 216)
        Me.mskCEP.Mask = "00000-999"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.Size = New System.Drawing.Size(88, 20)
        Me.mskCEP.TabIndex = 68
        Me.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskCpf
        '
        Me.mskCpf.Enabled = False
        Me.mskCpf.Location = New System.Drawing.Point(277, 219)
        Me.mskCpf.Mask = "000,000,000-00"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(100, 20)
        Me.mskCpf.TabIndex = 67
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(36, 269)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(179, 20)
        Me.txtEmail.TabIndex = 66
        '
        'txtUf
        '
        Me.txtUf.Enabled = False
        Me.txtUf.Location = New System.Drawing.Point(768, 116)
        Me.txtUf.MaxLength = 2
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(31, 20)
        Me.txtUf.TabIndex = 65
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(603, 116)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(113, 20)
        Me.txtBairro.TabIndex = 64
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(408, 116)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(111, 20)
        Me.txtCidade.TabIndex = 63
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(36, 116)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(173, 20)
        Me.txtEndereco.TabIndex = 62
        '
        'mskDtNasc
        '
        Me.mskDtNasc.Enabled = False
        Me.mskDtNasc.Location = New System.Drawing.Point(277, 66)
        Me.mskDtNasc.Mask = "00/00/0000"
        Me.mskDtNasc.Name = "mskDtNasc"
        Me.mskDtNasc.Size = New System.Drawing.Size(111, 20)
        Me.mskDtNasc.TabIndex = 61
        Me.mskDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(36, 64)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(173, 20)
        Me.txtNome.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(274, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = " *C.N.P.J:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(274, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 58
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
        Me.groupTel.Location = New System.Drawing.Point(472, 200)
        Me.groupTel.Name = "groupTel"
        Me.groupTel.Size = New System.Drawing.Size(360, 86)
        Me.groupTel.TabIndex = 57
        Me.groupTel.TabStop = False
        Me.groupTel.Text = "Telefones:"
        '
        'mskCel2
        '
        Me.mskCel2.Location = New System.Drawing.Point(238, 49)
        Me.mskCel2.Mask = "(99) 00000-0000"
        Me.mskCel2.Name = "mskCel2"
        Me.mskCel2.Size = New System.Drawing.Size(100, 20)
        Me.mskCel2.TabIndex = 7
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
        Me.mskTelFixo2.TabIndex = 5
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
        Me.mskCel1.TabIndex = 3
        '
        'mskTelFixo1
        '
        Me.mskTelFixo1.Location = New System.Drawing.Point(66, 13)
        Me.mskTelFixo1.Mask = "(99) 0000-0000"
        Me.mskTelFixo1.Name = "mskTelFixo1"
        Me.mskTelFixo1.Size = New System.Drawing.Size(100, 20)
        Me.mskTelFixo1.TabIndex = 2
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
        Me.groupCliente.Location = New System.Drawing.Point(472, 48)
        Me.groupCliente.Name = "groupCliente"
        Me.groupCliente.Size = New System.Drawing.Size(239, 44)
        Me.groupCliente.TabIndex = 56
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
        Me.rbFisico.Text = "Físico"
        Me.rbFisico.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = " e-Mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = " *CEP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(768, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = " *UF:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(600, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = " *Bairro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(405, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = " *Cidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = " *Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = " *Data de Nascimento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = " *Nome:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.groupCliente)
        Me.GroupBox1.Controls.Add(Me.mskNum)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mskCnpj)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mskCEP)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mskCpf)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtUf)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.groupTel)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.mskDtNasc)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(841, 400)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Pessoais"
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Editar.Location = New System.Drawing.Point(68, 439)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(111, 56)
        Me.btn_Editar.TabIndex = 73
        Me.btn_Editar.Text = "Editar"
        Me.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_VCancelar
        '
        Me.btn_VCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_VCancelar.Image = CType(resources.GetObject("btn_VCancelar.Image"), System.Drawing.Image)
        Me.btn_VCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_VCancelar.Location = New System.Drawing.Point(696, 439)
        Me.btn_VCancelar.Name = "btn_VCancelar"
        Me.btn_VCancelar.Size = New System.Drawing.Size(115, 56)
        Me.btn_VCancelar.TabIndex = 75
        Me.btn_VCancelar.Text = "Voltar"
        Me.btn_VCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_VCancelar.UseVisualStyleBackColor = True
        '
        'btn_Excluir
        '
        Me.btn_Excluir.Enabled = False
        Me.btn_Excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Excluir.Image = CType(resources.GetObject("btn_Excluir.Image"), System.Drawing.Image)
        Me.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Excluir.Location = New System.Drawing.Point(376, 439)
        Me.btn_Excluir.Name = "btn_Excluir"
        Me.btn_Excluir.Size = New System.Drawing.Size(123, 56)
        Me.btn_Excluir.TabIndex = 76
        Me.btn_Excluir.Text = "Excluir"
        Me.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Excluir.UseVisualStyleBackColor = True
        '
        'Frm_EditCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 499)
        Me.Controls.Add(Me.btn_Excluir)
        Me.Controls.Add(Me.btn_VCancelar)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_EditCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edição de Clientes"
        Me.groupTel.ResumeLayout(False)
        Me.groupTel.PerformLayout()
        Me.groupCliente.ResumeLayout(False)
        Me.groupCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Titulo As System.Windows.Forms.Label
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_VCancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Excluir As System.Windows.Forms.Button
End Class
