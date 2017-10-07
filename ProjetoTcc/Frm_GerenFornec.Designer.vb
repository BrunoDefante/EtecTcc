<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GerenFornec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenFornec))
        Me.Tab_ControGerForn = New System.Windows.Forms.TabControl()
        Me.Tab_PageGerForn = New System.Windows.Forms.TabPage()
        Me.btn_Consultar = New System.Windows.Forms.Button()
        Me.btn_Voltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCosultaFornecedor = New System.Windows.Forms.DataGridView()
        Me.Cod_Fornec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Site_Web = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tab_PageCadForn = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Cadastrar = New System.Windows.Forms.Button()
        Me.btn_Novo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Site = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Produto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_E_Mail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Empresa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tab_ControGerForn.SuspendLayout()
        Me.Tab_PageGerForn.SuspendLayout()
        CType(Me.dgvCosultaFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_PageCadForn.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_ControGerForn
        '
        Me.Tab_ControGerForn.Controls.Add(Me.Tab_PageGerForn)
        Me.Tab_ControGerForn.Controls.Add(Me.Tab_PageCadForn)
        Me.Tab_ControGerForn.Location = New System.Drawing.Point(12, 12)
        Me.Tab_ControGerForn.Name = "Tab_ControGerForn"
        Me.Tab_ControGerForn.Padding = New System.Drawing.Point(185, 10)
        Me.Tab_ControGerForn.SelectedIndex = 0
        Me.Tab_ControGerForn.Size = New System.Drawing.Size(857, 485)
        Me.Tab_ControGerForn.TabIndex = 0
        '
        'Tab_PageGerForn
        '
        Me.Tab_PageGerForn.Controls.Add(Me.btn_Consultar)
        Me.Tab_PageGerForn.Controls.Add(Me.btn_Voltar)
        Me.Tab_PageGerForn.Controls.Add(Me.Label1)
        Me.Tab_PageGerForn.Controls.Add(Me.dgvCosultaFornecedor)
        Me.Tab_PageGerForn.Location = New System.Drawing.Point(4, 36)
        Me.Tab_PageGerForn.Name = "Tab_PageGerForn"
        Me.Tab_PageGerForn.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_PageGerForn.Size = New System.Drawing.Size(849, 445)
        Me.Tab_PageGerForn.TabIndex = 0
        Me.Tab_PageGerForn.Text = "Fornecedores"
        Me.Tab_PageGerForn.UseVisualStyleBackColor = True
        '
        'btn_Consultar
        '
        Me.btn_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultar.Image = CType(resources.GetObject("btn_Consultar.Image"), System.Drawing.Image)
        Me.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Consultar.Location = New System.Drawing.Point(643, 382)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(200, 60)
        Me.btn_Consultar.TabIndex = 8
        Me.btn_Consultar.Text = "Consulta Avançada"
        Me.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Consultar.UseVisualStyleBackColor = True
        '
        'btn_Voltar
        '
        Me.btn_Voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Voltar.Image = CType(resources.GetObject("btn_Voltar.Image"), System.Drawing.Image)
        Me.btn_Voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Voltar.Location = New System.Drawing.Point(6, 382)
        Me.btn_Voltar.Name = "btn_Voltar"
        Me.btn_Voltar.Size = New System.Drawing.Size(114, 60)
        Me.btn_Voltar.TabIndex = 4
        Me.btn_Voltar.Text = "Voltar"
        Me.btn_Voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Voltar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consulta de Fornecedores"
        '
        'dgvCosultaFornecedor
        '
        Me.dgvCosultaFornecedor.AllowUserToAddRows = False
        Me.dgvCosultaFornecedor.AllowUserToDeleteRows = False
        Me.dgvCosultaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCosultaFornecedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_Fornec, Me.Empresa, Me.Nome, Me.Telefone, Me.Produto, Me.E_Mail, Me.Site_Web})
        Me.dgvCosultaFornecedor.Location = New System.Drawing.Point(-6, 47)
        Me.dgvCosultaFornecedor.Name = "dgvCosultaFornecedor"
        Me.dgvCosultaFornecedor.ReadOnly = True
        Me.dgvCosultaFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCosultaFornecedor.Size = New System.Drawing.Size(849, 326)
        Me.dgvCosultaFornecedor.TabIndex = 2
        '
        'Cod_Fornec
        '
        Me.Cod_Fornec.DataPropertyName = "Cod_Fornec"
        Me.Cod_Fornec.HeaderText = "Código"
        Me.Cod_Fornec.Name = "Cod_Fornec"
        Me.Cod_Fornec.ReadOnly = True
        '
        'Empresa
        '
        Me.Empresa.DataPropertyName = "Empresa"
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Telefone
        '
        Me.Telefone.DataPropertyName = "Telefone"
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.Name = "Telefone"
        Me.Telefone.ReadOnly = True
        '
        'Produto
        '
        Me.Produto.DataPropertyName = "Produto"
        Me.Produto.HeaderText = "Produto"
        Me.Produto.Name = "Produto"
        Me.Produto.ReadOnly = True
        '
        'E_Mail
        '
        Me.E_Mail.DataPropertyName = "E_Mail"
        Me.E_Mail.HeaderText = "E-Mail"
        Me.E_Mail.Name = "E_Mail"
        Me.E_Mail.ReadOnly = True
        '
        'Site_Web
        '
        Me.Site_Web.DataPropertyName = "Site_Web"
        Me.Site_Web.HeaderText = "Pagina da Web"
        Me.Site_Web.Name = "Site_Web"
        Me.Site_Web.ReadOnly = True
        '
        'Tab_PageCadForn
        '
        Me.Tab_PageCadForn.Controls.Add(Me.Label25)
        Me.Tab_PageCadForn.Controls.Add(Me.Label3)
        Me.Tab_PageCadForn.Controls.Add(Me.GroupBox1)
        Me.Tab_PageCadForn.Location = New System.Drawing.Point(4, 36)
        Me.Tab_PageCadForn.Name = "Tab_PageCadForn"
        Me.Tab_PageCadForn.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_PageCadForn.Size = New System.Drawing.Size(849, 445)
        Me.Tab_PageCadForn.TabIndex = 1
        Me.Tab_PageCadForn.Text = "Cadastro"
        Me.Tab_PageCadForn.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Gainsboro
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(134, 415)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(581, 27)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = " Campos Com (*) São de Preenchimento Obrigatório."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(383, 33)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cadastro de Fornecedores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskTelefone)
        Me.GroupBox1.Controls.Add(Me.btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_Cadastrar)
        Me.GroupBox1.Controls.Add(Me.btn_Novo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_Site)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Produto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_E_Mail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_Empresa)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_Nome)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 357)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'mskTelefone
        '
        Me.mskTelefone.Enabled = False
        Me.mskTelefone.Location = New System.Drawing.Point(285, 136)
        Me.mskTelefone.Mask = "(99) 0000-0000"
        Me.mskTelefone.Name = "mskTelefone"
        Me.mskTelefone.Size = New System.Drawing.Size(88, 20)
        Me.mskTelefone.TabIndex = 2
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cancelar.Location = New System.Drawing.Point(478, 306)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(124, 46)
        Me.btn_Cancelar.TabIndex = 15
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Cadastrar
        '
        Me.btn_Cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cadastrar.Image = CType(resources.GetObject("btn_Cadastrar.Image"), System.Drawing.Image)
        Me.btn_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cadastrar.Location = New System.Drawing.Point(248, 305)
        Me.btn_Cadastrar.Name = "btn_Cadastrar"
        Me.btn_Cadastrar.Size = New System.Drawing.Size(114, 46)
        Me.btn_Cadastrar.TabIndex = 14
        Me.btn_Cadastrar.Text = "Gravar"
        Me.btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'btn_Novo
        '
        Me.btn_Novo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Novo.Image = CType(resources.GetObject("btn_Novo.Image"), System.Drawing.Image)
        Me.btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Novo.Location = New System.Drawing.Point(23, 305)
        Me.btn_Novo.Name = "btn_Novo"
        Me.btn_Novo.Size = New System.Drawing.Size(102, 46)
        Me.btn_Novo.TabIndex = 13
        Me.btn_Novo.Text = "Novo"
        Me.btn_Novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Novo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(119, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "*Nome:"
        '
        'txt_Site
        '
        Me.txt_Site.Enabled = False
        Me.txt_Site.Location = New System.Drawing.Point(285, 267)
        Me.txt_Site.Name = "txt_Site"
        Me.txt_Site.Size = New System.Drawing.Size(234, 20)
        Me.txt_Site.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(119, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "*Empresa:"
        '
        'txt_Produto
        '
        Me.txt_Produto.Enabled = False
        Me.txt_Produto.Location = New System.Drawing.Point(285, 183)
        Me.txt_Produto.Name = "txt_Produto"
        Me.txt_Produto.Size = New System.Drawing.Size(234, 20)
        Me.txt_Produto.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(119, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "*Telefone:"
        '
        'txt_E_Mail
        '
        Me.txt_E_Mail.Enabled = False
        Me.txt_E_Mail.Location = New System.Drawing.Point(285, 225)
        Me.txt_E_Mail.Name = "txt_E_Mail"
        Me.txt_E_Mail.Size = New System.Drawing.Size(234, 20)
        Me.txt_E_Mail.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(119, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "*Produto:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(119, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "E-Mail:"
        '
        'txt_Empresa
        '
        Me.txt_Empresa.Enabled = False
        Me.txt_Empresa.Location = New System.Drawing.Point(285, 96)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.Size = New System.Drawing.Size(234, 20)
        Me.txt_Empresa.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(119, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 23)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Pagina Web:"
        '
        'txt_Nome
        '
        Me.txt_Nome.Enabled = False
        Me.txt_Nome.Location = New System.Drawing.Point(285, 47)
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(234, 20)
        Me.txt_Nome.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Frm_GerenFornec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 509)
        Me.Controls.Add(Me.Tab_ControGerForn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_GerenFornec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_GerenFornec"
        Me.Tab_ControGerForn.ResumeLayout(False)
        Me.Tab_PageGerForn.ResumeLayout(False)
        Me.Tab_PageGerForn.PerformLayout()
        CType(Me.dgvCosultaFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_PageCadForn.ResumeLayout(False)
        Me.Tab_PageCadForn.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_ControGerForn As System.Windows.Forms.TabControl
    Friend WithEvents Tab_PageGerForn As System.Windows.Forms.TabPage
    Friend WithEvents Tab_PageCadForn As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Site As System.Windows.Forms.TextBox
    Friend WithEvents txt_Produto As System.Windows.Forms.TextBox
    Friend WithEvents txt_E_Mail As System.Windows.Forms.TextBox
    Friend WithEvents txt_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Cadastrar As System.Windows.Forms.Button
    Friend WithEvents btn_Novo As System.Windows.Forms.Button
    Friend WithEvents btn_Voltar As System.Windows.Forms.Button
    Friend WithEvents btn_Consultar As System.Windows.Forms.Button
    Friend WithEvents Cod_Fornec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents E_Mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Site_Web As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mskTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents dgvCosultaFornecedor As System.Windows.Forms.DataGridView
End Class
