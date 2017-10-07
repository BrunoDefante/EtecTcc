Public Class Frm_GerenCliente
    Public tipCliente As String

    Public Sub Preencher_Grid_Cliente()
        Try
            strSql = "Select Cod_Cliente, Nome, Cpf, Cnpj, Dt_Nasc, Tel_Fixo From Dados_Cliente " & _
                "Order by Nome"

            Dim cmdCliente As New SqlClient.SqlCommand(strSql, cnnBanco)
            Dim daCliente As New SqlClient.SqlDataAdapter(cmdCliente)
            Dim tblCliente As New DataTable
            daCliente.Fill(tblCliente)
            dgvConsultaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvConsultaCliente.DataSource = tblCliente

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Frm_GerenCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Preencher_Grid_Cliente()

    End Sub

    Private Sub btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles btn_Cadastrar.Click
        If (validaCampos() = True) Then

            If (rbFisico.Checked = True) Then
                tipCliente = "Físico"

            Else
                tipCliente = "Jurídico"
            End If

            Dim cmdCliente As New SqlClient.SqlCommand

            'strSql = "INSERT INTO Dados_Cliente" & "(Nome,Cpf,Cnpj,Dt_Nasc,Tipo_Cliente,Endereco,Numero,Cidade,Bairro,Uf,Cep,Tel_Fixo,Tel_Fixo2,Tel_Cel,Tel_Cel2,E_Mail)" _
            '& "VALUES(@Nome,@Cpf,@Cnpj,@Dt_Nasc,@Tipo_Cliente,@Endereco,@Numero,@Cidade,@Bairro,@Uf,@Cep,@Tel_Fixo,@Tel_Fixo2,@Tel_Cel,@Tel_Cel2,@E_Mail)"

            strSql = "Execute PR_CadastrarCliente @Nome,@Cpf,@Cnpj,@Dt_Nasc,@Tipo_Cliente,@Endereco,@Numero,@Cidade,@Bairro,@Uf,@Cep,@Tel_Fixo,@Tel_Fixo2,@Tel_Cel,@Tel_Cel2,@E_Mail"

            cmdCliente.Connection = cnnBanco
            cmdCliente.CommandText = strSql

            'Substituição das palavras com @'

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

                If Err.Number = 5 Then
                    MessageBox.Show("Cliente Já Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    MessageBox.Show("Ocorreu um erro ao gravar dados " & vbNewLine & Err.Description, "gravar dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmdCliente.Parameters.Clear()
                    Exit Sub
                End If
            End Try


            cmdCliente.Parameters.Clear()


            Call Preencher_Grid_Cliente()
            Call limpaCampos()
            TabControl1.SelectedIndex = 0
            If MessageBox.Show("Deseja Realizar Uma Venda, do Cliente Cadastrado ?", "Venda", MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                Me.Close()
                Dim objVenda As Frm_Vendas = Frm_Vendas
                objVenda.MdiParent = Frm_Principal
                objVenda.Show()
            End If

        End If
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click

        If MessageBox.Show("Tem Certeza Que Deseja Cancelar o Cadastro?", "Cancelar!", MessageBoxButtons.YesNo, _
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Me.Close()
            frm_Principal.Show()
        End If
    End Sub

    Private Sub btn_Novo_Click(sender As Object, e As EventArgs) Handles btn_Novo.Click
        limpaCampos()
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
        frm_Principal.Show()
    End Sub

    Private Sub pintarCampos() Handles Timer1.Tick
        If (txtNome.Text <> "") Then
            txtNome.BackColor = System.Drawing.Color.White
        ElseIf (txtNome.Enabled = True And txtNome.Text = "") Then
            txtNome.BackColor = Color.Yellow
        End If
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

    Public Sub limpaCampos()
        'habilita os Campos
        btn_Cadastrar.Enabled = True
        txtNome.BackColor = System.Drawing.Color.Yellow
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
        '--Limpa Campos e Prepara para Novo Cadastro--'

        txtNome.Text = ("")
        mskDtNasc.Text = ("")
        txtEndereco.Text = ("")
        txtCidade.Text = ("")
        txtBairro.Text = ("")
        mskTelFixo1.Text = ("")
        mskTelFixo2.Text = ("")
        mskCel1.Text = ("")
        mskCel2.Text = ("")
        txtUf.Text = ("")
        mskNum.Text = ("")
        txtEmail.Text = ("")
        mskCEP.Text = ("")
        mskCpf.Text = ("")
        mskCnpj.Text = ("")
        txtUf.Text = ("")


        txtNome.Focus()




    End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click

        Dim ConsultClient As Frm_EditCliente = Frm_EditCliente
        Dim Principal As Frm_Principal = Frm_Principal

        idCLient = dgvConsultaCliente.CurrentRow.Cells(0).Value.ToString
        ConsultClient.MdiParent = Principal
        ConsultClient.Show()

    End Sub

    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUf.KeyPress, txtNome.KeyPress, txtEndereco.KeyPress, txtCidade.KeyPress, txtBairro.KeyPress, txtUf.KeyPress
        'bloqueiaNumeros(e)
    End Sub

    Private Sub bloqueiaNumeros(e)
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = True
        End If

        If (Char.IsDigit(e.keyNumber)) Then
            e.handled = True
        End If

    End Sub


End Class