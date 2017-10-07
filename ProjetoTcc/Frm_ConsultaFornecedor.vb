Public Class Frm_ConsultaFornecedor
    Dim tblFornecedor As New DataTable
    Dim blnConfirm As Boolean = False

    Public Property CodigoFornec As String
        Get
            CodigoFornec = dgvCosultaFornecedor.CurrentRow.Cells("colCod_Fornec").Value.ToString
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Empresa As String
        Get
            Empresa = dgvCosultaFornecedor.CurrentRow.Cells("colEmpresa").Value.ToString
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

    Private Sub Frm_ConsultaFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSql = "SELECT Cod_Fornec, Empresa FROM Fornecedor"

        Dim objBanco As New ClsBanco
        tblFornecedor = objBanco.EXECUTAR_COMANDO(strSql)

        dgvCosultaFornecedor.DataSource = tblFornecedor

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Confirm = True
        Me.Hide()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Confirm = False
        Me.Hide()
    End Sub
End Class