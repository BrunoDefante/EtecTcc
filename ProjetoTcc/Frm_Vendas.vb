Public Class Frm_Vendas
    Private blnNovoItem As Boolean = True

    Private valorEstoque, seque As Integer
    Dim totalPedido As Double

    Public Property totPed As Double
        Get
            totPed = totalPedido
        End Get
        Set(value As Double)

        End Set
    End Property


    Private Sub Frm_Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objBanco As New ClsBanco
        Dim strMensagem As String = ""

        lbData.Text = Format(CDate(Now), "dd/MM/yyyy").ToString

        dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cnnBanco = objBanco.AbrirConexao("", strMensagem)

        If cnnBanco.State = ConnectionState.Closed Then
            MessageBox.Show("Ocorreu um Erro: " & strMensagem)
            End
        End If


        Try
            strSql = "SELECT Nome From Funcionarios Where Funcao='Vendedor' "

            Dim cmdVend As New SqlClient.SqlCommand(strSql, cnnBanco)
            Dim daVend As New SqlClient.SqlDataAdapter(cmdVend)
            Dim dtVend As New DataTable

            daVend.Fill(dtVend)

            combVendedor.ValueMember = "Cod_Func"
            combVendedor.DisplayMember = "Nome"

            combVendedor.DataSource = dtVend
            Call NumeroDoPedido()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Listar Vendedores!" & vbNewLine & Err.Description, "Erro, Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


    End Sub

    Private Sub btnConsCliente_Click(sender As Object, e As EventArgs) Handles btnConsCliente.Click
        Dim objConsCliente As Frm_ConsultaCliente = Frm_ConsultaCliente
        '  objConsCliente.MdiParent = Frm_Principal
        objConsCliente.ShowDialog()

        If objConsCliente.Confirm = True Then
            MsgBox(objConsCliente.NomeCLiente.ToString)
            txtCodCliente.Text = objConsCliente.CodCliente
            txtNomeCliente.Text = objConsCliente.NomeCLiente
        End If
        objConsCliente = Nothing
    End Sub

    

    Private Sub txtCodCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodCliente.Validating
        Dim drCliente As SqlClient.SqlDataReader
        Dim cmdCliente As New SqlClient.SqlCommand

        If Val(txtCodCliente.Text) = 0 Then Exit Sub
        strSql = "Select * From Dados_Cliente Where Cod_Cliente=" & txtCodCliente.Text.ToString
        cmdCliente.Connection = cnnBanco
        cmdCliente.CommandText = strSql
        drCliente = cmdCliente.ExecuteReader
        If drCliente.HasRows = False Then
            MessageBox.Show("Código de Cliente não Localizado", "Consultar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodCliente.Text = ""
            txtNomeCliente.Text = ""
            e.Cancel = True
        Else
            drCliente.Read()
            txtNomeCliente.Text = drCliente("Nome").ToString
        End If
        cmdCliente = Nothing
        drCliente.Close()
    End Sub

    Private Sub btnConsProd_Click(sender As Object, e As EventArgs) Handles btnConsProd.Click
        Dim objProduto As Frm_ConsProduto = Frm_ConsProduto
        '  objProduto.MdiParent = Frm_Principal
        objProduto.ShowDialog()

        If objProduto.Confirm = True Then
            txtCodProd.Text = objProduto.CodigoProd
            txtQuantEstoque.Text = "Qtde. Estoque: " & objProduto.QuantEstoque
            quantStoque = objProduto.QuantEstoque
            txtPrecoUnit.Text = FormatCurrency(objProduto.PrecoUnit)
            txtDescricao.Text = objProduto.Descricao
            valorEstoque = objProduto.QuantEstoque

        End If
    End Sub

    

    Private Sub txtCodProd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodProd.Validating
        Dim drProduto As SqlClient.SqlDataReader
        Dim cmdProduto As New SqlClient.SqlCommand

        If Val(txtCodProd.Text) = 0 Then Exit Sub
        strSql = "Select * From Produto Where Cod_Produto=" & txtCodProd.Text.ToString
        cmdProduto.Connection = cnnBanco
        cmdProduto.CommandText = strSql
        drProduto = cmdProduto.ExecuteReader
        If drProduto.HasRows = False Then
            MessageBox.Show("Código do Produto não Localizado", "Consultar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodCliente.Text = ""
            txtNomeCliente.Text = ""
            e.Cancel = True
        Else
            Dim objProduto As Frm_ConsProduto = Frm_ConsProduto
            drProduto.Read()
            txtCodProd.Text = drProduto("Cod_Produto").ToString
            txtQuantEstoque.Text = "Qtde. Estoque: " & drProduto("Quantidade").ToString
            quantStoque = drProduto("Quantidade").ToString
            txtPrecoUnit.Text = FormatCurrency(drProduto("Custo")).ToString
            txtDescricao.Text = drProduto("Descricao").ToString
            valorEstoque = drProduto("Quantidade").ToString
        End If
        cmdProduto = Nothing
        drProduto.Close()
    End Sub

    Private Sub txtPrecoUnit_TextChanged(sender As Object, e As EventArgs) Handles txtPrecoUnit.TextChanged


    End Sub

    Private Sub NumQuantProd_ValueChanged(sender As Object, e As EventArgs) Handles NumQuantProd.ValueChanged
        If txtCodProd.Text <> "" Then
            If NumQuantProd.Value > valorEstoque Then
                MessageBox.Show("A Quantidade de Produto Não pode ser Maior que A Quantidade No Estoque!!!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                NumQuantProd.Value = valorEstoque
            End If
        End If

    End Sub



    Private Sub AtualizaPreco() Handles Timer1.Tick
        Dim PrecoUnitario, quantidade As Double

        PrecoUnitario = Replace(txtPrecoUnit.Text, "R$", "")
        quantidade = NumQuantProd.Value
        txtPrecoTotProd.Text = FormatCurrency(PrecoUnitario * quantidade)

    End Sub
    Private Sub btnAddProd_Click(sender As Object, e As EventArgs) Handles btnAddProd.Click

        For i As Integer = 0 To dgvPedido.RowCount - 1
            If txtCodProd.Text.Trim = dgvPedido.Item(2, i).Value.ToString Then
                MessageBox.Show("Produto Já Existente!", "Adicionar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next


        If validaCampos() = True Then
            seque += +1

            With dgvPedido
                .Rows.Add(lbNumPedido.Text, txtCodCliente.Text, txtCodProd.Text, quantStoque, txtDescricao.Text, NumQuantProd.Value, txtPrecoUnit.Text, txtPrecoTotProd.Text)
                btnRemoveProd.Enabled = True

            End With
        End If
    End Sub

    Private Sub btnRemoveProd_Click(sender As Object, e As EventArgs) Handles btnRemoveProd.Click
        seque += -1
        With dgvPedido

            If seque >= 0 Then
                .Rows.Remove(dgvPedido.CurrentRow)
            Else
                btnRemoveProd.Enabled = False
            End If
        End With
    End Sub

    Private Sub dgvPedido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedido.CellContentClick

    End Sub

    Public Function validaCampos()
        If txtCodCliente.Text.Trim = "" Then
            MessageBox.Show("O Campo Código Cliente, é Obrigatório!", "Adicionar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodCliente.Focus()
            Return False
        End If
        If txtCodProd.Text.Trim = "" Then
            MessageBox.Show("O Campo Código do Produto, é Obrigatório!", "Adicionar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodProd.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub PSomaDataGridView() Handles Timer1.Tick
        Dim linha As DataGridViewRow
        Dim valor As Double

        For Each linha In dgvPedido.Rows
            valor = valor + linha.Cells("colSub_Total").Value
        Next
        lbPrecoTotPed.Text = CStr(FormatCurrency(valor))
        totalPedido = valor

    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click

        If dgvPedido.Rows.Count = 0 Then
            MessageBox.Show("Nenhum Produto Inserido!!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else

            Dim objPagamento As Frm_Vendas_Pagamento = Frm_Vendas_Pagamento

            objPagamento.ShowDialog()
            If objPagamento.Confirm = True Then

                Try
                    For i As Integer = 0 To dgvPedido.Rows.Count - 1
                        strSql = "EXECUTE PR_VENDAS @Num_Pedido, @Cod_Cliente, @Cod_Produto, @Descricao, @Quantidade, @Sub_Total, @Tot_Ped, @Descontos, @Tipo_Pagamento, @Data, @Vendedor"

                        Dim cmdSalvarItens As New SqlClient.SqlCommand(strSql, cnnBanco)
                        Dim objFechaCompra As Frm_Vendas_Pagamento = Frm_Vendas_Pagamento

                        cmdSalvarItens.Parameters.Add("@Num_Pedido", SqlDbType.Int).Value = dgvPedido.Rows(i).Cells("colNumPed").Value
                        cmdSalvarItens.Parameters.Add("@Cod_Cliente", SqlDbType.Int).Value = dgvPedido.Rows(i).Cells("colCod_Cliente").Value
                        cmdSalvarItens.Parameters.Add("@Cod_Produto", SqlDbType.Int).Value = dgvPedido.Rows(i).Cells("colCod_Produto").Value
                        'cmdSalvarItens.Parameters.Add("@Nome_Cliente", SqlDbType.Int).Value = dgvPedido.Rows(i).Cells("colCod_Cliente").Value
                        cmdSalvarItens.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = dgvPedido.Rows(i).Cells("colDescricao").Value
                        cmdSalvarItens.Parameters.Add("@Quantidade", SqlDbType.Int).Value = dgvPedido.Rows(i).Cells("colQuant_Prod").Value
                        cmdSalvarItens.Parameters.Add("@Sub_Total", SqlDbType.VarChar).Value = dgvPedido.Rows(i).Cells("colSub_Total").Value
                        Dim totReplace As Double = Replace(objFechaCompra.TotalCompra, "R$", "")
                        cmdSalvarItens.Parameters.AddWithValue("@Tot_Ped", Replace(totReplace, ",", "."))
                        cmdSalvarItens.Parameters.AddWithValue("@Descontos", objFechaCompra.Descontos)
                        cmdSalvarItens.Parameters.AddWithValue("@Tipo_Pagamento", objFechaCompra.tipPagamento)
                        cmdSalvarItens.Parameters.AddWithValue("@Data", lbData.Text)
                        cmdSalvarItens.Parameters.AddWithValue("@Vendedor", combVendedor.Text)

                        cmdSalvarItens.Connection = cnnBanco
                        cmdSalvarItens.CommandText = strSql

                        cmdSalvarItens.ExecuteNonQuery()

                    Next
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um Erro ao Gravar dados da Compra!" & vbNewLine & Err.Description, "Vendas", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                '-- SAIDA DE PRODUTOS--'
                Try
                    For i As Integer = 0 To dgvPedido.Rows.Count - 1
                        strSql = "UPDATE Produto SET Quantidade=@Quantidade WHERE Cod_Produto=@Cod_Produto"

                        Dim cmdSaidaProdutos As New SqlClient.SqlCommand(strSql, cnnBanco)
                        Dim intSaidaProdutos As Integer
                        cmdSaidaProdutos.Parameters.Add("@Cod_Produto", SqlDbType.Int).Value = dgvPedido.Rows(i).Cells("colCod_Produto").Value

                        intSaidaProdutos = dgvPedido.Rows(i).Cells("colQuantEstoque").Value - dgvPedido.Rows(i).Cells("colQuant_Prod").Value

                        cmdSaidaProdutos.Parameters.Add("@Quantidade", SqlDbType.Int).Value = intSaidaProdutos

                        cmdSaidaProdutos.Connection = cnnBanco
                        cmdSaidaProdutos.CommandText = strSql

                        cmdSaidaProdutos.ExecuteNonQuery()
                    Next
                    MessageBox.Show("Venda Realizada Com Sucesso!", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Me.Close()
                Catch Ex As Exception
                    MessageBox.Show("Ocorreu um erro: " & vbNewLine & Err.Description, "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If
        End If

    End Sub

    Private Sub NumeroDoPedido()
        Dim drPed As SqlClient.SqlDataReader
        Dim cmdPed As New SqlClient.SqlCommand

        strSql = "SELECT Num_Pedido FROM Vendas ORDER BY Num_Pedido desc"

        cmdPed.Connection = cnnBanco
        cmdPed.CommandText = strSql

        Try
            drPed = cmdPed.ExecuteReader
        Catch ex As Exception
            MsgBox("Ocorreu um Erro: " & vbNewLine & Err.Description)
            cmdPed.Parameters.Clear()
            Exit Sub
        End Try

        Try
            If Not drPed.HasRows Then
                lbNumPedido.Text = "1"
            Else
                drPed.Read()
                lbNumPedido.Text = drPed("Num_Pedido").ToString + 1


            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um Erro ao Numerar o Pedido: " & vbNewLine & Err.Description, "Vendas", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

            cmdPed.Parameters.Clear()
            Exit Sub
        End Try
        cmdPed.Parameters.Clear()
        drPed.Close()
    End Sub

    Private Sub atualizaEstoque()

        '  Dim drPed As SqlClient.SqlDataReader
        Dim cmdPed As New SqlClient.SqlCommand

        strSql = "SELECT Quantidade From Produto Where Cod_Prod=@Cod_Prod"

        cmdPed.Connection = cnnBanco
        cmdPed.CommandText = strSql



    End Sub

    Private Sub btnCancelVenda_Click(sender As Object, e As EventArgs) Handles btnCancelVenda.Click
        If MessageBox.Show("Deseja Cancelar está Venda?", "Vendas", _
                           MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, _
                           MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            Me.Close()
        Else
        End If
    End Sub

    Public Sub bloqueiaLetras(e)
        If (Char.IsLetter(e.keyChar)) Then

            e.handled = True
        ElseIf (Char.IsPunctuation(e.keyChar)) Then
            e.handled = True
        ElseIf (Char.IsSymbol(e.keyChar)) Then
            e.handled = True
        End If


    End Sub
    Private Sub txtCodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress, txtCodProd.KeyPress, combVendedor.KeyPress
        bloqueiaLetras(e)
    End Sub

    Private Sub txtNomeCliente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNomeCliente.Validating
        Call procuraCliente(e)
    End Sub

    Public Sub procuraCliente(e)
        Dim drCliente As SqlClient.SqlDataReader
        Dim cmdCliente As New SqlClient.SqlCommand

        If txtNomeCliente.Text = "" Then Exit Sub
        strSql = "Select * From Dados_Cliente Where Nome=@Nome"

        cmdCliente.Parameters.AddWithValue("@Nome", txtNomeCliente.Text.ToString)
        cmdCliente.Connection = cnnBanco
        cmdCliente.CommandText = strSql
        drCliente = cmdCliente.ExecuteReader


        If drCliente.HasRows = False Then
            MessageBox.Show("Cliente não Localizado", "Consultar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodCliente.Text = ""
            txtNomeCliente.Text = ""
            e.Cancel = True
        Else
            drCliente.Read()
            txtCodCliente.Text = drCliente("Cod_Cliente").ToString
        End If
        cmdCliente = Nothing
        drCliente.Close()
    End Sub

    Private Sub btnCadCliente_Click(sender As Object, e As EventArgs) Handles btnCadCliente.Click
        Dim objCliente As Frm_CadClienteRapido = Frm_CadClienteRapido
        objCliente.ShowDialog()

        If objCliente.Confirm = True Then
            MsgBox(objCliente.NomeCliente.ToString)
            txtNomeCliente.Text = objCliente.NomeCliente.ToString
            Call procuraCliente(e)
        End If
        objCliente = Nothing


    End Sub
End Class