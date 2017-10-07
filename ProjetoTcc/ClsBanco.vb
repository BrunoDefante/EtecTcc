Public Class ClsBanco

    '''    <summary>
    ''' Abrir Conexao com Servidor de banco de Dados
    ''' </summary>
    ''' <returns>Conexao Aberta ou erro Ocorrido</returns>

    Public Function AbrirConexao(Optional ByVal strConexao As String = "", _
                                 Optional ByRef Mensagem As String = "") As SqlClient.SqlConnection

        Dim objCnn As New SqlClient.SqlConnection

        If strConexao.Trim() = "" Then
            strConexao = "Server=BRUNO-ASUS;DataBase=DB_ESTOQUE;Trusted_Connection=yes"
            'strConexao = "DATA SOURCE=(LOCAL); " & "INITIAL CATALOG=DB_ESTOQUE;" & "USER ID=sa; PASSWORD=etec;"


            'strConexao = "DATA SOURCE=(LOCAL); " & "INITIAL CATALOG=DB_ESTOQUE;" & "INTEGRATED SECURITY=yes;"

        End If

        Try
            objCnn.ConnectionString = strConexao
            objCnn.Open()
        Catch ex As Exception
            Mensagem = Err.Description

        End Try

        Return objCnn

    End Function

    Public Function EXECUTAR_COMANDO(strComando As String) As DataTable

        Dim cmd As New SqlClient.SqlCommand
        Dim dt As New DataTable
        cmd.CommandText = strComando
        cmd.Connection = cnnBanco
        Dim da As New SqlClient.SqlDataAdapter(cmd)

        da.Fill(dt)



        Return dt
        cmd = Nothing
        da = Nothing

    End Function



End Class
