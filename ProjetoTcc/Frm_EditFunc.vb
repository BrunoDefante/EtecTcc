Imports System.IO
Public Class Frm_EditFunc
    Private strAcao As String = "Alterar"
    Private img As Image
    Private diretorio, diretorio2 As String
    Private civil, instrucao, funcao As String

    Public Function tempo() Handles MyBase.Load
        Dim hora As String = Replace(CDate(Now), "/", "-")
        hora = Replace(hora, ":", "-")
        Return hora
    End Function

    Private Sub Frm_EditFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strAcao = "Editar"
        Dim drFuncionario As SqlClient.SqlDataReader
        Dim cmdFuncionario As New SqlClient.SqlCommand
        strSql = "SELECT * FROM FUNCIONARIOS"
        strSql += " WHERE COD_FUNC=@COD_FUNC"

        cmdFuncionario.Connection = cnnBanco
        cmdFuncionario.CommandText = strSql

        cmdFuncionario.Parameters.AddWithValue("@COD_FUNC", idCLient.ToString)

        Try
            drFuncionario = cmdFuncionario.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro Inesperado! " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdFuncionario.Parameters.Clear()

            Exit Sub
        End Try

        Try
            If Not drFuncionario.HasRows Then
                MessageBox.Show("Nenhum Fornecedor Cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                drFuncionario.Read()
                txtNome.Text = drFuncionario("Nome").ToString
                mskCpf.Text = drFuncionario("Cpf").ToString
                mskDtNasc.Text = drFuncionario("Dt_Nasc").ToString

                Dim civil As String = drFuncionario("Estado_Civil").ToString
                If (civil = "Casado") Then
                    combEstadoCivil.SelectedIndex = 1
                ElseIf (civil = "Solteiro") Then
                    combEstadoCivil.SelectedIndex = 2
                ElseIf (civil = "Separado") Then
                    combEstadoCivil.SelectedIndex = 3
                End If

                Dim instrucao As String = drFuncionario("Grau_Instrucao").ToString
                If (instrucao = "Ensino Fundamental Incompleto") Then
                    combInstrucao.SelectedIndex = 1
                ElseIf (instrucao = "Ensino Fundamental Completo") Then
                    combInstrucao.SelectedIndex = 2
                ElseIf (instrucao = "Ensino Médio Incompleto") Then
                    combInstrucao.SelectedIndex = 3
                ElseIf (instrucao = "Ensino Médio Completo") Then
                    combInstrucao.SelectedIndex = 4
                ElseIf (instrucao = "Ensino Superior Imcompleto") Then
                    combInstrucao.SelectedIndex = 5
                ElseIf (instrucao = "Ensino Superior Completo") Then
                    combInstrucao.SelectedIndex = 6
                End If

                txtNomeMae.Text = drFuncionario("Nome_Mae").ToString
                txtNomePai.Text = drFuncionario("Nome_Pai").ToString
                txtEMail.Text = drFuncionario("E_Mail").ToString
                txtUrlFoto.Text = drFuncionario("Foto").ToString
                mskTelFixo1.Text = drFuncionario("Tel_Fixo").ToString
                mskTelFixo2.Text = drFuncionario("Tel_Fixo2").ToString
                mskCel1.Text = drFuncionario("Tel_Cel").ToString
                mskCel2.Text = drFuncionario("Tel_Cel2").ToString
                mskCEP.Text = drFuncionario("Cep").ToString
                txtEndereco.Text = drFuncionario("Endereco").ToString
                mskNum.Text = drFuncionario("Numero").ToString
                txtComplemento.Text = drFuncionario("Complemento").ToString
                txtBairro.Text = drFuncionario("Bairro").ToString
                txtUF.Text = drFuncionario("Uf").ToString
                txtCidade.Text = drFuncionario("Cidade").ToString

                Dim funcao As String = drFuncionario("Funcao").ToString
                If (funcao = "Montador") Then
                    combFuncao.SelectedIndex = 1
                ElseIf (funcao = "Limpeza") Then
                    combFuncao.SelectedIndex = 2
                ElseIf (funcao = "Atendente") Then
                    combFuncao.SelectedIndex = 3
                ElseIf (funcao = "Repositor") Then
                    combFuncao.SelectedIndex = 4
                ElseIf (funcao = "Vendedor") Then
                    combFuncao.SelectedIndex = 5
                End If


                mskHoraEntrada.Text = FormatDateTime(drFuncionario("Horario_Entrada").ToString)
                mskHoraSaida.Text = FormatDateTime(drFuncionario("Horario_Saida").ToString)
                txtSalario.Text = FormatCurrency(drFuncionario("Salario").ToString)

                Dim comissao As Double = drFuncionario("Comissao_Vendas").ToString
                comissao = comissao / 100
                txtComisao.Text = (FormatPercent(comissao))

                img = Image.FromFile(txtUrlFoto.Text.ToString)
                Pic_Foto.Image = img
                diretorio = txtUrlFoto.Text.ToString
                drFuncionario.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro: " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            drFuncionario.Close()
            Exit Sub
        End Try
        cmdFuncionario.Parameters.Clear()
        cmdFuncionario = Nothing
        drFuncionario.Close()

        'Para Renomear o nome das Imagens Para Hora
        'Dim hora As String = TimeOfDay

        'My.Computer.FileSystem.RenameFile(diretorio, Replace(hora, ":", "-")+".Jpg")
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        If (strAcao = "Gravar") Then
            If MessageBox.Show("Deseja Voltar ?" & vbNewLine & "Dados Não Salvos Vão ser Perdidos!", "Sair?", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                Me.Close()
            End If
        Else
            Me.Hide()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click

        diretorio2 = txtUrlFoto.Text
        If (strAcao = "Editar") Then
            Call habilitaCampos()
            btn_Editar.Text = strAcao
        ElseIf (strAcao = "Gravar") Then
            If MessageBox.Show("Deseja Realmente Alterar os Dados?", "Alterar!", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim cmdFuncionario As New SqlClient.SqlCommand(strSql, cnnBanco)
                If (verificaDados() = True) Then
                    If combEstadoCivil.SelectedIndex = 1 Then
                        civil = "Casado"
                    ElseIf combEstadoCivil.SelectedIndex = 2 Then
                        civil = "Solteiro"
                    ElseIf combEstadoCivil.SelectedIndex = 3 Then
                        civil = "Separado"
                    End If

                    Select Case combInstrucao.SelectedIndex
                        Case 1
                            instrucao = "Ensino Fundamental Incompleto"
                        Case 2
                            instrucao = "Ensino Fundamental Completo"
                        Case 3
                            instrucao = "Ensino Médio Incompleto"
                        Case 4
                            instrucao = "Ensino Médio Completo"
                        Case 5
                            instrucao = " Ensino Superior Imcompleto"
                        Case 6
                            instrucao = "Ensino Superior Completo"
                    End Select

                    Select Case combFuncao.SelectedIndex
                        Case 1
                            funcao = "Montador"
                        Case 2
                            funcao = "Limpeza"
                        Case 3
                            funcao = "Atendente"
                        Case 4
                            funcao = "Repositor"
                        Case 5
                            funcao = "Vendedor"
                    End Select

                    If (verificaDados() = True) Then
                        strSql = "EXECUTE PR_EDIT_FUNC @Nome, @Cpf, @Dt_Nasc, @Estado_Civil, @Grau_Instrucao, @Nome_Mae, @Nome_Pai, @E_Mail, @foto, @Tel_Fixo, @Tel_Fixo2, @Tel_Cel, @Tel_Cel2, @Cep, " _
              & "@Endereco, @Numero, @Complemento, @Bairro, @Uf, @Cidade, @Funcao, @Horario_Entrada, @Horario_Saida, @Salario, @Comissao_Vendas"
                        If File.Exists(diretorio) = True Then
                        Else
                            File.Copy(txtUrlFoto.Text, diretorio)
                        End If

                        cmdFuncionario.Connection = cnnBanco
                        cmdFuncionario.CommandText = strSql

                        cmdFuncionario.Parameters.AddWithValue("@Nome", txtNome.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Cpf", mskCpf.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Dt_Nasc", mskDtNasc.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Estado_Civil", civil)
                        cmdFuncionario.Parameters.AddWithValue("@Grau_Instrucao", instrucao)
                        cmdFuncionario.Parameters.AddWithValue("@Nome_Mae", txtNomeMae.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Nome_Pai", txtNomePai.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@E_Mail", txtEMail.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Foto", diretorio.ToString)
                        cmdFuncionario.Parameters.AddWithValue("@Tel_Fixo", mskTelFixo1.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Tel_Fixo2",
                                                                If(mskTelFixo2.Text.Trim = "", DBNull.Value, mskTelFixo2.Text.Trim))
                        cmdFuncionario.Parameters.AddWithValue("@Tel_Cel",
                                                                If(mskCel1.Text.Trim = "", DBNull.Value, mskCel1.Text.Trim))
                        cmdFuncionario.Parameters.AddWithValue("@Tel_Cel2",
                                                               If(mskCel2.Text.Trim = "", DBNull.Value, mskCel2.Text.Trim))
                        cmdFuncionario.Parameters.AddWithValue("@Cep", mskCEP.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Endereco", txtEndereco.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Numero", mskNum.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Complemento",
                                                               If(txtBairro.Text.Trim = "", DBNull.Value, txtComplemento.Text.Trim))
                        cmdFuncionario.Parameters.AddWithValue("@Bairro", txtUF.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Uf", txtUF.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Cidade", txtCidade.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Funcao", funcao.ToString)
                        cmdFuncionario.Parameters.AddWithValue("@Horario_Entrada", mskHoraEntrada.Text.Trim)
                        cmdFuncionario.Parameters.AddWithValue("@Horario_Saida", mskHoraSaida.Text.Trim)
                        Dim valorSalario As String
                        valorSalario = Replace(txtSalario.Text.Trim, "R$", "")
                        cmdFuncionario.Parameters.AddWithValue("@Salario", Replace(valorSalario, ",", "."))
                        cmdFuncionario.Parameters.AddWithValue("@Comissao_Vendas",
                                                               If(txtComisao.Text.Trim = "", DBNull.Value, txtComisao.Text.Trim))

                        Try
                            cmdFuncionario.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("Ocorreu um Erro ao Atualizar Os Dados!" & vbNewLine & Err.Description, "ERRO!", _
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                            cmdFuncionario.Parameters.Clear()
                            Exit Sub
                        End Try
                        cmdFuncionario.Parameters.Clear()
                        MessageBox.Show("Dados Atualizados com Sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call Frm_GerenFuncionario.Preencher_Grid_Func()
                        '   Call Frm_GerenFuncionario.PCarregaImagemDataGrid()
                        Call Frm_GerenFuncionario.Refresh()
                        Me.Close()
                    End If

                End If

            End If
        End If
    End Sub

    Public Function verificaDados()
        If (txtNome.Text.Trim = "") Then
            MessageBox.Show("O Campo Nome, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (mskCpf.Text.Trim = "   .   .   -") Then
            MessageBox.Show("O Campo C.P.F, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (mskDtNasc.Text = "  /  /") Then
            MessageBox.Show("O Campo Data de Nascimento, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (combEstadoCivil.SelectedIndex = 0) Then
            MessageBox.Show("Por Favor Selecione o Estado Civil!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (combInstrucao.SelectedIndex = 0) Then
            MessageBox.Show("Por Favor Selecione o Grau de Instrução!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtNomeMae.Text.Trim = "") Then
            MessageBox.Show("O Campo Nome da Mãe, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtNomePai.Text.Trim = "") Then
            MessageBox.Show("O Campo Nome do Pai, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtUrlFoto.Text.Trim = "") Then
            MessageBox.Show("Por Favor, Selecione A Foto do Funcionário!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (mskTelFixo1.Text = ("(  )     -")) Then
            MessageBox.Show("O Campo Telefone Fixo 1, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (mskCEP.Text = "     -") Then
            MessageBox.Show("O Campo CEP, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtEndereco.Text.Trim = "") Then
            MessageBox.Show("O Campo Endereço, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (mskNum.Text.Trim = "") Then
            MessageBox.Show("O Campo Número, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtBairro.Text.Trim = "") Then
            MessageBox.Show("O Campo Bairro, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtUF.Text.Trim = "") Then
            MessageBox.Show("O Campo UF, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtCidade.Text.Trim = "") Then
            MessageBox.Show("O Campo Cidade, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (combFuncao.SelectedIndex = 0) Then
            MessageBox.Show("Por Favor, Preencha a Função Para o Funcionário!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (mskHoraEntrada.Text = "00:00" And mskHoraSaida.Text = "00:00") Then
            MessageBox.Show("Os Campos de Horário Devem Ser Preenchidos!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If (txtSalario.Text.Trim = "") Then
            MessageBox.Show("O Campo Salário, é de Preenchimento Obrigatório!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True

    End Function
    Public Sub habilitaCampos()
        txtNome.Enabled = True
        mskCpf.Enabled = True
        mskDtNasc.Enabled = True
        combEstadoCivil.Enabled = True
        combInstrucao.Enabled = True
        txtNomeMae.Enabled = True
        txtNomePai.Enabled = True
        txtEMail.Enabled = True
        txtUrlFoto.Enabled = True
        btn_EnviarFoto.Enabled = True
        btn_EnviarFoto.Text = "..."
        strAcao = "Gravar"
        mskTelFixo1.Enabled = True
        mskTelFixo2.Enabled = True
        groupTel.Enabled = True
        mskCel1.Enabled = True
        mskCel2.Enabled = True
        mskCEP.Enabled = True
        txtEndereco.Enabled = True
        mskNum.Enabled = True
        txtComplemento.Enabled = True
        txtBairro.Enabled = True
        txtUF.Enabled = True
        txtCidade.Enabled = True
        combFuncao.Enabled = True
        mskHoraEntrada.Enabled = True
        mskHoraSaida.Enabled = True
        txtSalario.Enabled = True
        txtComisao.Enabled = True

        txtNome.Focus()
    End Sub

    Private Sub btn_EnviarFoto_Click(sender As Object, e As EventArgs) Handles btn_EnviarFoto.Click
        Dim OpenImg As New OpenFileDialog

        OpenImg.Filter = "ARQUIVO *.Jpg|*.jpg|ARQUIVO *.Jpeg|*.jpeg|ARQUIVO *.Png|*.png"

        If OpenImg.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtUrlFoto.Text = OpenImg.FileName
        Else
            Exit Sub
        End If
        Dim img As Image
        Try

            img = Image.FromFile(txtUrlFoto.Text.ToString)
            diretorio = "C:\imagemBanco\Funcionario" + "\" + Replace(tempo, ":", "-") + ".Jpg"
            Pic_Foto.Image = img

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Carregar a imagem para pré-visualização:" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Excluir_Click(sender As Object, e As EventArgs) Handles btn_Excluir.Click
        Dim cmdFuncionario As New SqlClient.SqlCommand
        If (MessageBox.Show("Deseja Excluir Este Funcionário? ", "Confirmação!", _
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            strAcao = "EXECUTE PR_DEL_FUNC @Cod_Func"

            cmdFuncionario.Connection = cnnBanco
            cmdFuncionario.CommandText = strSql
            cmdFuncionario.Parameters.AddWithValue("@Cod_Func", idCLient.ToString)

            Try
                cmdFuncionario.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um Erro Inesperado!" & vbNewLine & Err.Description, "Deletar", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmdFuncionario.Parameters.Clear()
                Exit Sub
            End Try
            MessageBox.Show("Funcionário Excluído Com Sucesso!", "Excluír", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdFuncionario.Parameters.Clear()
            cmdFuncionario = Nothing
            Frm_GerenFuncionario.Preencher_Grid_Func()
            Frm_GerenFuncionario.Refresh()
            Me.Close()
        End If
    End Sub
End Class