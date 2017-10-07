<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConsultaFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ConsultaFornecedor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.dgvCosultaFornecedor = New System.Windows.Forms.DataGridView()
        Me.colCod_Fornec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCosultaFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Consulta de Fornecedores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(478, 408)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(141, 42)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Image = CType(resources.GetObject("btnConfirm.Image"), System.Drawing.Image)
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(12, 408)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(128, 42)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirmar"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirm.UseCompatibleTextRendering = True
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'dgvCosultaFornecedor
        '
        Me.dgvCosultaFornecedor.AllowUserToAddRows = False
        Me.dgvCosultaFornecedor.AllowUserToDeleteRows = False
        Me.dgvCosultaFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCosultaFornecedor.BackgroundColor = System.Drawing.Color.White
        Me.dgvCosultaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCosultaFornecedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod_Fornec, Me.colEmpresa})
        Me.dgvCosultaFornecedor.Location = New System.Drawing.Point(12, 78)
        Me.dgvCosultaFornecedor.Name = "dgvCosultaFornecedor"
        Me.dgvCosultaFornecedor.ReadOnly = True
        Me.dgvCosultaFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCosultaFornecedor.Size = New System.Drawing.Size(606, 285)
        Me.dgvCosultaFornecedor.TabIndex = 10
        '
        'colCod_Fornec
        '
        Me.colCod_Fornec.DataPropertyName = "Cod_Fornec"
        Me.colCod_Fornec.HeaderText = "Código"
        Me.colCod_Fornec.Name = "colCod_Fornec"
        Me.colCod_Fornec.ReadOnly = True
        '
        'colEmpresa
        '
        Me.colEmpresa.DataPropertyName = "Empresa"
        Me.colEmpresa.HeaderText = "Empresa"
        Me.colEmpresa.Name = "colEmpresa"
        Me.colEmpresa.ReadOnly = True
        '
        'Frm_ConsultaFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(630, 465)
        Me.Controls.Add(Me.dgvCosultaFornecedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirm)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_ConsultaFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Rápida de Fornecedores"
        CType(Me.dgvCosultaFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Private WithEvents dgvCosultaFornecedor As System.Windows.Forms.DataGridView
    Friend WithEvents colCod_Fornec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
