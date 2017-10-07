Public Class Frm_ConsProduto
    Dim tblProduto As New DataTable
    Dim blnConfirm As Boolean = False

    Public Property CodigoProd As String
        Get
            CodigoProd = dgvConsultaProduto.CurrentRow.Cells("colCod_Produto").Value.ToString
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property QuantEstoque As String
        Get
            QuantEstoque = dgvConsultaProduto.CurrentRow.Cells("colQuantidade").Value.ToString
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property PrecoUnit As String
        Get
            PrecoUnit = dgvConsultaProduto.CurrentRow.Cells("colPrecoUnit").Value.ToString
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Descricao As String
        Get
            Descricao = dgvConsultaProduto.CurrentRow.Cells("colDescricao").Value.ToString
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Confirm As Boolean
        Get
            Confirm = blnConfirm
        End Get
        Set(value As Boolean)
            blnConfirm = value
        End Set
    End Property

    Private Sub Frm_ConsProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvConsultaProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        strSql = "SELECT Cod_Produto, Descricao, Custo, Quantidade, Foto FROM Produto"

        Dim objBanco As New ClsBanco

        tblProduto = objBanco.EXECUTAR_COMANDO(strSql)

        dgvConsultaProduto.DataSource = tblProduto
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Confirm = True
        Me.Hide()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Confirm = False
        Me.Hide()

    End Sub

    Public Sub PCarregaImagemDataGrid() Handles Timer1.Tick
        Dim img As Image
        Try
            For i As Integer = 0 To dgvConsultaProduto.RowCount - 1

                img = Image.FromFile(dgvConsultaProduto.Rows(i).Cells("colFoto").Value.ToString)
                dgvConsultaProduto.Rows(i).Cells("FotosProdutos").Value = img
            Next
        Catch ex As Exception
            Timer1.Enabled = False
            MessageBox.Show("Ocorreu um Erro ao Listar as Fotos dos Usuários: " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try
    End Sub

End Class