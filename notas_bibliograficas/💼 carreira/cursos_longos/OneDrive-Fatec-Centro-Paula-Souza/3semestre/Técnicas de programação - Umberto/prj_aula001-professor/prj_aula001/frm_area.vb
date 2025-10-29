Public Class frm_area
    Dim lado, area, perimetro As Double
    Private Sub Btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Try
            lado = txt_lado.Text
            area = (lado * lado)
            perimetro = (lado * 4)
            lbl_area.Text = area
            lbl_perimetro.Text = perimetro
        Catch ex As Exception
            MsgBox("Erro ao calcular", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        Try
            txt_lado.Clear()
            lbl_area.Text = ""
            lbl_perimetro.Text = ""
            txt_lado.Focus()
        Catch ex As Exception
            MsgBox("Erro ao limpar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class