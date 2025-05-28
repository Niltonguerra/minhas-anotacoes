Public Class entrar
    Private Sub Lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click
        login.ShowDialog()
    End Sub

    Private Sub Lbl_Cadastrar_Click(sender As Object, e As EventArgs) Handles lbl_Cadastrar.Click
        cadastro.ShowDialog()
    End Sub
End Class