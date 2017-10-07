Imports System.IO
Public Class Frm_GerenProduto
    Private diretorio As String
    Public Function tempo() Handles MyBase.Load
        Dim hora As String = Replace(CDate(Now), "/", "-")
        hora = Replace(hora, ":", "-")
        Return hora
    End Function
    Public Sub Preencher_Grid_Produto()
        Try
            strSql = "SELECT COD_PRODUTO, NOME_PRODUTO, TIPO_PRODUTO, CUSTO, FOTO, QUANTIDADE, QUANTMINIMA FROM PRODUTO " & _
                "ORDER BY COD_PRODUTO"

            Dim cmdProduto As New SqlClient.SqlCommand(strSql, cnnBanco)
            Dim daProduto As New SqlClient.SqlDataAdapter(cmdProduto)
            Dim tblProduto As New DataTable
            daProduto.Fill(tblProduto)
            dgvConsultaProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

            With dgvConsultaProduto
                .Columns("FOTO").Visible = False
            End With

            dgvConsultaProduto.DataSource = tblProduto

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro!" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Frm_GerenProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Preencher_Grid_Produto()
        ' Call PCarregaImagemDataGrid()
    End Sub


    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Deseja Cancelar o Cadastro ?", "Cancelar ?",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Exclamation,
                           MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            Me.Close()
        End If
    End Sub


    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Call habilitaCampos()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim quantProd As Integer = NumQuanti.Value
        Dim quantMinima As Integer = NumQuantiMini.Value

        If validaDados() = True Then
            Dim cmdProduto As New SqlClient.SqlCommand
            Try
                File.Copy(txtUrlFoto.Text, diretorio)
            Catch ex As Exception
                MessageBox.Show("Ocorreu Um Erro ao Gravar Imagem: " & vbNewLine & Err.Description, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            strSql = "EXECUTE PC_INC_PROD @Cod_Fornec, @Nome_Produto, @Tipo_Produto, @Descricao, @Custo, @Quantidade, @QuantMinima, @Foto"

            cmdProduto.Connection = cnnBanco
            cmdProduto.CommandText = strSql

            cmdProduto.Parameters.AddWithValue("@Cod_Fornec", txtCodFornec.Text.Trim)
            cmdProduto.Parameters.AddWithValue("@Nome_Produto", txtNome.Text.Trim)
            cmdProduto.Parameters.AddWithValue("@Tipo_Produto", txtTipo.Text.Trim)
            cmdProduto.Parameters.AddWithValue("@Descricao", txtDescricao.Text.Trim)
            cmdProduto.Parameters.AddWithValue("@Custo", txtCusto.Text.Replace(".", "").Replace(",", "."))
            cmdProduto.Parameters.AddWithValue("@Quantidade", quantProd)
            cmdProduto.Parameters.AddWithValue("@QuantMinima", quantMinima)
            cmdProduto.Parameters.AddWithValue("@Foto", diretorio)

            Try
                cmdProduto.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Ocorreu um Erro ao Gravar os Dados! " & vbNewLine & Err.Description, "Gravar Dados", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmdProduto.Parameters.Clear()
                Exit Sub
            End Try
            cmdProduto.Parameters.Clear()
            MessageBox.Show("Produto Cadastrado Com Sucesso!", "Gravar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Preencher_Grid_Produto()
            ' Call PCarregaImagemDataGrid()
            Call limpaCampos()

        End If
    End Sub

    Public Sub habilitaCampos()
        txtNome.Enabled = True
        txtTipo.Enabled = True
        txtDescricao.Enabled = True
        txtCodFornec.Enabled = True
        txtCusto.Enabled = True
        NumQuanti.Enabled = True
        NumQuantiMini.Enabled = True
        txtUrlFoto.Enabled = True
        txtUrlFoto.ReadOnly = True
        btn_EnviarFoto.Enabled = True
        btnCadastrar.Enabled = True
        PicPreImagem.Enabled = True
        btnConsFornec.Enabled = True
        txtNome.Focus()
    End Sub

    Public Sub limpaCampos()
        txtNome.Text = ""
        txtTipo.Text = ""
        txtDescricao.Text = ""
        txtCodFornec.Text = ""
        txtCusto.Text = ""
        NumQuanti.Text = ""
        txtUrlFoto.Text = ""
        txtUrlFoto.ReadOnly = True
        btn_EnviarFoto.Text = ""
        btnCadastrar.Text = ""
        PicPreImagem.Text = ""
        txtNome.Focus()
    End Sub

    Public Function validaDados()
        If (txtNome.Text.Trim = "") Then
            MsgBox("O Campo Nome, é de Preenchimento Obrigatório!", MsgBoxStyle.Information)
            txtNome.Focus()
            txtNome.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtNome.BackColor = System.Drawing.Color.White
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

    Private Sub txtCusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCusto.KeyPress
        bloqueiaLetras(e)
    End Sub

    Private Sub txtCusto_LostFocus(sender As Object, e As EventArgs) Handles txtCusto.LostFocus
   

    End Sub

    Private Sub bloqueiaLetras(e)
        'If (e.KeyChar = (",")) Then
        '    e.handled = False
        'End If

        If (Char.IsLetter(e.keyChar)) Then
            e.handled = True
            'ElseIf (Char.IsPunctuation(e.keyChar)) Then
            '    e.handled = True
        ElseIf (Char.IsSymbol(e.keyChar)) Then
            e.handled = True
        End If
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
            diretorio = "C:\imagemBanco\Produtos" + "\" + Replace(tempo, ":", "-") + ".Jpg"
            PicPreImagem.Image = img

        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Carregar a imagem para pré-visualização:" & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub NumQuanti_ValueChanged(sender As Object, e As EventArgs) Handles NumQuanti.ValueChanged

    End Sub

    'Public Sub PCarregaImagemDataGrid() Handles Timer1.Tick
    '    Dim img As Image
    '    Try
    '        For i As Integer = 0 To dgvConsultaProduto.RowCount - 1

    '            img = Image.FromFile(dgvConsultaProduto.Rows(i).Cells("Foto").Value.ToString)
    '            dgvConsultaProduto.Rows(i).Cells("FotosProdutos").Value = img
    '        Next
    '    Catch ex As Exception
    '        Timer1.Enabled = False
    '        MessageBox.Show("Ocorreu um Erro ao Listar as Fotos dos Produtos: " & vbNewLine & Err.Description, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub

    '    End Try
    'End Sub

    Private Sub btn_Consultar_Click(sender As Object, e As EventArgs) Handles btn_Consultar.Click
        idCLient = dgvConsultaProduto.CurrentRow.Cells(1).Value.ToString
        Dim objEditProd As Frm_EditProd = Frm_EditProd
        objEditProd.MdiParent = Frm_Principal
        objEditProd.Show()
    End Sub

    Private Sub verificaEstoque() Handles TimerNotificacao.Tick
        Dim menssagem As Boolean
        For i As Integer = 0 To dgvConsultaProduto.RowCount - 1

            If dgvConsultaProduto.Item("Quantidade", i).Value.ToString <= dgvConsultaProduto.Item("QuantMinima", i).Value.ToString Then
                menssagem = True
                With dgvConsultaProduto
                    .Rows(i).DefaultCellStyle.BackColor = Color.Red
                    .Rows(i).DefaultCellStyle.ForeColor = Color.White
                    TimerNotificacao.Enabled = False


                    If .CurrentRow.Cells(6).Value < .CurrentRow.Cells(7).Value Then
                        .Rows(i).DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OrangeRed
                    End If

                End With

            End If
        Next
        If menssagem = True Then
            MessageBox.Show("Atenção Existem Produtos Abaixo do Estoque Limite!!!", "Produtos", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

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

    Private Sub txtCusto_TextChanged(sender As Object, e As EventArgs) Handles txtCusto.TextChanged
        dinheiro(txtCusto)

    End Sub

    Private Sub txtCusto_Validated(sender As Object, e As EventArgs) Handles txtCusto.Validated
        'txtCusto.Text = Format(CDbl(txtCusto.Text), "#,##0.00")
    End Sub

    Private Sub btnConsFornec_Click(sender As Object, e As EventArgs) Handles btnConsFornec.Click
        Dim objFornec As Frm_ConsultaFornecedor = Frm_ConsultaFornecedor
        objFornec.ShowDialog()

        If objFornec.Confirm = True Then
            txtCodFornec.Text = objFornec.CodigoFornec
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class