Public Class cadastro
    Private Sub cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()

    End Sub
    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_cadastrar_cliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_cliente.Click
        Try

            SQL = "select * from Cliente where cpf ='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("conta já existente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            Else

                If txt_senha.Text = txt_senhaconfirmar.Text Then

                    SQL = "insert into Cliente(nome,cpf,telefone,Email,dt_aniver,senha,foto) values ('
                    " & txt_nome.Text & "', '" & txt_cpf.Text & "','" & txt_fone.Text & "','" & txt_email.Text & "','" & txt_dtNasc.Value.Date & "', '" & txt_senha.Text & "','" & diretorio & "')"
                    rs = db.Execute(UCase(SQL))
                    MsgBox("Usuario Criado com sucessso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    clienteLogado = txt_cpf.Text
                    contacliente.Show()
                Else
                    MsgBox("Senhas não conhecidem!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao Cadastrar Cliente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class