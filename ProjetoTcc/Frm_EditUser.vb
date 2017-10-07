Imports System.IO
Public Class Frm_EditUser
    Private strAcao As String = "Editar"
    Private diretorio, imgDel As String
    Private img As Image
    Public tempinho As String

    Public Function tempo() Handles MyBase.Load
        Dim hora As String = Replace(CDate(Now), "/", "-")
        hora = Replace(hora, ":", "-")
        Return hora
    End Function
    Private Sub Frm_EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strAcao = "Editar"
        Dim drUser As SqlClient.SqlDataReader
        Dim cmdUser As New SqlClient.SqlCommand

        strSql = "SELECT * FROM USUARIO"
        strSql += " WHERE COD_USUARIO=@COD_USUARIO"

        cmdUser.Connection = cnnBanco
        cmdUser.CommandText = strSql

        cmdUser.Parameters.AddWithValue("@Cod_Usuario", idCLient.ToString)
        Try
            drUser = cmdUser.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro Inesperado!" & vbNewLine & Err.Description.ToString, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdUser.Parameters.Clear()
            Exit Sub
        End Try

        'verificar se retornou Dados'
        Try
            If Not drUser.HasRows Then
                MessageBox.Show("Nenhum Usuário Cadastrado", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                drUser.Read()
                txtNome.Text = drUser("Nome").ToString
                txtLogin.Text = drUser("Loginn").ToString
                txtSenha.Text = drUser("Senha").ToString
                txtConfimSenha.Text = drUser("Senha").ToString
                txtEmail.Text = drUser("E_Mail").ToString

                Dim verificaPerfil As String = drUser("Perfil").ToString
                If (verificaPerfil = "Administrador") Then
                    combPerfil.SelectedIndex = 0
                Else
                    combPerfil.SelectedIndex = 1
                End If
                txtUrlImg.Text = drUser("Foto").ToString
                diretorio = drUser("Foto").ToString

                img = Image.FromFile(txtUrlImg.Text.ToString)
                imgDel = txtUrlImg.Text.ToString

                picImgUser.Image = img
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro : " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
           
        End Try
        'limpar o SqlComand
        cmdUser.Parameters.Clear()
        cmdUser = Nothing
        drUser.Close()


    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If (strAcao = "Editar") Then
            habilitaCampos()
        ElseIf (strAcao = "Gravar") Then
            If MessageBox.Show("Deseja Realmente Alterar os Dados? ", "Alterar!", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim cmdUser As New SqlClient.SqlCommand(strSql, cnnBanco)
                If verificaDados() = True Then
                    Dim verificaPerfil As String
                    If combPerfil.SelectedIndex = 0 Then
                        verificaPerfil = "Administrador"
                    Else
                        verificaPerfil = "Usuário"
                    End If
                    'gravar a imagem na pasta
                    Try
                        'Verificando se o Arquivo Existe!
                        If File.Exists(diretorio) = True Then

                            strSql = "UPDATE USUARIO SET " & "Nome=@Nome," & "Loginn=@Loginn," & "E_Mail=@E_Mail," & "Perfil=@Perfil" & " WHERE Cod_Usuario=@Cod_Usuario"
                        Else
                            File.Copy(txtUrlImg.Text, diretorio)

                            strSql = "UPDATE USUARIO SET " & "Nome=@Nome," & "Loginn=@Loginn," & "E_Mail=@E_Mail," & "Perfil=@Perfil," & "Foto=@Foto" & " WHERE Cod_Usuario=@Cod_Usuario"


                            'Renomeando arquivos para não causar conflitos em futuros Edits

                            ' My.Computer.FileSystem.RenameFile(diretorio, Replace(tempo, ":", "-") + ".Jpg")
                        End If

                    Catch ex As Exception
                        MsgBox("Ocorreu Um Erro ao Gravar Imagem: " & vbNewLine & Err.Description, MsgBoxStyle.Critical, "ERRO!")
                    End Try
                    '------------



                    cmdUser.Connection = cnnBanco
                    cmdUser.CommandText = strSql

                    cmdUser.Parameters.AddWithValue("@Cod_Usuario", idCLient.ToString)
                    cmdUser.Parameters.AddWithValue("@Nome", txtNome.Text.Trim)
                    cmdUser.Parameters.AddWithValue("@Loginn", txtLogin.Text.Trim)
                    cmdUser.Parameters.AddWithValue("@E_Mail", txtEmail.Text.Trim)
                    cmdUser.Parameters.AddWithValue("@Perfil", verificaPerfil.ToString)
                    cmdUser.Parameters.AddWithValue("@Foto", If(diretorio = "", DBNull.Value, diretorio))

                    Try
                        cmdUser.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("OCorreu um Erro Ao Atualizar os Dados" & vbNewLine & Err.Description, "Atualizar Dados", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cmdUser.Parameters.Clear()
                        Exit Sub
                    End Try
                    cmdUser.Parameters.Clear()
                    MessageBox.Show("Dados Atualizados Com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call Frm_GerenUsers.Preencher_Grid_Users()
                    ' Call Frm_GerenUsers.PCarregaImagemDataGrid()
                    Frm_GerenUsers.Refresh()
                    'Try
                    '    File.Delete(imgDel.ToString)
                    'Catch ex As Exception
                    '    MessageBox.Show("Ocoreu Um Erro: " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End Try
                    Me.Close()

                End If
            End If
        End If
    End Sub

    Private Function verificaDados()
        If (txtNome.Text = "") Then
            MsgBox("Preencha o Campo Nome!", MsgBoxStyle.Critical)
            txtNome.Focus()
            Return False
        End If

        If (txtLogin.Text = "") Then
            MsgBox("Preencha o Campo Login!", MsgBoxStyle.Critical)
            txtLogin.Focus()
            txtLogin.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtLogin.BackColor = System.Drawing.Color.White
        End If

        If (txtSenha.Text = "") Then
            MsgBox("Preencha o Campo Senha!", MsgBoxStyle.Critical)
            txtSenha.Focus()
            txtSenha.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtSenha.BackColor = System.Drawing.Color.White
        End If

        If (txtConfimSenha.Text = "") Then
            MsgBox("Preencha a Confimação de Senha!", MsgBoxStyle.Critical)
            txtConfimSenha.Focus()
            txtConfimSenha.BackColor = System.Drawing.Color.Yellow
            Return False
        ElseIf (txtConfimSenha.Text.Trim <> "") Then
            If (txtSenha.Text.Trim <> txtConfimSenha.Text.Trim) Then
                MessageBox.Show("As Senhas Nâo se Coincidem!", "Senha!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtConfimSenha.Focus()
                txtConfimSenha.BackColor = System.Drawing.Color.Yellow
                Return False
            Else
                txtConfimSenha.BackColor = System.Drawing.Color.White
            End If
        End If

        If (txtEmail.Text = "") Then
            MsgBox("Preencha o Campo E-mail!", MsgBoxStyle.Critical)
            txtEmail.Focus()
            txtEmail.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtEmail.BackColor = System.Drawing.Color.White
        End If

        If (combPerfil.SelectedItem = "") Then
            MsgBox("Selecione o Nível de Acesso do Usuário!", MsgBoxStyle.Critical)
            combPerfil.Focus()
            combPerfil.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            combPerfil.BackColor = System.Drawing.Color.White
        End If

        If (txtUrlImg.Text = "") Then
            MsgBox("Por Favor, Selecione um Imagem de Perfil", MsgBoxStyle.Critical)
            btn_EnviarFoto.Focus()
            txtUrlImg.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtUrlImg.BackColor = System.Drawing.Color.White
        End If

        Return True
    End Function

    Private Sub btn_EnviarFoto_Click(sender As Object, e As EventArgs) Handles btn_EnviarFoto.Click
        Dim OpenImg As New OpenFileDialog

        OpenImg.Filter = "ARQUIVO *.Jpg|*.jpg|ARQUIVO *.Jpeg|*.jpeg|ARQUIVO *.Png|*.png"


        If OpenImg.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtUrlImg.Text = OpenImg.FileName
        Else
            Exit Sub
        End If
        Dim img As Image
        Try

            img = Image.FromFile(txtUrlImg.Text.ToString)
            diretorio = "C:\\imagemBanco" + "\" + Replace(tempo, ":", "-") + ".Jpg"
            tempinho = tempo()
            picImgUser.Image = img

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Carregar a imagem para pré-visualização:" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub pintarCampos() Handles Timer1.Tick
        If (txtNome.Text.Trim <> "") Then
            txtNome.BackColor = System.Drawing.Color.White
        ElseIf (txtNome.Enabled = True And txtNome.Text.Trim = "") Then
            txtNome.BackColor = System.Drawing.Color.Yellow
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Edições Não Salvas Serão Perdidas!" & vbNewLine & "Deseja Sair ?", "ATENÇÃO", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Frm_GerenUsers.limpaCampos()
            strAcao = "Editar"
            btn_Editar.Text = strAcao
            Me.Close()
        End If
    End Sub

    Private Sub habilitaCampos()
        txtNome.Enabled = True
        txtLogin.Enabled = True
        txtSenha.Enabled = True
        txtConfimSenha.Enabled = True
        txtEmail.Enabled = True
        combPerfil.Enabled = True
        btn_EnviarFoto.Enabled = True
        strAcao = "Gravar"
        btn_Editar.Text = strAcao
        btn_Excluir.Enabled = True
        txtNome.Focus()
    End Sub
    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        bloqueiaNumeros(e)
    End Sub

    Private Sub bloqueiaNumeros(e)
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = True
        End If

    End Sub

    Private Sub btn_Excluir_Click(sender As Object, e As EventArgs) Handles btn_Excluir.Click
        Dim cmdUsuario As New SqlClient.SqlCommand

        If (MessageBox.Show("Deseja Excluir este Usuário?", "Confirmação!", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            strSql = "DELETE FROM Usuario WHERE COD_USUARIO=@COD_USUARIO"
            cmdUsuario.Connection = cnnBanco
            cmdUsuario.CommandText = strSql
            cmdUsuario.Parameters.AddWithValue("@COD_USUARIO", idCLient.ToString)

            Try
                cmdUsuario.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um Erro Inesperado!" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            MessageBox.Show("Usuário Excluido Com Sucesso!", "Confirmação!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdUsuario.Parameters.Clear()
            cmdUsuario = Nothing
            Frm_GerenUsers.Preencher_Grid_Users()
            Me.Close()

        End If
    End Sub

End Class