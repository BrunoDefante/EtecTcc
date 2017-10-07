Imports System.IO
Public Class Frm_EditProd
    Private strAcao, diretorio As String
    Private img As Image

    Public Function tempo() Handles MyBase.Load
        Dim hora As String = Replace(CDate(Now), "/", "-")
        hora = Replace(hora, ":", "-")
        Return hora
    End Function

    Private Sub Frm_EditProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strAcao = "Editar"
        Dim drProduto As SqlClient.SqlDataReader
        Dim cmdProduto As New SqlClient.SqlCommand

        strSql = "SELECT * FROM Produto"
        strSql += " WHERE COD_Produto=@Cod_Produto"

        cmdProduto.Connection = cnnBanco
        cmdProduto.CommandText = strSql


        cmdProduto.Parameters.AddWithValue("@Cod_Produto", idCLient.ToString)
        Try
            drProduto = cmdProduto.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro Inesperado!" & vbNewLine & Err.Description.ToString, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdProduto.Parameters.Clear()
            Exit Sub
        End Try

        '--Verificar se Retornou Dados--'
        Try
            If Not drProduto.HasRows Then
                MessageBox.Show("Nenhum Produto Cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                drProduto.Read()
                txtNomeProd.Text = drProduto("Nome_Produto").ToString
                txtTipo.Text = drProduto("Tipo_Produto").ToString
                txtDescricao.Text = drProduto("Descricao").ToString
                txtCodFornec.Text = drProduto("Cod_Fornecedor").ToString
                txtCusto.Text = Format(drProduto("Custo"), "#,##0.00").ToString
                NumQuanti.Value = drProduto("Quantidade").ToString
                txtUrlFoto.Text = drProduto("Foto").ToString
                diretorio = drProduto("Foto").ToString

                img = Image.FromFile(txtUrlFoto.Text.ToString)
                PicPreImagem.Image = img

            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro! " & vbNewLine & Err.Description, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        cmdProduto.Parameters.Clear()
        cmdProduto = Nothing
        drProduto.Close()

    End Sub

    Private Sub btn_Voltar_Click(sender As Object, e As EventArgs) Handles btn_Voltar.Click
        If strAcao = "Gravar" Then
            If MessageBox.Show("Deseja Cancelar ? " & vbNewLine & "Alterações Não Salvas Serão Perdidas!", "Sair", _
                            MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Me.Hide()
                Me.Close()
            End If
        Else
            Me.Hide()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If (strAcao = "Editar") Then
            Call habilitaCampos()
            btn_Editar.Text = strAcao
        ElseIf (strAcao = "Gravar") Then
            Dim quantidade As Integer = NumQuanti.Value
            Dim quantidadeMinima As Integer = NumQuantiMini.Value

            If MessageBox.Show("Deseja Realmente Alterar os Dados?", "Alterar", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim cmdProduto As New SqlClient.SqlCommand(strSql, cnnBanco)

                Try
                    If File.Exists(diretorio) = True Then
                        strSql = " UPDATE PRODUTO SET " & "Cod_Fornecedor=@Cod_Fornecedor," & "Nome_Produto=@Nome_Produto," & "Tipo_Produto=@Tipo_Produto," & "Descricao=@Descricao," _
                            & "Custo=@Custo," & "Quantidade=@Quantidade," & "QuantMinima=@QuantMinima" & " WHERE Cod_Produto=@Cod_Produto"

                    Else
                        File.Copy(txtUrlFoto.Text, diretorio)
                        strSql = "EXECUTE PR_EDIT_PROD @Cod_Produto, @Cod_Fornecedor, @Nome_Produto, @Tipo_Produto, @Descricao, @Custo, @Quantidade, @QuantMinima, @Foto"
                    End If
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um Erro Inesperado! " & vbNewLine & Err.Description, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                cmdProduto.Connection = cnnBanco
                cmdProduto.CommandText = strSql

                cmdProduto.Parameters.AddWithValue("@Cod_Produto", idCLient.ToString)
                cmdProduto.Parameters.AddWithValue("@Cod_Fornecedor", CInt(txtCodFornec.Text.Trim))

                cmdProduto.Parameters.AddWithValue("@Nome_Produto", txtNomeProd.Text.Trim)
                cmdProduto.Parameters.AddWithValue("@Tipo_Produto", txtTipo.Text.Trim)
                cmdProduto.Parameters.AddWithValue("@Descricao", txtDescricao.Text.Trim)

                cmdProduto.Parameters.AddWithValue("@Custo", txtCusto.Text.Replace(".", "").Replace(",", "."))
                cmdProduto.Parameters.AddWithValue("@Quantidade", quantidade)
                cmdProduto.Parameters.AddWithValue("@QuantMinima", quantidadeMinima)
                cmdProduto.Parameters.AddWithValue("@Foto", txtUrlFoto.Text)

                Try
                    cmdProduto.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um Erro ao Atualizar os Dados" & vbNewLine & Err.Description, "Atualizar Dados", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cmdProduto.Parameters.Clear()
                    Exit Sub
                End Try
                cmdProduto.Parameters.Clear()
                MessageBox.Show("Dados Atulizados Com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call Frm_GerenProduto.Preencher_Grid_Produto()
                ' Call Frm_GerenProduto.PCarregaImagemDataGrid()
                Frm_GerenProduto.TimerNotificacao.Enabled = True
                Frm_Principal.Timer2.Enabled = True
                Frm_GerenProduto.Refresh()
                Me.Close()
            End If

        End If
    End Sub

    Public Sub habilitaCampos()
        txtNomeProd.Enabled = True
        txtTipo.Enabled = True
        txtDescricao.Enabled = True
        txtCodFornec.Enabled = True
        txtCusto.Enabled = True
        NumQuanti.Enabled = True
        txtUrlFoto.Enabled = True
        txtUrlFoto.ReadOnly = True
        btn_EnviarFoto.Enabled = True
        PicPreImagem.Enabled = True
        btn_Excluir.Enabled = True
        strAcao = "Gravar"
        txtNomeProd.Focus()
    End Sub


    Public Function validaDados()
        If (txtNomeProd.Text.Trim = "") Then
            MsgBox("O Campo Nome, é de Preenchimento Obrigatório!", MsgBoxStyle.Information)
            txtNomeProd.Focus()
            txtNomeProd.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtNomeProd.BackColor = System.Drawing.Color.White
        End If

        If (txtTipo.Text.Trim = "") Then
            MsgBox("O Campo Tipo do Produto, é de Preenchimento Obrigatório!", MsgBoxStyle.Information)
            txtTipo.Focus()
            txtTipo.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtTipo.BackColor = System.Drawing.Color.White
        End If

        If (txtDescricao.Text.Trim = "") Then
            MsgBox("O Campo Descrição, é de Preenchimento Obrigatório!", MsgBoxStyle.Information)
            txtDescricao.Focus()
            txtDescricao.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtDescricao.BackColor = System.Drawing.Color.White
        End If

        If (txtCodFornec.Text.Trim = "") Then
            MsgBox("O Campo Código do Fornecedor, é de Preenchimento Obrigatório!", MsgBoxStyle.Information)
            txtCodFornec.Focus()
            txtCodFornec.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtCodFornec.BackColor = System.Drawing.Color.White
        End If

        If (txtCusto.Text.Trim = "0,00") Then
            MsgBox("O Campo Valor, é de Preenchimento Obrigatório!", MsgBoxStyle.Information)
            txtCusto.Focus()
            txtCusto.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtCusto.BackColor = System.Drawing.Color.White
        End If

        If (txtUrlFoto.Text.Trim = "") Then
            MsgBox("Por Favor, Selecione a Imagem do Produto!", MsgBoxStyle.Information)
            txtUrlFoto.Focus()
            txtUrlFoto.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtUrlFoto.BackColor = System.Drawing.Color.White
        End If

        Return True
    End Function




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
            diretorio = "C:\\imagemBanco" + "\" + Replace(tempo, ":", "-") + ".Jpg"

            PicPreImagem.Image = img

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Carregar a imagem para pré-visualização:" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Excluir_Click(sender As Object, e As EventArgs) Handles btn_Excluir.Click
        Dim cmdProduto As New SqlClient.SqlCommand

        If (MessageBox.Show("Deseja Ecluir Este Usuário?", "Confirmção", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then

            strSql = "EXECUTE PR_DEL_PROD @Cod_Prod"
            cmdProduto.Connection = cnnBanco
            cmdProduto.CommandText = strSql
            cmdProduto.Parameters.AddWithValue("@Cod_Prod", idCLient.ToString)

            Try
                cmdProduto.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um Erro Inesperado!" & vbNewLine & Err.Description, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            MessageBox.Show("Produto Excluído Com Sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmdProduto.Parameters.Clear()
            cmdProduto = Nothing
            Frm_GerenProduto.Preencher_Grid_Produto()
            Me.Close()

        End If
    End Sub

    Private Sub txtCusto_TextChanged(sender As Object, e As EventArgs)
        dinheiro(txtCusto)
    End Sub

    Public Shared Sub dinheiro(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(".", "").Replace(",", "")
            If n.Equals("") Then n = ""
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            MessageBox.Show("Erro: " & vbNewLine & Err.Description)
        End Try
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tempo(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class