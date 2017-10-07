Public Class Frm_EditCliente
    Public strAcao As String = "Editar"
    Public tipCliente As String
   
    Private Sub Frm_EditCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim drClientes As SqlClient.SqlDataReader
        Dim cmdClientes As New SqlClient.SqlCommand

        strSql = "SELECT * FROM Dados_Cliente"
        strSql += " Where Cod_Cliente=@Cod_Cliente"

        cmdClientes.Connection = cnnBanco
        cmdClientes.CommandText = strSql

        cmdClientes.Parameters.AddWithValue("@Cod_Cliente", idCLient.ToString)

        Try
            drClientes = cmdClientes.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro inesperado:" & vbNewLine & Err.Description.ToString, "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdClientes.Parameters.Clear()
            Exit Sub
        End Try

        'Verificar Se retornou Resultado

        If Not drClientes.HasRows Then
            MessageBox.Show("Cliente Nâo Cadastrado", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            drClientes.Read()
            txtNome.Text = drClientes("Nome").ToString
            mskDtNasc.Text = Format(drClientes("Dt_Nasc"), "dd/MM/yyyy").ToString

            Dim verificaClient As String = drClientes("Tipo_Cliente").ToString
            If (verificaClient = "Físico") Then
                rbFisico.Checked = True
            Else
                rbJuridico.Checked = True
            End If

            txtEndereco.Text = drClientes("Endereco").ToString
            mskNum.Text = drClientes("Numero").ToString
            txtCidade.Text = drClientes("Cidade").ToString
            txtBairro.Text = drClientes("Bairro").ToString
            txtUf.Text = drClientes("Uf").ToString
            mskCEP.Text = drClientes("Cep").ToString
            mskCpf.Text = ("" & drClientes("Cpf")).ToString
            mskCnpj.Text = ("" & drClientes("Cnpj")).ToString
            txtEmail.Text = ("" & drClientes("E_Mail")).ToString
            mskTelFixo1.Text = ("" & drClientes("Tel_Fixo")).ToString
            mskTelFixo2.Text = ("" & drClientes("Tel_Fixo2")).ToString
            mskCel1.Text = ("" & drClientes("Tel_Cel")).ToString
            mskCel2.Text = ("" & drClientes("Tel_Cel2")).ToString


        End If
        'Limpando o SqlComand
        cmdClientes.Parameters.Clear()
        cmdClientes = Nothing

        drClientes.Close()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub btn_VCancelar_Click(sender As Object, e As EventArgs) Handles btn_VCancelar.Click

        Me.Close()


    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If strAcao = "Editar" Then
            If (rbFisico.Checked = True) Then
                tipCliente = "Físico"

            Else
                tipCliente = "Jurídico"
            End If
            habilitaCampos()
            If (tipCliente = "Físico") Then
                rbFisico.Checked = True
            Else
                rbJuridico.Checked = True
            End If
            strAcao = "Salvar"
            '  btn_Editar.Image = Image.FromFile("C:\Users\bruno\Desktop\icone sistema\novo.png")
            btn_Editar.Text = strAcao
            btn_Excluir.Enabled = True
            Exit Sub
        ElseIf strAcao = "Salvar" Then

            If (MessageBox.Show("Deseja Realmente Alterar os Dados? ", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then

                Dim cmdCliente As New SqlClient.SqlCommand(strSql, cnnBanco)

                If (validaCampos() = True) Then

                    If (rbFisico.Checked = True) Then
                        tipCliente = "Físico"

                    Else
                        tipCliente = "Jurídico"
                    End If

                    strSql = "UPDATE Dados_Cliente SET " & "Nome=@Nome," & "Cpf=@Cpf," & "Cnpj=@Cnpj," & "Dt_Nasc=@Dt_Nasc," & "Tipo_Cliente=@Tipo_Cliente," & "Endereco=@Endereco," _
                       & "Numero=@Numero," & "Cidade=@Cidade," & "Bairro=@Bairro," & "Uf=@Uf," & "Cep=@Cep," & "Tel_Fixo=@Tel_Fixo," & "Tel_Fixo2=@Tel_Fixo2," & "Tel_Cel=@Tel_Cel," & "Tel_Cel2=@Tel_Cel2," & "E_Mail=@E_Mail" & " WHERE Cod_Cliente=@Cod_Cliente"

                    cmdCliente.Connection = cnnBanco
                    cmdCliente.CommandText = strSql

                    'Substituição das palavras com @'
                    cmdCliente.Parameters.AddWithValue("@Cod_Cliente", idCLient.ToString)
                    cmdCliente.Parameters.AddWithValue("@Nome", txtNome.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Cpf", mskCpf.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Cnpj", mskCnpj.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Dt_Nasc", mskDtNasc.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Tipo_Cliente", tipCliente)
                    cmdCliente.Parameters.AddWithValue("@Endereco", txtEndereco.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Numero", mskNum.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Cidade", txtCidade.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Bairro", txtBairro.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Uf", txtUf.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Cep", mskCEP.Text.Trim)
                    cmdCliente.Parameters.AddWithValue("@Tel_Fixo", mskTelFixo1.Text.Trim)

                    cmdCliente.Parameters.AddWithValue("@Tel_Fixo2",
                                                       If(mskTelFixo2.Text.Trim = "", DBNull.Value, mskTelFixo2.Text.Trim))

                    cmdCliente.Parameters.AddWithValue("@Tel_Cel",
                                                       If(mskCel1.Text.Trim = "", DBNull.Value, mskCel1.Text.Trim))

                    cmdCliente.Parameters.AddWithValue("@Tel_Cel2",
                                                       If(mskCel2.Text.Trim = "", DBNull.Value, mskCel2.Text.Trim))

                    cmdCliente.Parameters.AddWithValue("@E_Mail",
                                                       If(txtEmail.Text.Trim = "", DBNull.Value, txtEmail.Text.Trim))

                    Try
                        cmdCliente.ExecuteNonQuery()

                    Catch exc As Exception
                        MessageBox.Show("Ocorreu um erro ao gravar dados " & vbNewLine & Err.Description, "gravar dados", _
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        cmdCliente.Parameters.Clear()
                        Exit Sub
                    End Try


                    cmdCliente.Parameters.Clear()

                    Dim FrmGerenCliente As New Frm_GerenCliente
                    Call FrmGerenCliente.Preencher_Grid_Cliente()

                    MessageBox.Show("Dados Atualizados Com Sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Frm_GerenCliente.Preencher_Grid_Cliente()
                    Me.Close()

                End If
            End If

        End If

    End Sub

    Private Sub btn_Excluir_Click(sender As Object, e As EventArgs) Handles btn_Excluir.Click
        Dim cmdCliente As New SqlClient.SqlCommand

        If (MessageBox.Show("Deseja Realmente Excluir Este Cliente?", "Confirmação!", MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then

            strSql = "DELETE FROM Dados_Cliente WHERE Cod_Cliente=@Cod_Cliente"
            cmdCliente.Connection = cnnBanco
            cmdCliente.CommandText = strSql
            cmdCliente.Parameters.AddWithValue("@Cod_Cliente", idCLient.ToString)

            Try
                cmdCliente.ExecuteNonQuery()
            Catch ex As Exception
                If (Err.Number = 547) Then
                    MessageBox.Show("Ocorreu o Seguinte Erro: " & vbNewLine & "Cliente Possui Pedidos. Não Pode Ser Excluido", _
                                    "Excluir", MessageBoxButtons.OK)

                Else
                    MessageBox.Show("Ocorreu um Erro Inesperado: " & vbNewLine & _
                                Err.Description, "Excluir", MessageBoxButtons.OK)
                End If
            End Try
            MessageBox.Show("Cliente Excluido Com Sucesso!", "Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdCliente.Parameters.Clear()
            cmdCliente = Nothing
            Frm_GerenCliente.Preencher_Grid_Cliente()
            Me.Close()


        End If



    End Sub
    Private Sub habilitaCampos()
        'habilita os Campos
        txtNome.Enabled = True
        mskDtNasc.Enabled = True
        txtEndereco.Enabled = True
        txtCidade.Enabled = True
        txtBairro.Enabled = True
        txtUf.Enabled = True
        mskCEP.Enabled = True
        mskCpf.Enabled = True
        mskCnpj.Enabled = True
        mskTelFixo1.Enabled = True
        mskTelFixo2.Enabled = True
        mskCel1.Enabled = True
        mskCel2.Enabled = True
        groupTel.Enabled = True
        groupCliente.Enabled = True
        rbFisico.Select()
        txtEmail.Enabled = True
        txtUf.Enabled = True
        mskNum.Enabled = True
    End Sub
    Public Function validaCampos()
        If (txtNome.Text.Trim() = ("")) Then
            MsgBox("Preencha o Campo Nome!", MsgBoxStyle.Information)
            txtNome.Focus()
            Return False
        End If


        If (mskDtNasc.Text = ("  /  /")) Then
            MsgBox("Preencha o Campo Data de Nascimento!", MsgBoxStyle.Information)
            mskDtNasc.Focus()
            Return False
        End If

        If (txtEndereco.Text.Trim() = ("")) Then
            MsgBox("Preencha o Campo Endereço!", MsgBoxStyle.Information)
            txtEndereco.Focus()
            Return False
        End If

        If (mskNum.Text = ("")) Then
            MsgBox("Preencha o Campo Número!", MsgBoxStyle.Information)
            mskNum.Focus()
            Return False
        End If

        If (txtCidade.Text.Trim() = ("")) Then
            MsgBox("Preencha o Campo Cidade!", MsgBoxStyle.Information)
            txtCidade.Focus()
            Return False
        End If

        If (txtBairro.Text.Trim() = ("")) Then
            MsgBox("Preencha o Campo Bairro!", MsgBoxStyle.Information)
            txtBairro.Focus()
            Return False
        End If

        If (txtUf.Text.Trim() = ("")) Then
            MsgBox("Preencha o Campo UF!", MsgBoxStyle.Information)
            txtUf.Focus()
            Return False
        End If

        If (mskCEP.Text = ("     -")) Then
            MsgBox("Preencha o Campo CEP!", MsgBoxStyle.Information)
            mskCEP.Focus()
            Return False
        End If
        If (mskTelFixo1.Text = ("(  )     -")) Then
            MsgBox("Preencha o Campo Telefone Fixo 1!", MsgBoxStyle.Information)
            mskTelFixo1.Focus()
            Return False
        End If

        If (rbFisico.Checked And mskCpf.Text = "   .   .   -") Then
            MsgBox("Preencha o Campo C.P.F!", MsgBoxStyle.Information)
            mskCpf.Focus()
            Return False
        ElseIf (rbFisico.Checked And mskCpf.Text <> "   .   .   -") Then
            Dim obj As New Valida_CPF_CNPJ
            obj.cpf = mskCpf.Text
            If obj.isCpfValido = False Then
                MessageBox.Show("CPF Inválido!!!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If

        If (rbJuridico.Checked = True And mskCnpj.Text = ("  .   .   /    -")) Then
            MsgBox("Preencha o Campo CNPJ!", MsgBoxStyle.Information)
            mskCnpj.Focus()
            Return False

        ElseIf (rbJuridico.Checked = True And mskCnpj.Text.Trim <> ("  .   .   /    -")) Then
            Dim obj As New Valida_CPF_CNPJ
            obj.cnpj = mskCnpj.Text
            If (obj.isCnpjValido = False) Then
                MessageBox.Show("CNPJ Inválido!!!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
        End If




        Return True
    End Function


    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress, txtEndereco.KeyPress, txtCidade.KeyPress, txtBairro.KeyPress, txtUf.KeyPress
        bloqueiaNumeros(e)
    End Sub

    Private Sub bloqueiaNumeros(e)
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = True
        End If

    End Sub


    Private Sub mskCpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskCpf.MaskInputRejected

    End Sub
End Class