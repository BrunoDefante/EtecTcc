<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EditProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_EditProd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Excluir = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Voltar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodFornec = New System.Windows.Forms.TextBox()
        Me.btnConsFornec = New System.Windows.Forms.Button()
        Me.NumQuantiMini = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PicPreImagem = New System.Windows.Forms.PictureBox()
        Me.btn_EnviarFoto = New System.Windows.Forms.Button()
        Me.txtUrlFoto = New System.Windows.Forms.TextBox()
        Me.NumQuanti = New System.Windows.Forms.NumericUpDown()
        Me.txtCusto = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumQuantiMini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicPreImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumQuanti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.btn_EnviarFoto)
        Me.GroupBox1.Controls.Add(Me.txtUrlFoto)
        Me.GroupBox1.Controls.Add(Me.NumQuanti)
        Me.GroupBox1.Controls.Add(Me.txtCusto)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.txtNomeProd)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_Excluir)
        Me.GroupBox1.Controls.Add(Me.btn_Editar)
        Me.GroupBox1.Controls.Add(Me.btn_Voltar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 405)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'btn_Excluir
        '
        Me.btn_Excluir.Enabled = False
        Me.btn_Excluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Excluir.Image = CType(resources.GetObject("btn_Excluir.Image"), System.Drawing.Image)
        Me.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Excluir.Location = New System.Drawing.Point(336, 344)
        Me.btn_Excluir.Name = "btn_Excluir"
        Me.btn_Excluir.Size = New System.Drawing.Size(128, 55)
        Me.btn_Excluir.TabIndex = 50
        Me.btn_Excluir.Text = "Excluir"
        Me.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Excluir.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.Image = CType(resources.GetObject("btn_Editar.Image"), System.Drawing.Image)
        Me.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Editar.Location = New System.Drawing.Point(80, 344)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(114, 55)
        Me.btn_Editar.TabIndex = 49
        Me.btn_Editar.Text = "Editar"
        Me.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Editar.UseVisualStyleBackColor = True
        '
        'btn_Voltar
        '
        Me.btn_Voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Voltar.Image = CType(resources.GetObject("btn_Voltar.Image"), System.Drawing.Image)
        Me.btn_Voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Voltar.Location = New System.Drawing.Point(593, 344)
        Me.btn_Voltar.Name = "btn_Voltar"
        Me.btn_Voltar.Size = New System.Drawing.Size(115, 55)
        Me.btn_Voltar.TabIndex = 48
        Me.btn_Voltar.Text = "Voltar"
        Me.btn_Voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Voltar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(203, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(463, 31)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Consulta Avançada de Produtos"
        '
        'txtCodFornec
        '
        Me.txtCodFornec.Location = New System.Drawing.Point(13, 117)
        Me.txtCodFornec.Name = "txtCodFornec"
        Me.txtCodFornec.ReadOnly = True
        Me.txtCodFornec.Size = New System.Drawing.Size(91, 20)
        Me.txtCodFornec.TabIndex = 71
        Me.txtCodFornec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnConsFornec
        '
        Me.btnConsFornec.Enabled = False
        Me.btnConsFornec.Image = CType(resources.GetObject("btnConsFornec.Image"), System.Drawing.Image)
        Me.btnConsFornec.Location = New System.Drawing.Point(110, 113)
        Me.btnConsFornec.Name = "btnConsFornec"
        Me.btnConsFornec.Size = New System.Drawing.Size(51, 27)
        Me.btnConsFornec.TabIndex = 70
        Me.btnConsFornec.UseVisualStyleBackColor = True
        '
        'NumQuantiMini
        '
        Me.NumQuantiMini.Enabled = False
        Me.NumQuantiMini.Location = New System.Drawing.Point(13, 182)
        Me.NumQuantiMini.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumQuantiMini.Name = "NumQuantiMini"
        Me.NumQuantiMini.Size = New System.Drawing.Size(170, 20)
        Me.NumQuantiMini.TabIndex = 69
        Me.NumQuantiMini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumQuantiMini.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Quantidade Mínima:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Gainsboro
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(149, 303)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(527, 25)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = " Campos Com (*) São de Preenchimento Obrigatório."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "*Código do Fornecedor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicPreImagem)
        Me.GroupBox2.Location = New System.Drawing.Point(614, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 145)
        Me.GroupBox2.TabIndex = 65
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
        'btn_EnviarFoto
        '
        Me.btn_EnviarFoto.Enabled = False
        Me.btn_EnviarFoto.Image = CType(resources.GetObject("btn_EnviarFoto.Image"), System.Drawing.Image)
        Me.btn_EnviarFoto.Location = New System.Drawing.Point(486, 231)
        Me.btn_EnviarFoto.Name = "btn_EnviarFoto"
        Me.btn_EnviarFoto.Size = New System.Drawing.Size(88, 46)
        Me.btn_EnviarFoto.TabIndex = 64
        Me.btn_EnviarFoto.UseVisualStyleBackColor = True
        '
        'txtUrlFoto
        '
        Me.txtUrlFoto.Enabled = False
        Me.txtUrlFoto.Location = New System.Drawing.Point(202, 246)
        Me.txtUrlFoto.Name = "txtUrlFoto"
        Me.txtUrlFoto.Size = New System.Drawing.Size(278, 20)
        Me.txtUrlFoto.TabIndex = 63
        '
        'NumQuanti
        '
        Me.NumQuanti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumQuanti.Enabled = False
        Me.NumQuanti.Location = New System.Drawing.Point(262, 182)
        Me.NumQuanti.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumQuanti.Name = "NumQuanti"
        Me.NumQuanti.Size = New System.Drawing.Size(191, 20)
        Me.NumQuanti.TabIndex = 62
        Me.NumQuanti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumQuanti.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'txtCusto
        '
        Me.txtCusto.Enabled = False
        Me.txtCusto.Location = New System.Drawing.Point(262, 116)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(122, 20)
        Me.txtCusto.TabIndex = 61
        Me.txtCusto.Text = "0,00"
        Me.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(460, 35)
        Me.txtDescricao.MaxLength = 140
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(337, 102)
        Me.txtDescricao.TabIndex = 60
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(262, 36)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(176, 20)
        Me.txtTipo.TabIndex = 59
        '
        'txtNomeProd
        '
        Me.txtNomeProd.Enabled = False
        Me.txtNomeProd.Location = New System.Drawing.Point(11, 36)
        Me.txtNomeProd.Name = "txtNomeProd"
        Me.txtNomeProd.Size = New System.Drawing.Size(229, 20)
        Me.txtNomeProd.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(199, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "*Foto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(258, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "*Quantidade à ser Inserida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "*Custo (R$):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "*Descrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "*Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "*Nome:"
        '
        'Frm_EditProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 460)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_EditProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Avançada de Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumQuantiMini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicPreImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumQuanti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Excluir As System.Windows.Forms.Button
    Friend WithEvents btn_Editar As System.Windows.Forms.Button
    Friend WithEvents btn_Voltar As System.Windows.Forms.Button
    Friend WithEvents txtCodFornec As System.Windows.Forms.TextBox
    Friend WithEvents btnConsFornec As System.Windows.Forms.Button
    Friend WithEvents NumQuantiMini As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PicPreImagem As System.Windows.Forms.PictureBox
    Friend WithEvents btn_EnviarFoto As System.Windows.Forms.Button
    Friend WithEvents txtUrlFoto As System.Windows.Forms.TextBox
    Friend WithEvents NumQuanti As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCusto As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
