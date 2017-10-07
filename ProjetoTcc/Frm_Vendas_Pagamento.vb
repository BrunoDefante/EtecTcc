Public Class Frm_Vendas_Pagamento

    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer

    Protected regionHandle As IntPtr
    Public tipoPagamento As String
    Public blnConfirm As Boolean = False
    Dim objPagamento As Frm_Vendas = Frm_Vendas
    Public pagamento As Double = objPagamento.totPed
    Public verificaDesc As Boolean = False

    Public Property tipPagamento As String
        Get
            tipPagamento = tipoPagamento
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Confirm As Boolean
        Get
            Confirm = blnConfirm
        End Get
        Set(value As Boolean)
            blnConfirm = value
        End Set
    End Property

    Public Property Descontos As String
        Get
            Descontos = lbDescontos.Text
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property TotalCompra As String
        Get
            TotalCompra = lbTotal.Text
        End Get
        Set(value As String)

        End Set
    End Property


    Private Sub Frm_Vendas_Pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ARREDONDANDO a Label
        regionHandle = New IntPtr(CreateRoundRectRgn(0, 0, lbTipPag.Width, lbTipPag.Height, 20, 20))
        lbTipPag.Region = Region.FromHrgn(regionHandle)
        lbTipPag.Region.ReleaseHrgn(regionHandle)

        dgvFormaPagamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        txtValor.Text += "1"

    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs)
        txtValor.Text += "2"
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs)
        txtValor.Text += "3"
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs)
        txtValor.Text += "4"
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs)
        txtValor.Text += "5"
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs)
        txtValor.Text += "6"
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs)
        txtValor.Text += "7"
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs)
        txtValor.Text += "8"
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs)
        txtValor.Text += "9"
    End Sub

    Private Sub btnNum0_Click(sender As Object, e As EventArgs)
        txtValor.Text += "0"
    End Sub

    Private Sub btnNumVirgula_Click(sender As Object, e As EventArgs)
        txtValor.Text += ","
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs)
        txtValor.Text = ""
    End Sub

  
    Private Sub RbDinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles RbDinheiro.CheckedChanged
        tipoPagamento = "Dinheiro"
        PcarregaDadosGridView()

    End Sub

    Private Sub RbCheque_CheckedChanged(sender As Object, e As EventArgs) Handles RbCheque.CheckedChanged
        tipoPagamento = "Cheque"
        PcarregaDadosGridView()
    End Sub

    Private Sub RbCartCredito_CheckedChanged(sender As Object, e As EventArgs) Handles RbCartCredito.CheckedChanged
        tipoPagamento = "Cartão de Crédito"
        PcarregaDadosGridView()
    End Sub

    Private Sub RbCartDebito_CheckedChanged(sender As Object, e As EventArgs) Handles RbCartDebito.CheckedChanged
        tipoPagamento = "Cartão de Débito"
        PcarregaDadosGridView()
    End Sub

    Public Sub PcarregaDadosGridView()
        Dim objVendas As Frm_Vendas = Frm_Vendas

        With dgvFormaPagamento
            .Rows.Add(tipPagamento, FormatCurrency(pagamento))
            If .Rows.Count > 1 Then
                .Rows.Remove(dgvFormaPagamento.CurrentRow)
            End If

            If .Rows.Count = 1 Then

            End If

            For i As Integer = 0 To dgvFormaPagamento.RowCount - 1

                Try
                    If tipPagamento <> .Item(0, i).Value.ToString Then
                        Timer1.Enabled = True
                    Else
                        Timer1.Enabled = False
                    End If
                Catch ex As Exception
                    Timer1.Enabled = False
                    MsgBox(Err.Description)

                End Try
            Next

            lbTotal.Text = FormatCurrency(pagamento)

        End With


    End Sub
  
    Private Sub btnDescontoS_Click(sender As Object, e As EventArgs) Handles btnDescontoS.Click
        If MessageBox.Show("Deseja Fazer um Desconto com o Valor Digitado Acima ? ", "Descontos", _
                           MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, _
                           MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            verificaDesc = True
            lbDescontos.Text = FormatCurrency(txtValor.Text)
            lbTotal.Text = FormatCurrency(lbTotal.Text - lbDescontos.Text)

        End If
    End Sub

    Private Sub btnDescontosP_Click(sender As Object, e As EventArgs) Handles btnDescontosP.Click
        If MessageBox.Show("Deseja Fazer um Desconto com o Valor Digitado Acima ? ", "Descontos", _
                                  MessageBoxButtons.YesNo, _
                                  MessageBoxIcon.Question, _
                                  MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            verificaDesc = True
            lbDescontos.Text = FormatPercent(txtValor.Text / 100)
            Dim descontoPorcent As Double

            descontoPorcent = (lbTotal.Text / 100 * txtValor.Text)
         
            Dim valorDesconto As Double = Format(descontoPorcent, "#,##0.00") - Replace(lbTotal.Text, "R$", "")
            Dim totalDinheiro As Double = Replace(lbTotal.Text, "R$", "")

            If totalDinheiro < valorDesconto Then
                MessageBox.Show("O Valor do Desconto é superior ao da compra" & vbNewLine & "Por Favor, informe um valor menor!")
                lbDescontos.Text = "0,00"

            Else
                lbDescontos.Text = FormatPercent(txtValor.Text / 100)
                lbTotal.Text = FormatCurrency(lbTotal.Text - descontoPorcent)
            End If


        End If
    End Sub

    Private Sub btnFecharPedido_Click(sender As Object, e As EventArgs) Handles btnFecharPedido.Click
        If verificaDados() = True Then


            If MessageBox.Show("Deseja Fechar o Pedido e Concluir a Venda ?", "Venda", _
                               MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                blnConfirm = True
                Me.Hide()
            End If
        Else
            Exit Sub
        End If
    End Sub

    Public Function verificaDados()
        If txtValor.Text.Trim = "" And verificaDesc = True Then
            MessageBox.Show("O Campo Descontos, é de Preenchimento Obrigatório caso haja algum Desonto a ser Concedido!", "Descontos", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtValor.Focus()
            txtValor.BackColor = System.Drawing.Color.Yellow
            Return False
        Else
            txtValor.BackColor = Color.White
        End If

        If lbTotal.Text = "0,00" Then
            MessageBox.Show("Selecione O Meio de Pagamento!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If





        Return True
    End Function

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
       
    End Sub
End Class