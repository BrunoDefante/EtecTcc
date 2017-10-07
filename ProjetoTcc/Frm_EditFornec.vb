Public Class Frm_EditFornec
    Private strAcao = "Editar"
    Private Sub Frm_EditFornec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strAcao = "Editar"
        Dim drFornecedor As SqlClient.SqlDataReader
        Dim cmdFornecedor As New SqlClient.SqlCommand

        strSql = "SELECT * FROM FORNECEDOR"
        strSql += " WHERE COD_FORNEC=@COD_FORNEC"

        cmdFornecedor.Connection = cnnBanco
        cmdFornecedor.CommandText = strSql

        cmdFornecedor.Parameters.AddWithValue("@COD_FORNEC", idCLient.ToString)

        Try
            drFornecedor = cmdFornecedor.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro Inesperado!" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdFornecedor.Parameters.Clear()
            Exit Sub
        End Try

        Try
            If Not drFornecedor.HasRows Then
                MessageBox.Show("Nenhum Fornecedor Cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                drFornecedor.Read()
                txt_Nome.Text = drFornecedor("Nome").ToString
                txt_Empresa.Text = drFornecedor("Empresa").ToString
                mskTelefone.Text = drFornecedor("Telefone").ToString
                txt_Produto.Text = drFornecedor("Produto").ToString
                txt_E_Mail.Text = drFornecedor("E_Mail").ToString
                txt_Site.Text = drFornecedor("Site_Web").ToString

            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro Inesperado!" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cmdFornecedor.Parameters.Clear()
        cmdFornecedor = Nothing
        drFornecedor.Close()
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If (strAcao = "Editar") Then
            Call HabilitaCampos()
            btn_Editar.Text = strAcao
        ElseIf (strAcao = "Gravar") Then
            If (MessageBox.Show("Deseja Realmente Alterar os Dados? ", "Alterar!", _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                Dim cmdFornecedor As New SqlClient.SqlCommand(strAcao, cnnBanco)
                If (validaCampos() = True) Then
                    strSql = "UPDATE FORNECEDOR SET " & "Empresa=@Empresa," & "Nome=@Nome," & "Telefone=@Telefone," & "Produto=@Produto," _
                        & "E_Mail=@E_Mail," & "Site_Web=@Site_Web"

                    cmdFornecedor.Connection = cnnBanco
                    cmdFornecedor.CommandText = strSql

                    cmdFornecedor.Parameters.AddWithValue("@Empresa", txt_Empresa.Text.Trim)
                    cmdFornecedor.Parameters.AddWithValue("@Nome", txt_Nome.Text.Trim)
                    cmdFornecedor.Parameters.AddWithValue("@Telefone", mskTelefone.Text.Trim)
                    cmdFornecedor.Parameters.AddWithValue("@Produto", txt_Produto.Text.Trim)
                    cmdFornecedor.Parameters.AddWithValue("@E_Mail", _
                                                          If(txt_E_Mail.Text.Trim = "", DBNull.Value, txt_E_Mail.Text.Trim))
                    cmdFornecedor.Parameters.AddWithValue("@Site_Web", _
                                                          If(txt_Site.Text.Trim = "", DBNull.Value, txt_Site.Text.Trim))
                    Try
                        cmdFornecedor.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("Ocorreu um Erro ao Atualizar os Dados!" & vbNewLine & Err.Description, "ERRO!", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cmdFornecedor.Parameters.Clear()
                        Exit Sub
                    End Try
                    cmdFornecedor.Parameters.Clear()
                    MessageBox.Show("Dados Atualizados Com Sucesso!", "Confirmação!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call Frm_GerenFornec.Preencher_Grid_Fornec()
                    Call Frm_GerenFornec.Refresh()
                    Me.Close()

                End If
            End If

        End If
    End Sub

    Private Sub btn_Excluir_Click(sender As Object, e As EventArgs) Handles btn_Excluir.Click
        Dim cmdFornec As New SqlClient.SqlCommand

        If (MessageBox.Show("Deseja Excluir Este Fornecedor? ", "Confirmação!", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            strSql = "DELETE FROM Fornecedor WHERE Cod_Fornec=@Cod_Fornec"
            cmdFornec.Connection = cnnBanco
            cmdFornec.CommandText = strSql
            cmdFornec.Parameters.AddWithValue("@Cod_Fornec", idCLient.ToString)

            Try
                cmdFornec.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um Erro Inesperado!" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmdFornec.Parameters.Clear()
                Exit Sub
            End Try
            MessageBox.Show("Fornecedor Excluído Com Sucesso!", "Confirmação!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdFornec.Parameters.Clear()
            cmdFornec = Nothing
            Frm_GerenFornec.Preencher_Grid_Fornec()
            Frm_GerenFornec.Refresh()
            Me.Close()
        End If

    End Sub

    Public Function validaCampos()
        If txt_Nome.Text.Trim = ("") Then
            MessageBox.Show("Preencha o Campo Nome!", "VALIDAÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_Nome.Focus()
            txt_Nome.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txt_Nome.BackColor = Color.White
        End If

        If txt_Empresa.Text.Trim = ("") Then
            MessageBox.Show("Preencha o Campo Empresa!", "VALIDAÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_Empresa.Focus()
            txt_Empresa.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txt_Empresa.BackColor = Color.White
        End If

        If txt_Produto.Text.Trim = ("") Then
            MessageBox.Show("Preencha o Campo Produto!", "VALIDAÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_Produto.Focus()
            txt_Produto.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txt_Produto.BackColor = Color.White
        End If

        If mskTelefone.Text.Trim = ("") Then
            MessageBox.Show("Preencha o Campo Telefone!", "VALIDAÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mskTelefone.Focus()
            mskTelefone.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            mskTelefone.BackColor = Color.White
        End If

        Return True
    End Function

    Public Sub HabilitaCampos()
        txt_Nome.Enabled = True
        txt_Empresa.Enabled = True
        txt_Produto.Enabled = True
        mskTelefone.Enabled = True
        txt_E_Mail.Enabled = True
        txt_Site.Enabled = True
        strAcao = "Gravar"
        txt_Nome.Focus()

    End Sub

  
    
End Class