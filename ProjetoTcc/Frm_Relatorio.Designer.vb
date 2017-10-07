<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Relatorio
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Relatorio))
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_ESTOQUEDataSet = New ProjetoTcc.DB_ESTOQUEDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rbSim = New System.Windows.Forms.RadioButton()
        Me.rbNao = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.DtInicio = New System.Windows.Forms.DateTimePicker()
        Me.VendasTableAdapter = New ProjetoTcc.DB_ESTOQUEDataSetTableAdapters.VendasTableAdapter()
        Me.DtFim = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_ESTOQUEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VendasBindingSource
        '
        Me.VendasBindingSource.DataMember = "Vendas"
        Me.VendasBindingSource.DataSource = Me.DB_ESTOQUEDataSet
        '
        'DB_ESTOQUEDataSet
        '
        Me.DB_ESTOQUEDataSet.DataSetName = "DB_ESTOQUEDataSet"
        Me.DB_ESTOQUEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VendasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoTcc.rptVendas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 86)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1268, 406)
        Me.ReportViewer1.TabIndex = 0
        '
        'rbSim
        '
        Me.rbSim.AutoSize = True
        Me.rbSim.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSim.Location = New System.Drawing.Point(16, 45)
        Me.rbSim.Name = "rbSim"
        Me.rbSim.Size = New System.Drawing.Size(44, 20)
        Me.rbSim.TabIndex = 2
        Me.rbSim.TabStop = True
        Me.rbSim.Text = "Sim"
        Me.rbSim.UseVisualStyleBackColor = True
        '
        'rbNao
        '
        Me.rbNao.AutoSize = True
        Me.rbNao.Checked = True
        Me.rbNao.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNao.Location = New System.Drawing.Point(117, 45)
        Me.rbNao.Name = "rbNao"
        Me.rbNao.Size = New System.Drawing.Size(49, 20)
        Me.rbNao.TabIndex = 3
        Me.rbNao.TabStop = True
        Me.rbNao.Text = "Não"
        Me.rbNao.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNao)
        Me.GroupBox1.Controls.Add(Me.rbSim)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1041, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 71)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro por data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Escolha a Data de Inicio:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Enabled = False
        Me.btnFiltrar.Location = New System.Drawing.Point(793, 39)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(83, 21)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Enabled = False
        Me.btnLimpar.Location = New System.Drawing.Point(882, 39)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(83, 21)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'DtInicio
        '
        Me.DtInicio.CustomFormat = "dd/mm/yyyy"
        Me.DtInicio.Enabled = False
        Me.DtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtInicio.Location = New System.Drawing.Point(330, 37)
        Me.DtInicio.Name = "DtInicio"
        Me.DtInicio.Size = New System.Drawing.Size(106, 21)
        Me.DtInicio.TabIndex = 7
        Me.DtInicio.Value = New Date(2016, 12, 9, 0, 0, 0, 0)
        '
        'VendasTableAdapter
        '
        Me.VendasTableAdapter.ClearBeforeFill = True
        '
        'DtFim
        '
        Me.DtFim.CustomFormat = "dd/mm/yyyy"
        Me.DtFim.Enabled = False
        Me.DtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFim.Location = New System.Drawing.Point(637, 37)
        Me.DtFim.Name = "DtFim"
        Me.DtFim.Size = New System.Drawing.Size(106, 21)
        Me.DtFim.TabIndex = 7
        Me.DtFim.Value = New Date(2016, 12, 9, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(633, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Escolha a Data de Fim:"
        '
        'btnVoltar
        '
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoltar.Location = New System.Drawing.Point(0, 1)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(105, 59)
        Me.btnVoltar.TabIndex = 8
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'Frm_Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 492)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.DtFim)
        Me.Controls.Add(Me.DtInicio)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_Relatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciador de Relatórios"
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_ESTOQUEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_ESTOQUEDataSet As ProjetoTcc.DB_ESTOQUEDataSet
    Friend WithEvents VendasTableAdapter As ProjetoTcc.DB_ESTOQUEDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents rbSim As System.Windows.Forms.RadioButton
    Friend WithEvents rbNao As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents DtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
End Class
