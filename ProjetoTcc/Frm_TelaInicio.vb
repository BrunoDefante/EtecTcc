Imports System.Windows.Forms
Imports System.IO

Public Class Frm_Principal
    Private m_ChildFormNumber As Integer
    Public a As Integer
    Public clickNotfic As Boolean = True


    Private Sub Frm_TelaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '--Efeito Fade---'
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            'Me.Refresh()
            Threading.Thread.Sleep(66)
        Next

        lbUser.Text = Users
        Dim objBanco As New ClsBanco
        Dim strMensagem As String = ""

        cnnBanco = objBanco.AbrirConexao("", strMensagem)

        If cnnBanco.State = ConnectionState.Closed Then
            MessageBox.Show("Ocorreu um Erro: " & strMensagem)
            End
        End If

        Call Preencher_Grid_Produto()

        ListNotifica.View = View.Details
        ListNotifica.FullRowSelect = True
        '  ListView1.Columns.Add("Notificação", 250)
        '  ListNotifica.Columns("colNotfica").TextAlign = HorizontalAlignment.Center



    End Sub

    Private Sub btn_GerCliente_Click(sender As Object, e As EventArgs) Handles btnGerCliente.Click
        Me.Cursor = Cursors.WaitCursor
        Call fechaTudo()
        Frm_GerenCliente.MdiParent = Me
        Frm_GerenCliente.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_GerUsers_Click(sender As Object, e As EventArgs) Handles btnGerUsuario.Click
        Me.Cursor = Cursors.WaitCursor
        Call fechaTudo()
        Frm_GerenUsers.MdiParent = Me
        Frm_GerenUsers.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_GerFornecedor_Click(sender As Object, e As EventArgs) Handles btnGerFornec.Click
        Me.Cursor = Cursors.WaitCursor
        Call fechaTudo()
        Frm_GerenFornec.MdiParent = Me
        Frm_GerenFornec.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Data.Text = CDate(Now)
    End Sub

    Private Sub Frm_Principal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(27) Then
            If MessageBox.Show("Deseja Fechar a Aplicação ?", "FECHAR?", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                For FadeIn = 90 To 10 Step -10
                    Me.Opacity = FadeIn / 100
                    ' Me.Refresh()
                    Threading.Thread.Sleep(66)
                Next
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub btn_Sair_Click(sender As Object, e As EventArgs) Handles btnP_Sair.Click
        If MessageBox.Show("Deseja Fechar a Aplicação ?", "FECHAR?", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            For FadeIn = 90 To 10 Step -10
                Me.Opacity = FadeIn / 100
                ' Me.Refresh()
                Threading.Thread.Sleep(66)
            Next
            Application.Exit()
        End If
    End Sub

    Private Sub btn_GerFuncionario_Click(sender As Object, e As EventArgs) Handles btnGerFunc.Click
        Me.Cursor = Cursors.WaitCursor
        Call fechaTudo()
        Frm_GerenFuncionario.MdiParent = Me
        Frm_GerenFuncionario.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_GerProdutos_Click(sender As Object, e As EventArgs) Handles btnGerProd.Click
        Me.Cursor = Cursors.WaitCursor
        Call fechaTudo()
        Dim objProd As Frm_GerenProduto = Frm_GerenProduto
        objProd.MdiParent = Me
        objProd.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub fechaTudo()
        Dim cliente As Frm_GerenCliente = Frm_GerenCliente
        Dim usuario As Frm_GerenUsers = Frm_GerenUsers
        Dim fornec As Frm_GerenFornec = Frm_GerenFornec
        Dim Func As Frm_GerenFuncionario = Frm_GerenFuncionario
        Dim produto As Frm_GerenProduto = Frm_GerenProduto
        Dim vendas As Frm_Vendas = Frm_Vendas
        Dim relatorio As Frm_Relatorio = Frm_Relatorio

        relatorio.Close()
        vendas.Close()
        cliente.Close()
        usuario.Close()
        fornec.Close()
        Func.Close()
        produto.Close()

    End Sub

    Private Sub btn_GerVendas_Click(sender As Object, e As EventArgs) Handles btnVenda.Click
        Me.Cursor = Cursors.WaitCursor
        Call fechaTudo()
        Dim objVenda As Frm_Vendas = Frm_Vendas
        objVenda.MdiParent = Me
        objVenda.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub notifica() Handles Timer2.Tick

        For i As Integer = 0 To dgvConsultaProduto.RowCount - 1

            If dgvConsultaProduto.Item("Quantidade", i).Value.ToString <= dgvConsultaProduto.Item("QuantMinima", i).Value.ToString Then
                PicNotfic.Image = Image.FromFile("C:\MediaTecno\vendas\sino11.png")
                Call ListviewPopular()
                Timer2.Enabled = False
                Exit Sub
            ElseIf dgvConsultaProduto.Item("Quantidade", i).Value.ToString > dgvConsultaProduto.Item("QuantMinima", i).Value.ToString Then
                PicNotfic.Image = Image.FromFile("C:\MediaTecno\vendas\sinopng.png")
                ListNotifica.Items.Clear()
            End If
        Next
    End Sub


    Private Sub ListviewPopular()
        Dim img As ImageList = New ImageList
        '      Dim foto As String

        Try

            img.ImageSize = New Size(50, 50)


            img.Images.Add(Image.FromFile("C:\MediaTecno\Icones\Gerenciar Produtos Final.png"))

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        ListNotifica.SmallImageList = img
        ListNotifica.Items.Add("Há Produtos com Estoque no Limite! ", 0)

    End Sub
    Public Sub Preencher_Grid_Produto() Handles Timer2.Tick
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

    Private Sub PicNotfic_Click(sender As Object, e As EventArgs) Handles PicNotfic.Click
        If clickNotfic = True Then
            ListNotifica.Visible = True
            clickNotfic = False
        Else
            ListNotifica.Visible = False
            clickNotfic = True
        End If

    End Sub

    Private Sub ListNotifica_DoubleClick(sender As Object, e As EventArgs) Handles ListNotifica.Click
        Dim item As String
        item = ListNotifica.SelectedItems(0).SubItems(0).Text

        If item = item Then
            PicNotfic.Image = Image.FromFile("C:\MediaTecno\vendas\sinopng.png")
            ListNotifica.Items.Clear()
            Timer2.Enabled = True
            ListNotifica.Visible = False
            Dim objProduto As Frm_GerenProduto = Frm_GerenProduto

            objProduto.MdiParent = Me
            objProduto.Show()
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles antBug.Click
        Timer2.Enabled = True
    End Sub

    Private Sub btnRelato_Click(sender As Object, e As EventArgs) Handles btnRelato.Click
        Me.Cursor = Cursors.WaitCursor
        Call fechaTudo()
        Dim objRelatorio As Frm_Relatorio = Frm_Relatorio
        objRelatorio.MdiParent = Me
        objRelatorio.Show()
        Me.Cursor = Cursors.Default

    End Sub
End Class
