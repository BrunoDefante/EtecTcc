<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConsultaCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ConsultaCliente))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgvConsultaDeCliente = New System.Windows.Forms.DataGridView()
        Me.Cod_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cnpj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dt_Nasc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvConsultaDeCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta de Clientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Image = CType(resources.GetObject("btnConfirm.Image"), System.Drawing.Image)
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(11, 410)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(128, 42)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirmar"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirm.UseCompatibleTextRendering = True
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(477, 410)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(141, 42)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgvConsultaDeCliente
        '
        Me.dgvConsultaDeCliente.AllowUserToAddRows = False
        Me.dgvConsultaDeCliente.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvConsultaDeCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConsultaDeCliente.BackgroundColor = System.Drawing.Color.White
        Me.dgvConsultaDeCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvConsultaDeCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaDeCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_Cliente, Me.Nome, Me.Cpf, Me.Cnpj, Me.Dt_Nasc})
        Me.dgvConsultaDeCliente.Location = New System.Drawing.Point(12, 65)
        Me.dgvConsultaDeCliente.Name = "dgvConsultaDeCliente"
        Me.dgvConsultaDeCliente.ReadOnly = True
        Me.dgvConsultaDeCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaDeCliente.Size = New System.Drawing.Size(607, 298)
        Me.dgvConsultaDeCliente.TabIndex = 4
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
        'Frm_ConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(630, 465)
        Me.Controls.Add(Me.dgvConsultaDeCliente)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ConsultaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Rápida de Clientes"
        Me.TopMost = True
        CType(Me.dgvConsultaDeCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvConsultaDeCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Cod_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cpf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cnpj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dt_Nasc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
