<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GerenUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenUsers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.dgvConsultaUsuario = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TP_usuario = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btn_EnviarFoto = New System.Windows.Forms.Button()
        Me.txtUrlImg = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.combPerfil = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfimSenha = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FotosUsers = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cod_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvConsultaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_usuario.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_Consultar)
        Me.TabPage1.Controls.Add(Me.btnVoltar)
        Me.TabPage1.Controls.Add(Me.dgvConsultaUsuario)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(849, 445)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Usuários"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Consultar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultar.Image = CType(resources.GetObject("btn_Consultar.Image"), System.Drawing.Image)
        Me.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Consultar.Location = New System.Drawing.Point(644, 383)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(199, 59)
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
        Me.btnVoltar.Location = New System.Drawing.Point(6, 383)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(104, 59)
        Me.btnVoltar.TabIndex = 6
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'dgvConsultaUsuario
        '
        Me.dgvConsultaUsuario.AllowUserToAddRows = False
        Me.dgvConsultaUsuario.AllowUserToDeleteRows = False
        Me.dgvConsultaUsuario.AllowUserToResizeColumns = False
        Me.dgvConsultaUsuario.AllowUserToResizeRows = False
        Me.dgvConsultaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FotosUsers, Me.Cod_Usuario, Me.Nome, Me.Perfil, Me.E_Mail, Me.Foto})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsultaUsuario.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConsultaUsuario.Location = New System.Drawing.Point(0, 48)
        Me.dgvConsultaUsuario.MultiSelect = False
        Me.dgvConsultaUsuario.Name = "dgvConsultaUsuario"
        Me.dgvConsultaUsuario.ReadOnly = True
        Me.dgvConsultaUsuario.RowTemplate.Height = 50
        Me.dgvConsultaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaUsuario.Size = New System.Drawing.Size(849, 326)
        Me.dgvConsultaUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta de Usuários"
        '
        'TP_usuario
        '
        Me.TP_usuario.Controls.Add(Me.TabPage1)
        Me.TP_usuario.Controls.Add(Me.TabPage2)
        Me.TP_usuario.Location = New System.Drawing.Point(12, 7)
        Me.TP_usuario.Name = "TP_usuario"
        Me.TP_usuario.Padding = New System.Drawing.Point(192, 10)
        Me.TP_usuario.SelectedIndex = 0
        Me.TP_usuario.Size = New System.Drawing.Size(857, 485)
        Me.TP_usuario.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(849, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastro"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(659, 217)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(270, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(317, 31)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cadastro de Usuários"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnCadastrar)
        Me.GroupBox1.Controls.Add(Me.btn_EnviarFoto)
        Me.GroupBox1.Controls.Add(Me.txtUrlImg)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.combPerfil)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSenha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtConfimSenha)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Location = New System.Drawing.Point(105, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 365)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(38, 307)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(104, 50)
        Me.btnNovo.TabIndex = 19
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(410, 306)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(123, 51)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Enabled = False
        Me.btnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Image = CType(resources.GetObject("btnCadastrar.Image"), System.Drawing.Image)
        Me.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastrar.Location = New System.Drawing.Point(226, 306)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(111, 53)
        Me.btnCadastrar.TabIndex = 17
        Me.btnCadastrar.Text = "Gravar"
        Me.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btn_EnviarFoto
        '
        Me.btn_EnviarFoto.Enabled = False
        Me.btn_EnviarFoto.Image = CType(resources.GetObject("btn_EnviarFoto.Image"), System.Drawing.Image)
        Me.btn_EnviarFoto.Location = New System.Drawing.Point(467, 249)
        Me.btn_EnviarFoto.Name = "btn_EnviarFoto"
        Me.btn_EnviarFoto.Size = New System.Drawing.Size(75, 49)
        Me.btn_EnviarFoto.TabIndex = 16
        Me.btn_EnviarFoto.UseVisualStyleBackColor = True
        '
        'txtUrlImg
        '
        Me.txtUrlImg.BackColor = System.Drawing.SystemColors.Info
        Me.txtUrlImg.Enabled = False
        Me.txtUrlImg.Location = New System.Drawing.Point(226, 275)
        Me.txtUrlImg.Name = "txtUrlImg"
        Me.txtUrlImg.Size = New System.Drawing.Size(232, 20)
        Me.txtUrlImg.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(82, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 23)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "*Foto:"
        '
        'combPerfil
        '
        Me.combPerfil.Enabled = False
        Me.combPerfil.FormattingEnabled = True
        Me.combPerfil.Items.AddRange(New Object() {"Administrador", "Usuário"})
        Me.combPerfil.Location = New System.Drawing.Point(226, 234)
        Me.combPerfil.Name = "combPerfil"
        Me.combPerfil.Size = New System.Drawing.Size(121, 21)
        Me.combPerfil.TabIndex = 13
        Me.combPerfil.Text = "Selecione:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(82, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = " *Perfil:"
        '
        'txtLogin
        '
        Me.txtLogin.Enabled = False
        Me.txtLogin.Location = New System.Drawing.Point(226, 62)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(232, 20)
        Me.txtLogin.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(226, 195)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(232, 20)
        Me.txtEmail.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(82, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "*Login:"
        '
        'txtSenha
        '
        Me.txtSenha.Enabled = False
        Me.txtSenha.Location = New System.Drawing.Point(226, 108)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(232, 20)
        Me.txtSenha.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(82, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "*Nome:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(82, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "*Senha:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(82, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "*Confima Senha:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(82, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "*E-mail:"
        '
        'txtConfimSenha
        '
        Me.txtConfimSenha.Enabled = False
        Me.txtConfimSenha.Location = New System.Drawing.Point(226, 151)
        Me.txtConfimSenha.Name = "txtConfimSenha"
        Me.txtConfimSenha.Size = New System.Drawing.Size(232, 20)
        Me.txtConfimSenha.TabIndex = 10
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(226, 19)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(232, 20)
        Me.txtNome.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FotosUsers
        '
        Me.FotosUsers.FillWeight = 80.0!
        Me.FotosUsers.HeaderText = "Foto"
        Me.FotosUsers.Image = CType(resources.GetObject("FotosUsers.Image"), System.Drawing.Image)
        Me.FotosUsers.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.FotosUsers.Name = "FotosUsers"
        Me.FotosUsers.ReadOnly = True
        Me.FotosUsers.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FotosUsers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FotosUsers.Visible = False
        Me.FotosUsers.Width = 50
        '
        'Cod_Usuario
        '
        Me.Cod_Usuario.DataPropertyName = "Cod_Usuario"
        Me.Cod_Usuario.HeaderText = "Código"
        Me.Cod_Usuario.Name = "Cod_Usuario"
        Me.Cod_Usuario.ReadOnly = True
        Me.Cod_Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        Me.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Perfil
        '
        Me.Perfil.DataPropertyName = "Perfil"
        Me.Perfil.HeaderText = "Tipo de Acesso"
        Me.Perfil.Name = "Perfil"
        Me.Perfil.ReadOnly = True
        Me.Perfil.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'E_Mail
        '
        Me.E_Mail.DataPropertyName = "E_Mail"
        Me.E_Mail.HeaderText = "E-Mail"
        Me.E_Mail.Name = "E_Mail"
        Me.E_Mail.ReadOnly = True
        Me.E_Mail.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Foto
        '
        Me.Foto.DataPropertyName = "Foto"
        Me.Foto.HeaderText = "Imagem"
        Me.Foto.Name = "Foto"
        Me.Foto.ReadOnly = True
        '
        'Frm_GerenUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 499)
        Me.Controls.Add(Me.TP_usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_GerenUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_GerenUsers"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvConsultaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_usuario.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvConsultaUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TP_usuario As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtConfimSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_EnviarFoto As System.Windows.Forms.Button
    Friend WithEvents txtUrlImg As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents combPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents FotosUsers As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Cod_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents E_Mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Foto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
