<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConsProduto
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ConsProduto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvConsultaProduto = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FotosProdutos = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colCod_Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecoUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvConsultaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consulta de Produtos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvConsultaProduto
        '
        Me.dgvConsultaProduto.AllowUserToAddRows = False
        Me.dgvConsultaProduto.AllowUserToDeleteRows = False
        Me.dgvConsultaProduto.AllowUserToResizeColumns = False
        Me.dgvConsultaProduto.AllowUserToResizeRows = False
        Me.dgvConsultaProduto.BackgroundColor = System.Drawing.Color.White
        Me.dgvConsultaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FotosProdutos, Me.colCod_Produto, Me.colDescricao, Me.colPrecoUnit, Me.colQuantidade, Me.colFoto})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsultaProduto.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvConsultaProduto.Location = New System.Drawing.Point(12, 78)
        Me.dgvConsultaProduto.MultiSelect = False
        Me.dgvConsultaProduto.Name = "dgvConsultaProduto"
        Me.dgvConsultaProduto.ReadOnly = True
        Me.dgvConsultaProduto.RowTemplate.Height = 50
        Me.dgvConsultaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaProduto.Size = New System.Drawing.Size(606, 285)
        Me.dgvConsultaProduto.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(477, 411)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(141, 42)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Image = CType(resources.GetObject("btnConfirm.Image"), System.Drawing.Image)
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(11, 411)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(128, 42)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Confirmar"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirm.UseCompatibleTextRendering = True
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
        'colCod_Produto
        '
        Me.colCod_Produto.DataPropertyName = "Cod_Produto"
        Me.colCod_Produto.HeaderText = "Código"
        Me.colCod_Produto.Name = "colCod_Produto"
        Me.colCod_Produto.ReadOnly = True
        '
        'colDescricao
        '
        Me.colDescricao.DataPropertyName = "Descricao"
        Me.colDescricao.HeaderText = "Descricao"
        Me.colDescricao.Name = "colDescricao"
        Me.colDescricao.ReadOnly = True
        '
        'colPrecoUnit
        '
        Me.colPrecoUnit.DataPropertyName = "Custo"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colPrecoUnit.DefaultCellStyle = DataGridViewCellStyle1
        Me.colPrecoUnit.HeaderText = "Preço Unitário"
        Me.colPrecoUnit.Name = "colPrecoUnit"
        Me.colPrecoUnit.ReadOnly = True
        '
        'colQuantidade
        '
        Me.colQuantidade.DataPropertyName = "Quantidade"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colQuantidade.DefaultCellStyle = DataGridViewCellStyle2
        Me.colQuantidade.HeaderText = "Quantidade em Estoque"
        Me.colQuantidade.Name = "colQuantidade"
        Me.colQuantidade.ReadOnly = True
        '
        'colFoto
        '
        Me.colFoto.DataPropertyName = "Foto"
        Me.colFoto.HeaderText = "Imagem"
        Me.colFoto.Name = "colFoto"
        Me.colFoto.ReadOnly = True
        Me.colFoto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colFoto.Visible = False
        '
        'Frm_ConsProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(630, 465)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.dgvConsultaProduto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_ConsProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Rápida de Produtos"
        Me.TopMost = True
        CType(Me.dgvConsultaProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvConsultaProduto As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FotosProdutos As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCod_Produto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrecoUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQuantidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFoto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
