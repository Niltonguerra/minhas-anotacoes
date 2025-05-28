Public Class frm_numero

    Dim v1, v2, v3, maior As Integer
    Private Sub Btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click

        Try
            v1 = txt_numero1.Text
            v2 = txt_numero2.Text
            v3 = txt_numero3.Text

            If v1 > v2 And v1 > v3 Then
                maior = v1
            ElseIf v2 > v1 And v2 > v3 Then
                maior = v2
            ElseIf v3 > v1 And v3 > v2 Then
                maior = v3
            End If
            lbl_maiorNumero.Text = maior
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try

    End Sub
End Class