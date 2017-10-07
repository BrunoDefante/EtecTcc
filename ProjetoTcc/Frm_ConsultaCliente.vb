Public Class Frm_ConsultaCliente
    Dim tblCliente As New DataTable
    Dim blnConfirm As Boolean = False

    Public Property CodCliente As String
        Get
            CodCliente = dgvConsultaDeCliente.CurrentRow.Cells("Cod_Cliente").Value.ToString
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

    Public Property NomeCLiente As String
        Get
            NomeCLiente = dgvConsultaDeCliente.CurrentRow.Cells("Nome").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property

    Private Sub Frm_ConsultaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvConsultaDeCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        strSql = "Select Cod_Cliente, Nome, Cpf, Cnpj, Dt_Nasc from Dados_Cliente"

        Dim objBanco As New ClsBanco

        tblCliente = objBanco.EXECUTAR_COMANDO(strSql)

        dgvConsultaDeCliente.DataSource = tblCliente

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