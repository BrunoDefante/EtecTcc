Public Class Frm_GerenFornec

    Public Sub Preencher_Grid_Fornec()
        Try
            strSql = "SELECT * FROM fORNECEDOR " & _
                "ORDER BY Cod_Fornec"

            Dim cmdFornecedor As New SqlClient.SqlCommand(strSql, cnnBanco)
            Dim daFornecedor As New SqlClient.SqlDataAdapter(cmdFornecedor)
            Dim tblFornecedor As New DataTable
            daFornecedor.Fill(tblFornecedor)
            dgvCosultaFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

            dgvCosultaFornecedor.DataSource = tblFornecedor

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro!" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Frm_GerenFornec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Preencher_Grid_Fornec()

    End Sub

    Private Sub btn_Voltar_Click(sender As Object, e As EventArgs) Handles btn_Voltar.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub btn_Novo_Click(sender As Object, e As EventArgs) Handles btn_Novo.Click
        Call Habilita_Limpa_Campos()
    End Sub

    Private Sub btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles btn_Cadastrar.Click
        Dim cmdFornecedor As New SqlClient.SqlCommand

        strSql = "Insert into Fornecedor (Empresa, Nome, Telefone, Produto, E_Mail, Site_Web)" _
            & "Values(@Empresa, @Nome, @Telefone, @Produto, @E_Mail, @Site_Web)"

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
            MessageBox.Show("Ocorreu um Erro ao Gravar Dados!" & vbNewLine & Err.Description, "ERRO!", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdFornecedor.Parameters.Clear()
            Exit Sub
        End Try

        cmdFornecedor.Parameters.Clear()

        MessageBox.Show("Fornecedor Cadastrado Com Sucesso!", "Cadastro!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Preencher_Grid_Fornec()
        Call Habilita_Limpa_Campos()
        Tab_PageGerForn.Show()


    End Sub
    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        idCLient = dgvCosultaFornecedor.CurrentRow.Cells(0).Value.ToString
        Frm_EditFornec.MdiParent = Frm_Principal
        Frm_EditFornec.Show()
    End Sub



    Public Sub Habilita_Limpa_Campos()
        txt_Nome.Enabled = True
        txt_Empresa.Enabled = True
        txt_Produto.Enabled = True
        mskTelefone.Enabled = True
        txt_E_Mail.Enabled = True
        txt_Site.Enabled = True

        'LIMPAR CAMPOS

        txt_Nome.Text = ("")
        txt_Empresa.Text = ("")
        txt_Produto.Text = ("")
        mskTelefone.Text = ("")
        txt_E_Mail.Text = ("")
        txt_Site.Text = ("")

        txt_Nome.Focus()

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

    Private Sub pintaCampo() Handles Timer1.Tick
        If (txt_Nome.Text.Trim = ("") And txt_Nome.Enabled = True) Then
            txt_Nome.BackColor = System.Drawing.Color.Yellow
        Else
            txt_Nome.BackColor = Color.White
        End If
    End Sub


End Class