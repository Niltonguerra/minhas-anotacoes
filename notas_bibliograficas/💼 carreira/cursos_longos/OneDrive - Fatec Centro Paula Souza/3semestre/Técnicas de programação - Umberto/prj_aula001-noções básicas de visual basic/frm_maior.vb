Public Class frm_maior
    Dim n, antecessor, sucessor As Integer

    Private Sub Txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged

    End Sub

    Private Sub Btn_redefinir_Click(sender As Object, e As EventArgs) Handles btn_redefinir.Click
        Try
            txt_numero.Clear()
            lbl_antecessor.Text = ""
            lbl_sucessor.Text = ""
            txt_numero.Focus()
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try

    End Sub


    Private Sub Btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            n = txt_numero.Text
            lbl_antecessor.Text = n - 1
            lbl_sucessor.Text = n + 1


        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub


End Class