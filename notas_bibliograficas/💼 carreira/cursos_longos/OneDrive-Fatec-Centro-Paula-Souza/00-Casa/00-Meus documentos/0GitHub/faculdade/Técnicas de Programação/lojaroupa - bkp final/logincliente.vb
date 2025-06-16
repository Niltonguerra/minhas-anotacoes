Public Class logincliente

    Private Sub logincliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar_banco()

    End Sub

    Private Sub btn_logincliente_Click(sender As Object, e As EventArgs) Handles btn_logincliente.Click

        SQL = "Select Cpf from Cliente where nome = '" & txt_user.Text & "' and senha = '" & txt_senha.Text & "' or email = '" & txt_user.Text & "' and senha = '" & txt_senha.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = True Then
            MsgBox("Conta não existente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
        Else
            clienteLogado = rs.Fields(0).Value
            contacliente.Show()
        End If

    End Sub
End Class