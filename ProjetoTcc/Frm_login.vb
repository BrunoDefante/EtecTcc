Public Class Frm_login

    Private Sub Frm_login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, txtLogin.KeyDown, txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnLogar.PerformClick()
            btnOK.Select()
        End If
    End Sub


    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Frm_Principal.Show()
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            'Me.Refresh()
            Threading.Thread.Sleep(66)
        Next

        Dim objBanco As New ClsBanco
        Dim strMensagem As String = ""

        cnnBanco = objBanco.AbrirConexao("", strMensagem)

        If cnnBanco.State = ConnectionState.Closed Then
            MessageBox.Show("Ocorreu um Erro: " & strMensagem)
            End
        End If
    End Sub


    Public Function validaCampos()
        If (txtLogin.Text.Trim = "") Then
            MessageBox.Show("Por Favor, Digite Seu Login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLogin.Focus()
            txtLogin.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtLogin.BackColor = System.Drawing.Color.White
        End If

        If (txtSenha.Text.Trim = "") Then
            MessageBox.Show("Por Favor, Digite Sua Senha!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSenha.Focus()
            txtSenha.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtSenha.BackColor = System.Drawing.Color.White
        End If

        Return True
    End Function

    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click
        If validaCampos() = True Then

            Dim drLogi As SqlClient.SqlDataReader
            Dim cmdLogin As New SqlClient.SqlCommand
            strSql = "SELECT * FROM USUARIO WHERE loginn= '" & txtLogin.Text.Trim & "' AND Senha= '" & txtSenha.Text.Trim & "'"
            cmdLogin.Connection = cnnBanco
            cmdLogin.CommandText = strSql

            Try
                drLogi = cmdLogin.ExecuteReader
            Catch ex As Exception
                MsgBox(Err.Description)
                cmdLogin.Parameters.Clear()
                Exit Sub
            End Try

            Try
                If (Not drLogi.HasRows) Then
                    MessageBox.Show("Senha ou Usuário, Inválidos!!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    drLogi.Read()
                    Users = drLogi("Loginn").ToString

                    PMsgBox.Visible = True
                    LbUser.Text = Users

                End If
            Catch ex As Exception
                MessageBox.Show("Ocorreu um Erro : " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



            cmdLogin.Parameters.Clear()
            cmdLogin = Nothing
            drLogi.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If (MessageBox.Show("A aplicação irá Fechar, Deseja Continuar ?", "Confirmação", _
                            MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            For FadeIn = 90 To 10 Step -10
                Me.Opacity = FadeIn / 100
                ' Me.Refresh()
                Threading.Thread.Sleep(66)
            Next
            Me.Hide()
            Me.Close()
        End If
    End Sub



    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        PMsgBox.Visible = False

        For FadeIn = 90 To 10 Step -10
            Me.Opacity = FadeIn / 100
            ' Me.Refresh()
            Threading.Thread.Sleep(66)
        Next

        Me.Hide()
        Frm_Principal.Show()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Data.Text = CDate(Now)
    End Sub


End Class