Public Class Frm_Relatorio


    Private Sub Frm_Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VendasTableAdapter.Fill(Me.DB_ESTOQUEDataSet.Vendas)
        Me.ReportViewer1.RefreshReport()


    End Sub


    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Me.VendasTableAdapter.usp_Consulta_Data(Me.DB_ESTOQUEDataSet.Vendas, DtInicio.Value.ToString.Replace("00:00:00", ""), DtFim.Value.ToString.Replace("00:00:00", ""))

        Me.ReportViewer1.RefreshReport()
        
    End Sub

    Private Sub btnLimapar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Me.VendasTableAdapter.Fill(Me.DB_ESTOQUEDataSet.Vendas)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub rbSim_CheckedChanged(sender As Object, e As EventArgs) Handles rbSim.CheckedChanged
        If rbSim.Checked = True Then
            DtInicio.Enabled = True
            DtFim.Enabled = True
            btnFiltrar.Enabled = True
            btnLimpar.Enabled = True
        End If
    End Sub

    Private Sub rbNao_CheckedChanged(sender As Object, e As EventArgs) Handles rbNao.CheckedChanged
        If rbSim.Checked = False Then
            DtInicio.Enabled = False
            DtFim.Enabled = False
            btnLimpar.PerformClick()
            btnFiltrar.Enabled = False
            btnLimpar.Enabled = False
        End If
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub
End Class