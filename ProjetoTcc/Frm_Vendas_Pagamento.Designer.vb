<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Vendas_Pagamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Vendas_Pagamento))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RbDinheiro = New System.Windows.Forms.RadioButton()
        Me.RbCartCredito = New System.Windows.Forms.RadioButton()
        Me.RbCartDebito = New System.Windows.Forms.RadioButton()
        Me.RbCheque = New System.Windows.Forms.RadioButton()
        Me.lbTipPag = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnDescontosP = New System.Windows.Forms.Button()
        Me.btnDescontoS = New System.Windows.Forms.Button()
        Me.btnFecharPedido = New System.Windows.Forms.Button()
        Me.dgvFormaPagamento = New System.Windows.Forms.DataGridView()
        Me.colForma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lbDescontos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvFormaPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RbDinheiro
        '
        Me.RbDinheiro.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbDinheiro.BackColor = System.Drawing.Color.White
        Me.RbDinheiro.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.RbDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbDinheiro.Image = CType(resources.GetObject("RbDinheiro.Image"), System.Drawing.Image)
        Me.RbDinheiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbDinheiro.Location = New System.Drawing.Point(16, 207)
        Me.RbDinheiro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RbDinheiro.Name = "RbDinheiro"
        Me.RbDinheiro.Size = New System.Drawing.Size(350, 31)
        Me.RbDinheiro.TabIndex = 0
        Me.RbDinheiro.Text = "Dinheiro"
        Me.RbDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbDinheiro.UseVisualStyleBackColor = False
        '
        'RbCartCredito
        '
        Me.RbCartCredito.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbCartCredito.BackColor = System.Drawing.Color.White
        Me.RbCartCredito.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.RbCartCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbCartCredito.Image = CType(resources.GetObject("RbCartCredito.Image"), System.Drawing.Image)
        Me.RbCartCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbCartCredito.Location = New System.Drawing.Point(16, 361)
        Me.RbCartCredito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RbCartCredito.Name = "RbCartCredito"
        Me.RbCartCredito.Size = New System.Drawing.Size(350, 31)
        Me.RbCartCredito.TabIndex = 1
        Me.RbCartCredito.Text = "Cartão de Crédito"
        Me.RbCartCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbCartCredito.UseVisualStyleBackColor = False
        '
        'RbCartDebito
        '
        Me.RbCartDebito.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbCartDebito.BackColor = System.Drawing.Color.White
        Me.RbCartDebito.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.RbCartDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbCartDebito.Image = CType(resources.GetObject("RbCartDebito.Image"), System.Drawing.Image)
        Me.RbCartDebito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbCartDebito.Location = New System.Drawing.Point(16, 440)
        Me.RbCartDebito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RbCartDebito.Name = "RbCartDebito"
        Me.RbCartDebito.Size = New System.Drawing.Size(350, 31)
        Me.RbCartDebito.TabIndex = 2
        Me.RbCartDebito.Text = "Cartão de Débito"
        Me.RbCartDebito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbCartDebito.UseVisualStyleBackColor = False
        '
        'RbCheque
        '
        Me.RbCheque.Appearance = System.Windows.Forms.Appearance.Button
        Me.RbCheque.BackColor = System.Drawing.Color.White
        Me.RbCheque.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.RbCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RbCheque.Image = CType(resources.GetObject("RbCheque.Image"), System.Drawing.Image)
        Me.RbCheque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RbCheque.Location = New System.Drawing.Point(16, 284)
        Me.RbCheque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RbCheque.Name = "RbCheque"
        Me.RbCheque.Size = New System.Drawing.Size(350, 31)
        Me.RbCheque.TabIndex = 3
        Me.RbCheque.Text = "Cheque"
        Me.RbCheque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RbCheque.UseVisualStyleBackColor = False
        '
        'lbTipPag
        '
        Me.lbTipPag.BackColor = System.Drawing.Color.Blue
        Me.lbTipPag.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipPag.ForeColor = System.Drawing.Color.White
        Me.lbTipPag.Location = New System.Drawing.Point(12, 156)
        Me.lbTipPag.Name = "lbTipPag"
        Me.lbTipPag.Size = New System.Drawing.Size(354, 41)
        Me.lbTipPag.TabIndex = 4
        Me.lbTipPag.Text = "Tipo de Pagamento"
        Me.lbTipPag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 56)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "P A G A M E N T O"
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Century Gothic", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(439, 137)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(287, 60)
        Me.txtValor.TabIndex = 6
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDescontosP
        '
        Me.btnDescontosP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDescontosP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescontosP.Location = New System.Drawing.Point(428, 426)
        Me.btnDescontosP.Name = "btnDescontosP"
        Me.btnDescontosP.Size = New System.Drawing.Size(136, 73)
        Me.btnDescontosP.TabIndex = 7
        Me.btnDescontosP.Text = "DESCONTO %"
        Me.btnDescontosP.UseVisualStyleBackColor = False
        '
        'btnDescontoS
        '
        Me.btnDescontoS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDescontoS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescontoS.Location = New System.Drawing.Point(609, 426)
        Me.btnDescontoS.Name = "btnDescontoS"
        Me.btnDescontoS.Size = New System.Drawing.Size(136, 73)
        Me.btnDescontoS.TabIndex = 8
        Me.btnDescontoS.Text = "DESCONTO $"
        Me.btnDescontoS.UseVisualStyleBackColor = False
        '
        'btnFecharPedido
        '
        Me.btnFecharPedido.BackColor = System.Drawing.Color.Orange
        Me.btnFecharPedido.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharPedido.Location = New System.Drawing.Point(439, 276)
        Me.btnFecharPedido.Name = "btnFecharPedido"
        Me.btnFecharPedido.Size = New System.Drawing.Size(287, 44)
        Me.btnFecharPedido.TabIndex = 19
        Me.btnFecharPedido.Text = "Fechar Pedido"
        Me.btnFecharPedido.UseVisualStyleBackColor = False
        '
        'dgvFormaPagamento
        '
        Me.dgvFormaPagamento.AllowUserToAddRows = False
        Me.dgvFormaPagamento.AllowUserToDeleteRows = False
        Me.dgvFormaPagamento.BackgroundColor = System.Drawing.Color.White
        Me.dgvFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFormaPagamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colForma, Me.colValor})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFormaPagamento.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFormaPagamento.Location = New System.Drawing.Point(791, 115)
        Me.dgvFormaPagamento.Name = "dgvFormaPagamento"
        Me.dgvFormaPagamento.ReadOnly = True
        Me.dgvFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFormaPagamento.Size = New System.Drawing.Size(399, 181)
        Me.dgvFormaPagamento.TabIndex = 23
        '
        'colForma
        '
        Me.colForma.HeaderText = "Forma"
        Me.colForma.Name = "colForma"
        Me.colForma.ReadOnly = True
        '
        'colValor
        '
        Me.colValor.HeaderText = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(823, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 36)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Valor Total:"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.BackColor = System.Drawing.Color.Transparent
        Me.lbTotal.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.Red
        Me.lbTotal.Location = New System.Drawing.Point(1028, 413)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(71, 36)
        Me.lbTotal.TabIndex = 25
        Me.lbTotal.Text = "0,00"
        '
        'lbDescontos
        '
        Me.lbDescontos.AutoSize = True
        Me.lbDescontos.BackColor = System.Drawing.Color.Transparent
        Me.lbDescontos.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescontos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbDescontos.Location = New System.Drawing.Point(1030, 347)
        Me.lbDescontos.Name = "lbDescontos"
        Me.lbDescontos.Size = New System.Drawing.Size(58, 28)
        Me.lbDescontos.TabIndex = 27
        Me.lbDescontos.Text = "0,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(824, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 28)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Descontos:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Frm_Vendas_Pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1193, 517)
        Me.Controls.Add(Me.lbDescontos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvFormaPagamento)
        Me.Controls.Add(Me.btnFecharPedido)
        Me.Controls.Add(Me.btnDescontoS)
        Me.Controls.Add(Me.btnDescontosP)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbTipPag)
        Me.Controls.Add(Me.RbCheque)
        Me.Controls.Add(Me.RbCartDebito)
        Me.Controls.Add(Me.RbCartCredito)
        Me.Controls.Add(Me.RbDinheiro)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_Vendas_Pagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela de Pagamento"
        Me.TopMost = True
        CType(Me.dgvFormaPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RbDinheiro As System.Windows.Forms.RadioButton
    Friend WithEvents RbCartCredito As System.Windows.Forms.RadioButton
    Friend WithEvents RbCartDebito As System.Windows.Forms.RadioButton
    Friend WithEvents RbCheque As System.Windows.Forms.RadioButton
    Friend WithEvents lbTipPag As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents btnDescontosP As System.Windows.Forms.Button
    Friend WithEvents btnDescontoS As System.Windows.Forms.Button
    Friend WithEvents btnFecharPedido As System.Windows.Forms.Button
    Friend WithEvents dgvFormaPagamento As System.Windows.Forms.DataGridView
    Friend WithEvents colForma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents lbDescontos As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
