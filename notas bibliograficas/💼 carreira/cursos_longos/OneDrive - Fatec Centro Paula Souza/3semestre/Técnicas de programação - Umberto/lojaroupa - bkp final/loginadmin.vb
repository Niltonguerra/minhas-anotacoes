Public Class loginadmin
    Private Sub Lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click

        If txt_user.Text = "admin" And txt_senha.Text = "admin" Then
            contaadmin.Show()

        Else
            MsgBox("Conta não existente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
        End If
    End Sub

End Class