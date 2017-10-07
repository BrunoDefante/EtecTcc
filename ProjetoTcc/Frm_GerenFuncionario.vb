Imports System.IO
Public Class Frm_GerenFuncionario
    Private diretorio As String
    Private civil, instrucao, funcao As String
    Private tempinho As String

    Public Function tempo() Handles MyBase.Load
        Dim hora As String = Replace(CDate(Now), "/", "-")
        hora = Replace(hora, ":", "-")
        Return hora
    End Function

    Public Sub Preencher_Grid_Func()
        Try
            strSql = "Select Cod_Func, Nome, Cpf, E_Mail, Foto, Horario_Entrada, Horario_Saida From Funcionarios" & _
                " Order by Cod_Func"
            Dim cmdFuncionario As New SqlClient.SqlCommand(strSql, cnnBanco)
            Dim daFuncionario As New SqlClient.SqlDataAdapter(cmdFuncionario)
            Dim tblFuncionario As New DataTable
            daFuncionario.Fill(tblFuncionario)
            dgvConsultaFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            With dgvConsultaFuncionario
                .Columns("Foto").Visible = False
            End With

            dgvConsultaFuncionario.DataSource = tblFuncionario
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro!" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Public Sub PCarregaImagemDataGrid() Handles Timer1.Tick
    '    Dim img As Image
    '    Try
    '        For i As Integer = 0 To dgvConsultaFuncionario.RowCount - 1
    '            img = Image.FromFile(dgvConsultaFuncionario.Rows(i).Cells("Foto").Value.ToString)
    '            dgvConsultaFuncionario.Rows(i).Cells("FotosFunc").Value = img
    '        Next
    '    Catch ex As Exception
    '        Timer1.Enabled = False
    '        MessageBox.Show("Ocorreu um Erro ao Listar as Fotos dos Usuários: " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub

    '    End Try
    'End Sub

    Private Sub Frm_GerenFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Preencher_Grid_Func()
    End Sub

    Private Sub TextBox13_LostFocus(sender As Object, e As EventArgs) Handles txtSalario.LostFocus
        Dim val As Double
        If txtSalario.Text.Trim = "" Then
            Exit Sub
        Else
            val = txtSalario.Text
            txtSalario.Text = FormatCurrency(val)
        End If

    End Sub

    Private Sub txtSalario_keyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalario.KeyPress, txtComisao.KeyPress
        bloqueiaLetras(e)
    End Sub

    Private Sub bloqueiaLetras(e)
        If (Char.IsLetter(e.keyChar)) Then
            e.handled = True
        ElseIf (Char.IsPunctuation(e.keyChar)) Then
            e.handled = True
        ElseIf (Char.IsSymbol(e.keyChar)) Then
            e.handled = True
        End If
    End Sub

    Private Sub mskHoraEntrada_Click(sender As Object, e As EventArgs) Handles mskHoraEntrada.Click, mskHoraEntrada.GotFocus
        mskHoraEntrada.SelectAll()
    End Sub

    Private Sub mskHoraSaida_Click(sender As Object, e As EventArgs) Handles mskHoraSaida.Click, mskHoraSaida.GotFocus
        mskHoraSaida.SelectAll()
    End Sub

    Private Sub btn_Novo_Click(sender As Object, e As EventArgs) Handles btn_Novo.Click
        habilitaCampos()
        limpaCampos()
    End Sub


    Private Sub btn_Gravar_Click(sender As Object, e As EventArgs) Handles btn_Gravar.Click
        If verificaDados() = True Then
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



            Dim cmdFuncionario As New SqlClient.SqlCommand

            Try
                File.Copy(txtUrlFoto.Text, diretorio)
            Catch ex As Exception
                MsgBox("Ocorreu um Erro ao Gravar Imagem: " & vbNewLine & Err.Description, MsgBoxStyle.Critical, "ERRO!")
            End Try


            strSql = "EXECUTE PR_INC_FUNC @Nome, @Cpf, @Dt_Nasc, @Estado_Civil, @Grau_Instrucao, @Nome_Mae, @Nome_Pai, @E_Mail, @foto, @Tel_Fixo, @Tel_Fixo2, @Tel_Cel, @Tel_Cel2, @Cep, " _
              & "@Endereco, @Numero, @Complemento, @Bairro, @Uf, @Cidade, @Funcao, @Horario_Entrada, @Horario_Saida, @Salario, @Comissao_Vendas"

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
                MessageBox.Show("Ocorreu um Erro ao Gravar Dados! " & vbNewLine & Err.Description, "Gravar Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmdFuncionario.Parameters.Clear()
                Exit Sub
            End Try

            cmdFuncionario.Parameters.Clear()

            Call Preencher_Grid_Func()
            Call limpaCampos()
            MsgBox("Funcipnário Cadastrado Com Sucesso!", MsgBoxStyle.Information, "Gravar Dados")

        End If
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        If (MessageBox.Show("Deseja Cancelar o Cadastro ?", "Cancelar ?", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Hide()
            Me.Close()
        End If
    End Sub


    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Hide()
        Me.Close()
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
            tempinho = tempo()
            Pic_Foto.Image = img

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Carregar a imagem para pré-visualização:" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
        btn_Gravar.Enabled = True
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

    Public Sub limpaCampos()
        txtNome.Text = ""
        mskCpf.Text = ""
        mskDtNasc.Text = ""
        combEstadoCivil.Text = ""
        combInstrucao.Text = ""
        txtNomeMae.Text = ""
        txtNomePai.Text = ""
        txtEMail.Text = ""
        txtUrlFoto.Text = ""
        btn_EnviarFoto.Text = ""
        mskTelFixo1.Text = ""
        mskTelFixo2.Text = ""
        groupTel.Text = ""
        mskCel1.Text = ""
        mskCel2.Text = ""
        mskCEP.Text = ""
        txtEndereco.Text = ""
        mskNum.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtUF.Text = ""
        txtCidade.Text = ""
        combFuncao.Text = ""
        mskHoraEntrada.Text = "0000"
        mskHoraSaida.Text = "0000"
        txtSalario.Text = ""
        txtComisao.Text = ""
    End Sub


    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        idCLient = dgvConsultaFuncionario.CurrentRow.Cells(1).Value.ToString
        Dim consultFunc As Frm_EditFunc = Frm_EditFunc
        Dim principal As Frm_Principal = Frm_Principal
        consultFunc.MdiParent = principal
        consultFunc.Show()
    End Sub
End Class