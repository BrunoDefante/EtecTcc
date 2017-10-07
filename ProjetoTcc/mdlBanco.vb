Module mdlBanco

    Public dia, mes, ano As String

    'Objeto Para acesso ao Banco de Dados
    Public cnnBanco As New SqlClient.SqlConnection

    Public idCLient, Users As String
    Public quantStoque As Integer

    'Variavel para Comandos SQL
    Public strSql As String = ""


End Module
