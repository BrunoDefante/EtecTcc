Imports System.IO
Public Class Frm_GerenUsers
    Private cmbPerfil As String
    Dim diretorio As String
    Public tempinho As String
    Public Function tempo() Handles MyBase.Load
        Dim hora As String = Replace(CDate(Now), "/", "-")
        hora = Replace(hora, ":", "-")
        Return hora
    End Function
    Public Sub Preencher_Grid_Users()
        Try
            strSql = "Select Cod_Usuario, Nome, Perfil, E_Mail, Foto From Usuario " & _
                "Order by Perfil"


            Dim cmdCliente As New SqlClient.SqlCommand(strSql, cnnBanco)
            Dim daCliente As New SqlClient.SqlDataAdapter(cmdCliente)
            Dim tblCliente As New DataTable
            daCliente.Fill(tblCliente)
            dgvConsultaUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            With dgvConsultaUsuario
                .Columns("Foto").Visible = False
            End With

            dgvConsultaUsuario.DataSource = tblCliente


        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro!" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Public Sub PCarregaImagemDataGrid() Handles Timer1.Tick
    '    Dim img As Image
    '    Try
    '        For i As Integer = 0 To dgvConsultaUsuario.RowCount - 1

    '            img = Image.FromFile(dgvConsultaUsuario.Rows(i).Cells("Foto").Value.ToString)
    '            dgvConsultaUsuario.Rows(i).Cells("FotosUsers").Value = img
    '        Next
    '    Catch ex As Exception
    '        Timer1.Enabled = False
    '        MessageBox.Show("Ocorreu um Erro ao Listar as Fotos dos Usuários: " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)    
    '        Exit Sub

    '    End Try

    'End Sub


    Private Sub Frm_GerenUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Preencher_Grid_Users()
        ' Call PCarregaImagemDataGrid()
    End Sub

    Private Sub pintarCampos() Handles Timer1.Tick
        If (txtNome.Text <> "") Then
            txtNome.BackColor = System.Drawing.Color.White
        ElseIf (txtNome.Enabled = True And txtNome.Text = "") Then
            txtNome.BackColor = Color.Yellow
        End If

    End Sub




    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
        Frm_Principal.Show()
    End Sub

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
            PictureBox1.Image = img

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Carregar a imagem para pré-visualização:" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        limpaCampos()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        If (verificaDados() = True) Then
            '--VERIFICANDO O NIVEL DE USÚARIO A SER CADASTRADO--'
            If (combPerfil.SelectedIndex = 0) Then
                cmbPerfil = "Administrador"
            ElseIf (combPerfil.SelectedIndex = 1) Then
                cmbPerfil = "Usuário"
            End If

            Dim cmdCliente As New SqlClient.SqlCommand

            'gravar a imagem na pasta
            Try
                File.Copy(txtUrlImg.Text, diretorio)
            Catch ex As Exception
                MsgBox("Ocorreu Um Erro ao Gravar Imagem: " & vbNewLine & Err.Description, MsgBoxStyle.Critical, "ERRO!")
            End Try
            '------------

            '  strSql = "EXECUTE PR_Cadastrar_Usuario"
            strSql = "Insert into Usuario (Nome,Loginn,Senha, E_Mail,Perfil,Foto)" _
            & "VALUES(@Nome,@Loginn,@Senha,@E_Mail,@Perfil,@Foto)"

            cmdCliente.Connection = cnnBanco
            cmdCliente.CommandText = strSql

            'Substituição das palavras com @ por valores'

            cmdCliente.Parameters.AddWithValue("@Nome", txtNome.Text.Trim)
            cmdCliente.Parameters.AddWithValue("@Loginn", txtLogin.Text.Trim)
            cmdCliente.Parameters.AddWithValue("@Senha", txtSenha.Text.Trim)
            cmdCliente.Parameters.AddWithValue("@E_Mail",
                                               If(txtEmail.Text.Trim = "", DBNull.Value, txtEmail.Text.Trim))
            cmdCliente.Parameters.AddWithValue("@Perfil", cmbPerfil)
            cmdCliente.Parameters.AddWithValue("@Foto", If(diretorio = "", DBNull.Value, diretorio))

            Try
                cmdCliente.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um Erro ao Gravar Dados! " & vbNewLine & Err.Description, _
                                "Gravar Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmdCliente.Parameters.Clear()
                Exit Sub
            End Try

            cmdCliente.Parameters.Clear()

            MessageBox.Show("Usuário Cadastrado Com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Preencher_Grid_Users()
            Call limpaCampos()
            TabPage1.Show()

        End If
    End Sub

    Public Sub limpaCampos()
        '--Habilita Todos os Campos--'
        txtNome.Enabled = True
        txtLogin.Enabled = True
        txtSenha.Enabled = True
        txtConfimSenha.Enabled = True
        txtEmail.Enabled = True
        txtUrlImg.Enabled = False
        combPerfil.Enabled = True
        btn_EnviarFoto.Enabled = True
        btnCadastrar.Enabled = True

        txtNome.Focus()

        '--Limpa Campos--'
        txtNome.Text = ""
        txtLogin.Text = ""
        txtSenha.Text = ""
        txtConfimSenha.Text = ""
        txtEmail.Text = ""
        txtUrlImg.Text = ""
        combPerfil.Text = "Selecione:"






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


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If (MessageBox.Show("Deseja Cancelar o Cadastro ?", "Sair ?", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            frm_Principal.Show()
        Else
            Exit Sub
        End If
    End Sub


    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        idCLient = dgvConsultaUsuario.CurrentRow.Cells(1).Value.ToString
        Frm_EditUser.MdiParent = Frm_Principal
        Frm_EditUser.Show()

    End Sub


End Class